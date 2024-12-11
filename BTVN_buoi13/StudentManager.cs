using Newtonsoft.Json;
class StudentManager{
    private List<Student> students;
    private string filePath = "students.json";

    private void LoadData(){
        if (!File.Exists(filePath))
        {
            students = new List<Student>();
        }
        else
        {
            string json = File.ReadAllText(filePath);
            students = JsonConvert.DeserializeObject<List<Student>>(json);
        }
    }

    public StudentManager(){
        LoadData();
    }

    private void SaveData(){
        string json = JsonConvert.SerializeObject(students, Formatting.Indented);
        File.WriteAllText(filePath, json);
    }

    public void AddStudent(){
        Console.WriteLine("Nhập mã học sinh: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhập tên học sinh: ");
        string name = Console.ReadLine();
        Console.WriteLine("Nhập điểm Toán: ");
        double math = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("Nhập điểm Văn: ");
        double literature = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("Nhập điểm Anh: ");
        double english = Convert.ToInt64(Console.ReadLine());

        // Correcting constructor issue
        Student student = new Student { StudentId = id, Name = name, MathScore = math, LiteratureScore = literature, EnglishScore = english };
        students.Add(student);
        SaveData();
    }

    public void SearchByName(string name){
        Student student = students.Find(p => p.Name.Contains(name));
        if (student == null)
        {
            Console.WriteLine("Không tìm thấy học sinh.");
        }
        else
        {
            student.DisplayInfo();
        }
    }

    public void UpdateScores(int id){
        var student = students.FirstOrDefault(s => s.StudentId == id);
        if (student == null)
        {
            Console.WriteLine("Không tìm thấy học sinh.");
            return;
        }

        Console.WriteLine("Nhập điểm Toán mới: ");
        student.MathScore = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhập điểm Văn mới: ");
        student.LiteratureScore = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhập điểm Anh mới: ");
        student.EnglishScore = double.Parse(Console.ReadLine());

        SaveData();
    }

    public void DeleteStudent(int id){
        var student = students.FirstOrDefault(s => s.StudentId == id);
        if (student == null){
            Console.WriteLine("Không tìm thấy học sinh.");
            return;
        }

        students.Remove(student);
        SaveData();
    }

    public void DisplayAllStudents(){
        var sortedStudents = students.OrderByDescending(s => s.CalculateAverage()).ToList();
        foreach (var student in sortedStudents){
            student.DisplayInfo();
            Console.WriteLine("=================================");
        }
    }
}
