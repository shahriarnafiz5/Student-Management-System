# Student Management System

## Overview

Every educational institute, training center, and coaching academy runs on the same daily grind: a stack of paper admission forms, a register book for attendance and marks, and a filing cabinet of course brochures that someone has to update by hand every time a new batch starts. When a parent calls to ask about their child's exam result, front-desk staff has to physically dig through folders. When a student wants to check their own marks, they have to visit the office in person and wait in line. When the institute wants to launch a new batch of an existing course, someone re-types the same information into a new register.

This is slow, error-prone, and gives no one — not the owner, not the staff, not the students — a real-time picture of what is happening across the institute. The **Student Management System** exists to replace this paper-and-memory workflow with a single, structured, always-available digital record that every stakeholder can trust.

## Actors

Three actors use the system, each with a different stake in it.

- **Super Admin** — the institute owner or top-level controller. Cares about oversight and trust: creates and manages Admin accounts, activates or deactivates staff who join or leave, and retains the ability to do everything an ordinary Admin can do.
- **Admin** — the day-to-day operator (front-desk officer or academic coordinator). Cares about speed and accuracy: registering new students as they walk in, opening new courses, recording exam scores as answer sheets are graded, and printing documents for parents or auditors on demand.
- **Student** — the end customer of the system. Cares about visibility and control over their own record: logging in to see their profile and enrolled courses, updating contact details, checking scores the moment they're published, and printing their own result without asking anyone.

## Data Model

The system is built from five entities:

| Entity | Identified by | Key attributes |
|---|---|---|
| **Admin** *(also represents Super Admin, via role flag)* | Unique ID | First name, last name, username, password, phone, email, address, active/inactive status, role |
| **Student** | Unique ID | First name, last name, username, password, phone, date of birth, address, gender, photo |
| **Course** | Unique ID | Course name, duration, total hour count |
| **Enrollment** | Unique ID | Links a Student to a Course on a specific date |
| **Score** | Unique ID | Marks a Student earned in a Course |

### Relationships

- One Admin registers many Students, adds many Courses, processes many Enrollments, and enters many Scores. A Super Admin, as a special kind of Admin, can also create other Admin accounts.
- One Student can enroll in many Courses, and one Course can have many Students — the **Enrollment** entity resolves this many-to-many relationship into two clean one-to-many links.
- One Student can receive many Scores (one per course), and one Course can have many Scores (one per student) — the **Score** entity resolves this relationship and guarantees exactly one score per student per course.

Unlike a marketplace or booking platform, no money changes hands inside this system — there is no cart, payment gateway, or commission to route. The value that flows through the system is administrative time and trust: every registration, enrollment, and score entry saved here is time the institute doesn't spend on paper. A future version adding tuition fees or online payments would extend this same model with a Payments/Invoices table linked to Students and Courses, following the same one-to-many pattern.

## Functional Requirements

**Welcome Page / Authentication**
1. Present three login options: Admin, Super Admin, and Student.
2. Authenticate a user against the correct table (Admins or Students) based on the selected login type.
3. Redirect an authenticated user to the appropriate dashboard based on their role.
4. Reject login for an Admin account whose status is inactive.

**Admin / Super Admin — Student Management**
5. Register a new student with personal, contact, and photo details.
6. View a list of all registered students.
7. Search students by name, username, or phone number.
8. Update an existing student's information.
9. Delete a student record.
10. View and print a single student's information or the full student list.
11. Enroll a student into one or more courses.
12. Prevent duplicate enrollment of the same student into the same course.

**Admin / Super Admin — Course Management**
13. Add a new course with name, duration, and hour count.
14. View, search, update, and delete course records.
15. View and print course information.

**Admin / Super Admin — Score Management**
16. Enter a score for a student in a specific course.
17. Prevent more than one score record per student per course.
18. View, search, update, and delete score records.
19. Print a student's course-wise result.

**Super Admin — Admin Management**
20. Add a new Admin account.
21. View, search, and update Admin information.
22. Activate or deactivate an Admin account.
23. Delete an Admin account.
24. View and print Admin information.
25. Restrict the Admin Management section so only a Super Admin can access it.

**Student Dashboard**
26. View own profile.
27. Update own contact details and password.
28. View own scores by course.
29. Print own profile and result.
30. Prevent viewing or editing another student's record.

## User Stories

### Welcome Page / Login

**As a Student**, I can log in using my username and password, so that I can access my own dashboard without staff assistance.
The login form checks credentials against the Students table. On failure, a red error label appears below the form and the fields are cleared. On success, a session is created for that StudentId and the user is redirected to the Student Dashboard.

**As an Admin**, I can log in and be recognized by my role, so that I only see the features I'm permitted to use.
The form checks the entered credentials against the Admins table and also checks that Status equals "active." An inactive account sees "This account has been deactivated — contact the Super Admin." On success, the Role (admin or super_admin) is stored in the session and used to show or hide the Admin Management menu.

### Student Management

**Student Registration** — An Admin fills a form with first name, last name, username, password, phone number, date of birth, address, gender, and a photo upload. Username must be unique. On Save, a new row is inserted into Students with `RegisteredBy` set to the logged-in admin's AdminId.

**Manage Student** — A searchable table (filters by name, username, or phone) with Edit and Delete actions per row. Delete cascades to the student's enrollments and scores, and requires confirmation.

**Print Student** — A read-only, formatted view of a student's profile that opens the system print dialog. No database write occurs.

**Enroll To Course** — From a student's detail view, pick a course and add it. The system checks for an existing Enrollment for that Student/Course pair before inserting.

### Course Management

**Add Course** — Form for course name, duration, and total hours. Name cannot be empty, hours must be a positive integer.

**Manage Course** — Searchable list with Edit and Delete. Deleting a course cascades to its enrollments and scores.

**Print Course** — Read-only formatted list or single-course detail, sent to the print dialog.

### Score Management

**New Score** — Dropdowns for Student and Course plus a numeric Marks field. Checks for an existing score for that pair before inserting.

**Manage Score** — Searchable, joined list (student name + course name) with inline Marks editing and Delete.

**Print Score** — A formatted result sheet listing every course a student is enrolled in alongside their marks.

### Admin Management (Super Admin only)

**Add Admin** — Form for name, username, password, phone, email, address, and status (default active). Username and email must be unique.

**Manage/Update Admin** — Searchable list with Edit, Activate/Deactivate toggle, and Delete. Deleting an admin nulls their `CreatedBy` references on other records rather than deleting those records.

**Print Admin** — A formatted list of all admins with contact details and status.

### Student Dashboard

**See Profile** — Read-only card of the logged-in student's own data.

**Update Profile** — Editable phone number, address, and photo, plus a Change Password section requiring the old password and a new password entered twice. Name and date of birth are locked.

**Watch Score** — A read-only table of the student's own scores, joined with course names.

**Print** — Combines profile and full score list into one formatted, print-ready page, always scoped to the logged-in student.
