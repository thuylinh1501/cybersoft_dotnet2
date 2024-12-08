internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        NhanVien nguyenVanA = new TruongPhong("NV01", "Nguyễn Văn A", 1000, 1.5);
        Console.WriteLine($"Lương của Nguyễn Văn A: {nguyenVanA.tinhLuong()}");

        //Animal
        Animal dog = new Animal("Dog");
        dog.eat();
        dog.sleep();
        #region Quản lý khách sạn
        // Bài tập về quản lý khách sạn
        // abstract class: Room
        // - roomId: string
        // - roomName: string
        // - basePrice: double

        // Class con
        // - NomalRoom: Room
        // - LuxuryRoom: Room
        //      + extraService: string
        // - SuitedRoom: Room
        //      + extraService: string
        //      + premiumService: string

        // class Hotel

        Room normalRoom = new NormalRoom("01", "Normal Room 01", 40000);
        Room luxuryRoom =  new LuxuryRoom("02", "Luxury Room 01", 40000, "Free breakfast");
        Room suiteRoom =  new SuiteRoom("03", "Suite Room 01", 40000, "Free breakfast", "Free massage");

        Console.WriteLine($"Price of nornal room: {normalRoom.calculatePrice()}");
        Console.WriteLine($"Price of luxury room: {luxuryRoom.calculatePrice()}");
        Console.WriteLine($"Price of suite room: {suiteRoom.calculatePrice()}");
        #endregion
    }
}