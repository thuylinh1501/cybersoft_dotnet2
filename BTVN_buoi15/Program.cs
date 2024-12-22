using Newtonsoft.Json;
internal class Program
{
     private static List<string> transactionHistory = new List<string>();

    private static void Main(string[] args){
        while (true){
            Console.WriteLine("\n--- Menu ---");
            Console.WriteLine("1. Thanh toán bằng tiền mặt");
            Console.WriteLine("2. Thanh toán bằng thẻ");
            Console.WriteLine("3. Thanh toán online");
            Console.WriteLine("4. Xem lịch sử giao dịch");
            Console.WriteLine("5. Thoát");
            Console.Write("Chọn chức năng: ");

            int choice = Convert.ToInt32(Console.ReadLine());
            ThanhToan thanhToan = null;

            switch (choice){
                case 1:
                    thanhToan = new ThanhToanTienMat();
                    break;
                case 2:
                    thanhToan = new ThanhToanBangThe();
                    break;
                case 3:
                    thanhToan = new ThanhToanOnline();
                    break;
                case 4:
                    Console.WriteLine("\n--- Lịch sử giao dịch ---");
                    foreach (var transaction in transactionHistory)
                    {
                        Console.WriteLine(transaction);
                    }
                    continue;
                case 5:
                    SaveTransactionHistory();
                    Console.WriteLine("Thoát chương trình.");
                    return;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                    continue;
            }

            Console.Write("Nhập số tiền cần thanh toán: ");
            double soTien = Convert.ToDouble(Console.ReadLine());
            try{
                thanhToan.ThanhToanMethod(soTien);
                transactionHistory.Add($"Phương thức: {thanhToan.GetType().Name}, Số tiền: {soTien} VND, Kết quả: Thành công");
            }
            catch (Exception ex){
                transactionHistory.Add($"Phương thức: {thanhToan.GetType().Name}, Số tiền: {soTien} VND, Kết quả: Thất bại ({ex.Message})");
                Console.WriteLine(ex.Message);
            }
        }
    }

    // Hàm lưu lịch sử giao dịch vào file JSON
    private static void SaveTransactionHistory(){
        string json = JsonConvert.SerializeObject(transactionHistory, Formatting.Indented);
        File.WriteAllText("bai1.json", json);
        Console.WriteLine("Lịch sử giao dịch đã được lưu.");
    }
}