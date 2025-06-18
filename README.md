# Student Grade Manager

## Overview

The Student Grade Manager is a Windows Forms application designed to help educators efficiently manage and analyze student grades. Built with **C#** and **.NET Framework**, this application provides an intuitive interface for tracking student performance with essential statistical insights.

---

## Features

- ✅ **Add/update student records** with names and grades
- 🔍 **Search for students** by name
- 📊 **View all students** sorted alphabetically
- 📈 **Calculate class average grade**
- 🏆 **Identify highest and lowest performing students**
- ⚠️ **Comprehensive error handling** for invalid inputs
- 💯 **Grade validation** (0-100 range)
- 📋 **Clean output display** with clear feedback

---

## Prerequisites

- Microsoft Visual Studio (**2022 recommended**)
- **.NET Framework 4.7.2** or higher

---

## Installation & Running Instructions

**1. Clone the repository:**
```bash
git clone https://github.com/yourusername/student-grade-manager.git
cd student-grade-manager
```

**2. Open in Visual Studio:**
- Double-click `StudentGradeManager.sln`

**3. Build the solution:**
- Press `Ctrl+Shift+B` or go to **Build → Build Solution**

**4. Run the application:**
- Press `F5` or click the **Start** button in Visual Studio

---

## Usage Guide

### Add a Student
- Enter name in the **"Name"** field
- Enter grade (0-100) in the **"Grade"** field
- Click **"Add Student"**

### View All Students
- Click **"Display All"** to see sorted list

### Search for a Student
- Enter name in the **"Name"** field
- Click **"Search"**

### Calculate Statistics
- Click **"Average"** for class average
- Click **"High/Low"** for highest/lowest grades

---

#### Example Workflow

1. **Add**: "Alice", 95 → `Added: Alice - Grade: 95`
2. **Add**: "Bob", 85 → `Added: Bob - Grade: 85`
3. **Display All** → `Alice: 95`, `Bob: 85`
4. **Search "Alice"** → `Found: Alice - Grade: 95`
5. **Average** → `Average Grade: 90.00`
6. **High/Low** → `Highest: 95 (Alice)`, `Lowest: 85 (Bob)`

---

## Technical Details

- **Data Structure:** `Dictionary<string, int>` for O(1) lookups

**Validation:**
- Name required
- Grade must be integer between 0-100

**Error Handling:**
- Empty name detection
- Invalid grade formats
- Non-existent student searches
- Empty dataset operations

**UI Controls:**
- TextBoxes for input
- Buttons for actions
- ListBox for output display
- Labels for clear field identification

---

## Code Structure

```
StudentGradeManager/
├── Form1.cs             - Main application logic
├── Form1.Designer.cs    - UI layout definition
├── Program.cs           - Application entry point
└── Properties/
    └── AssemblyInfo.cs  - Assembly metadata
```

---

## Troubleshooting

**If you encounter issues:**

**Build errors:**
- Clean solution (**Build → Clean Solution**)
- Delete `bin/obj` folders manually
- Restart Visual Studio

**Application not starting:**
- Ensure no other instances are running (check Task Manager)
- Verify .NET Framework version

**Buttons not responding:**
- Check event handler connections in `Form1.cs` constructor
- Ensure controls have correct names in designer

---

## Video Demonstration

Watch the application demo showing:
Link to video : https://youtu.be/iqLWYA3kT9s

- Adding and updating student records
- Displaying all students alphabetically
- Searching for students
- Calculating average grade
- Identifying highest/lowest performers

**Handling error scenarios:**
- Empty name submission
- Invalid grade entries
- Searching non-existent students
- Performing operations with empty dataset

---

## Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository
2. Create a new branch:  
   ```bash
   git checkout -b feature/your-feature
   ```
3. Commit your changes:  
   ```bash
   git commit -m 'Add some feature'
   ```
4. Push to the branch:  
   ```bash
   git push origin feature/your-feature
   ```
5. Open a pull request

---
