using Newtonsoft.Json;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        #region Bài 1: Quản lý sinh viên
        // B1: Quản lý lớp học
        // 1. Lớp học:
        // tạo lớp classroom để tạo lớp học
        // classID: mã lớp học
        // className: tên lớp học
        // danh sách sinh viên trong lớp
        // 2. Sinh viên:
        // studentID: mã sinh viên
        // studentNam: tên sinh viên
        // age: tuổi
        // 3. Yêu cầu chức năng:
        // - Thêm sinh viên vào Lớp
        // - Hiển thị ds sinh viên trong Lớp
        // - Tìm sinh viên theo mã sinh viên


        // Tạo lớp học
        Classroom classroom = new Classroom("C02", "DotNet02");
        // Tạo menu quản lý sinh viên
        // 1. Thêm 1 sinh viên
        // 2. Hiển thị danh sách sinh viên
        // 3. Tìm kiếm sinh viên theo mã sinh viên
        // 4. Thoát
        while (true)
        {
            Console.WriteLine("\n------Classroom Management------");
            Console.WriteLine("1. Add student");
            Console.WriteLine("2. Show students");
            Console.WriteLine("3. Find student by studen ID");
            Console.WriteLine("4. Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    // thêm sinh viên
                    Console.WriteLine("Enter student ID: ");
                    string studentID = Console.ReadLine();
                    Console.WriteLine("Enter student name: ");
                    string studentName = Console.ReadLine();
                    Console.WriteLine("Enter student age: ");
                    int age = Convert.ToInt32(Console.ReadLine());

                    Student student = new Student(studentID, studentName, age);
                    // thêm sinh viên vào lớp
                    classroom.addStudent(student);

                    // Lưu danh sách nhân viên vào json
                    // chuyển ds sinh viên thành json: 
                    var json = JsonConvert.SerializeObject(classroom.students, Formatting.Indented);
                    // Lưu json vào file
                    File.WriteAllText("students.json", json);
                    Console.WriteLine("Add student successfully!");
                    break; // phải break nếu không nhảy qua case 2
                case 2:
                    // Hiển thị danh sách sinh viên
                    // đọc ds sinh viên từ file json
                    var studentsJson = File.ReadAllText("students.json");
                    // chuyển json thành danh sách sinh viên
                    classroom.students = JsonConvert.DeserializeObject<List<Student>>(studentsJson);

                    classroom.showStudent();
                    break;
                case 3:
                    // Tìm sinh viên
                    Console.WriteLine("Enter student ID to find: ");
                    string id = Console.ReadLine();
                    if (id == null)
                    {
                        Console.WriteLine("Student ID is required");
                    }
                    classroom.findStudentByStudentID(id);
                    break;
                case 4:
                    // Thoát
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter 1 - 4");
                    break;
            }
        }
        #endregion
    }
}