class Student{
    public string studentID;
    public string studentName;
    public int age;
    public Student(string studentID, string studentName, int age){
        this.studentID = studentID;
        this.studentName = studentName;
        this.age = age;
    }

    // Phương thức hiển thị thông tin sinh viên
    public void displayInfo(){
        Console.WriteLine($"ID: {studentID}, Name: {studentName}, Age: {age}");
    }
}