using Newtonsoft.Json;
class VehicleManager{
    private List<Vehicle> vehicles;
    public List<Vehicle> Vehicles{
        get{return vehicles;}
        set{vehicles = value;}
    }

    private string filePath = "vehicles.json";
    // Viết hàm loadData để đọc dữ liệu từ file json
    // => dùng thư viện Newtonsoft.Json
    private void loadData() { // dùng trong constructor
        // kiểm tra file có tồn tại không
        if (File.Exists(filePath)) {
            // đọc dữ liệu từ file json
            string json = File.ReadAllText(filePath);

            // chuyển dữ liệu từ string json sang List<Vehicle>
            Vehicles = JsonConvert.DeserializeObject<List<Vehicle>>(json); 
        }else {
            Vehicles = new List<Vehicle>();
        }
    }
    // constructor
    public VehicleManager(){
        loadData();
    }

    // viết hàm saveData để lưu dữ liệu vào file json
    private void saveData(){ // dùng trong hàm addVehicle và removeVehicle
        // chuyển dữ liệu từ List<Vehicle> sang string json
        string json = JsonConvert.SerializeObject(Vehicles, Formatting.Indented);

        // lưu dữ liệu vào file json
        File.WriteAllText(filePath, json);
    }
    // viết hàm addVehicle để thêm phương tiện vào danh sách
    public void addVehicle(Vehicle vehicle){
        Vehicle vehi = Vehicles.Find(v => v.VehicleId == vehicle.VehicleId);
        if(vehi != null){
            throw new AggregateException("Mã phương tiện đã tồn tại!");
        } 
        Vehicles.Add(vehicle);
        saveData();
        Console.WriteLine("Thêm phương tiện thành công");
    }

    // viết hàm addCar để thêm xe vào danh sách
    public void addCar() {
        Console.WriteLine("Nhập mã phương tiện: ");
        string vehicleId = Console.ReadLine();

        Console.WriteLine("Nhập hãng: ");
        string brand = Console.ReadLine();

        Console.WriteLine("Nhập năm sản xuất: ");
        int year = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Nhập giá: ");
        double price = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Nhập dòng xe: ");
        string model = Console.ReadLine();

        Console.WriteLine("Nhập màu xe: ");
        string color = Console.ReadLine();

        Console.WriteLine("Dung tích động cơ: ");
        int engine = Convert.ToInt32(Console.ReadLine());

        Car car = new Car(vehicleId, brand, year, price, model, color, engine);
        addVehicle(car);
    }
    // Viết hàm displayAllVehicle để hiển thị danh sách phương tiện
    public void displayAllVehicle(){
        Console.WriteLine("\n===Danh sách phương tiện===");
        foreach(Vehicle vehicle in vehicles){
            vehicle.displayInfo();
            Console.WriteLine("------------------------------");
        }
    }
}