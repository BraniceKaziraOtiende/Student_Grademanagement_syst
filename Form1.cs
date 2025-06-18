using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Dictionary<string, int> studentGrades = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();

            // Connect event handlers
            btnAdd.Click += BtnAdd_Click;
            btnDisplay.Click += BtnDisplay_Click;
            btnSearch.Click += BtnSearch_Click;
            btnAverage.Click += BtnAverage_Click;
            btnHighLow.Click += BtnHighLow_Click;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string gradeText = txtGrade.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a student name.", "Input Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (!int.TryParse(gradeText, out int grade) || grade < 0 || grade > 100)
            {
                MessageBox.Show("Please enter a valid grade (0-100).", "Input Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGrade.Focus();
                return;
            }

            bool exists = studentGrades.ContainsKey(name);
            studentGrades[name] = grade;

            lstOutput.Items.Add(exists
                ? $"Updated: {name} - Grade: {grade}"
                : $"Added: {name} - Grade: {grade}");

            txtName.Clear();
            txtGrade.Clear();
            txtName.Focus();
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();

            if (studentGrades.Count == 0)
            {
                lstOutput.Items.Add("No students to display.");
                return;
            }

            foreach (var student in studentGrades.OrderBy(s => s.Key))
            {
                lstOutput.Items.Add($"{student.Key}: {student.Value}");
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter a student name to search.", "Input Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (studentGrades.TryGetValue(name, out int grade))
            {
                lstOutput.Items.Clear();
                lstOutput.Items.Add($"Found: {name} - Grade: {grade}");
            }
            else
            {
                MessageBox.Show($"Student '{name}' not found.", "Search Result",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnAverage_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();

            if (studentGrades.Count == 0)
            {
                lstOutput.Items.Add("No students to calculate average.");
                return;
            }

            double average = studentGrades.Values.Average();
            lstOutput.Items.Add($"Average Grade: {average:F2}");
        }

        private void BtnHighLow_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();

            if (studentGrades.Count == 0)
            {
                lstOutput.Items.Add("No students to analyze.");
                return;
            }

            int max = studentGrades.Values.Max();
            int min = studentGrades.Values.Min();

            var topStudents = studentGrades
                .Where(s => s.Value == max)
                .Select(s => s.Key);

            var bottomStudents = studentGrades
                .Where(s => s.Value == min)
                .Select(s => s.Key);

            lstOutput.Items.Add($"Highest Grade: {max} ({string.Join(", ", topStudents)})");
            lstOutput.Items.Add($"Lowest Grade: {min} ({string.Join(", ", bottomStudents)})");
        }
    }
}