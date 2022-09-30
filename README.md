# SchoolManagementSystem

This is a mini school management system, built on C#, Windows Forms and SQL server, that includes modules for managing teachers, students, grades and finances. There are three roles with specific permissions defined below:

## Admin
- can create new teacher, student and parent accounts
- create new classes
- assign a teacher to class
- add students to class
- link parents to students
- create timetables for classes
- manage fees

## Teachers
- can mark attendance for specific classes
- can mark student grades

## Parents

- can view attendance of childre
- can view grades of children
- can view payables

## Execution guidelines:

- Execute SQL scripts from 1SchoolManagementSystem.Database project` in your SQL server
- Replace your server connection string at [change Connection string here](https://github.com/iusamaaziz/SchoolManagementSystem/blob/378cc40d07d398d833c8e762002d4b5f0b0614c5/SchoolManagementSystem/App.config#L7)
- Run in Visual Studio
