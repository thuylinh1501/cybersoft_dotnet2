class Person
{
    private string name;
    private int age;
    // dùng property để truy cập vào từng thuộc tính
    public string Name
    {
        get { return name; }
        set
        {
            // thêm các logic kiểm tra giá trị trước khi gán cho thuộc tính
            // check tên không được rỗng
            // hoặc check tên có độ dài tối thiểu là 2 ký tự
            if (string.IsNullOrWhiteSpace(value) || value.Length < 2)
            {
                throw new ArgumentException("Tên không hợp lệ");
            }
            name = value;
        }
    }

    // Tương tự với thuộc tính age
    public int Age
    {
        get { return age; }
        set
        {
            // Kiểm tra giá trị trước khi gán
            if (value < 0 || value > 150)
            {
                throw new ArgumentException("Tuổi không hợp lệ! Tuổi phải nằm trong khoảng từ 0 đến 150.");
            }
            age = value;
        }
    }
    // Khi define constructor mới, constructor mặc định sẽ không sinh
    public Person (string name, int age){
        // Gán giá trị cho thuộc tính thông qua setter (quan trọng)
        Name = name;
        Age = age;
    }
    public Person (){}
    // LƯU Ý: Nếu đã có constructor khác cần khai báo constructor mặc định (không tham số)
}