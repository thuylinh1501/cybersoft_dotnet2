﻿using Newtonsoft.Json;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");  
        Animal dog = new Dog("Lulu", "Husky");
        dog.Speak(); // Lấy hàm Speak của class dog
        dog.displayInfo();
        // Dùng class animal để đại diện cho các class con
        List<Animal> animals = new List<Animal>();
        // tạo đối tượng Dog
        Dog dog1 = new Dog("Hehe", "Bulldog");
        // add dog1 vào list animal
        animals.Add(dog1);
        // tạo đối tượng cat
        Cat cat =  new Cat("Meo", "White");
        animals.Add(cat);
        // In ra list animal
        foreach(var animal in animals){
            animal.Speak();
            animal.displayInfo();
            Console.WriteLine("--------------------------");
        }

        // Lưu list animals vào file json
        // Lưu thêm file của object vào file json
        // Dùng Newtonsoft để lưu type object vào file josn
        string json = JsonConvert.SerializeObject(animals, new JsonSerializerSettings {
            TypeNameHandling = TypeNameHandling.All,
            Formatting = Formatting.Indented
        });
        File.WriteAllText("animals.json", json);
        Console.WriteLine("Lưu file thành công!");
        // thread
        // Đọc file json
        string jsonFromFile = File.ReadAllText("animals.json");
        List<Animal>? animals1 = JsonConvert.DeserializeObject<List<Animal>>(jsonFromFile, new JsonSerializerSettings {
            TypeNameHandling = TypeNameHandling.All
        });
        Console.WriteLine("Đọc file trước khi update!");
        // Root cause:
        // Lỗi vì khi load file lên thì các object trong list animals1
        // không phải là Dog hoặc Cat, mà là Animal

        // Solution
        // Để fix lỗi này, ta cần lưu type của object vào file json
        // để khi load file lên ta biết được oject nào là Dog, object nào là Cat
        // Thư viện Newtonsoft.Json sẽ giúp mình làm việc này
        foreach(var animal in animals1) {
            animal.Speak();
            animal.displayInfo();
            Console.WriteLine("========");
        }
    }
}