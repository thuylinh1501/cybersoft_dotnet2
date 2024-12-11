internal class Program
{
    private static void Main(string[] args){
        Console.WriteLine("Hello, World!");
        StudentManager manager = new StudentManager();
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("\n=== Quản Lý Học Sinh ===");
            Console.WriteLine("1. Thêm học sinh");
            Console.WriteLine("2. Tìm học sinh theo tên");
            Console.WriteLine("3. Cập nhật điểm số học sinh");
            Console.WriteLine("4. Tính điểm trung bình và xếp loại");
            Console.WriteLine("5. Xóa học sinh");
            Console.WriteLine("6. Hiển thị danh sách học sinh");
            Console.WriteLine("7. Thoát chương trình");
            Console.Write("Chọn chức năng: ");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice){
                case 1:
                    manager.AddStudent();
                    break;
                case 2:
                    Console.Write("Nhập tên học sinh cần tìm: ");
                    string name = Console.ReadLine();
                    manager.SearchByName(name);
                    break;
                case 3:
                    Console.Write("Nhập mã học sinh cần cập nhật: ");
                    int id = int.Parse(Console.ReadLine());
                    manager.UpdateScores(id);
                    break;
                case 4:
                    manager.DisplayAllStudents();
                    break;
                case 5:
                    Console.Write("Nhập mã học sinh cần xóa: ");
                    int deleteId = int.Parse(Console.ReadLine());
                    manager.DeleteStudent(deleteId);
                    break;
                case 6:
                    manager.DisplayAllStudents();
                    break;
                case 7:
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    break;
            }
        }
    }
}