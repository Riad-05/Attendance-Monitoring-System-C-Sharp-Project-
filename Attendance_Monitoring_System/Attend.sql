CREATE TABLE AttendDB
(
    Attendance_ID INT IDENTITY(1,1) PRIMARY KEY,

    Student_ID VARCHAR(50),
    Student_Name VARCHAR(100),

    Department VARCHAR(100),
    Class_Name VARCHAR(100),
    Section VARCHAR(50),

    Attendance_Date DATE,
    Attendance_Status VARCHAR(20)
);