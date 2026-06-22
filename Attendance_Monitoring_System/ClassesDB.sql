CREATE TABLE ClassesDB(
    Class_ID INT IDENTITY(1,1) PRIMARY KEY,
    Department VARCHAR(100) NOT NULL,
    Subject_Name VARCHAR(100) NOT NULL,
    Section VARCHAR(100) NOT NULL,
    Total_Student INT NOT NULL
);