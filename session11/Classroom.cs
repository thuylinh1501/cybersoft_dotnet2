class Classroom{
    public string classID;
    public string className;
    public List<Student> students;
    public Classroom(string classID, string className){
        this.classID = classID;
        this.className = className;
        this.students = new List<Student>();
    }

    // Phương thức thêm sinh viên vào lớp
    public void addStudent(Student student){
        students.Add(student);
        Console.WriteLine($"Student: {student.studentName} add to class {className}");
    }

    // Phương thức hiển thị danh sách sinh viên trong lớp
    public void showStudent(){;
        Console.WriteLine($"\n-----Students in class {className}-----");
        foreach(Student student in students){
            student.displayInfo();
        }
    }

    // Phương thức tìm kiếm sinh viên theo mã sinh viên
    public void findStudentByStudentID(string studentID){;
        // C1: Dùng vòng lặp
        foreach(Student student in students){
            if(student.studentID == studentID){
                student.displayInfo();
                return;
            }
        }
        Console.WriteLine($"Student with ID: {studentID} not found in class {className}");
    }
}