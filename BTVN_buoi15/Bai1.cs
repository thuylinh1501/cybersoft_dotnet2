interface IThanhToan
{
    void ThanhToanMethod(double soTien);
}

abstract class ThanhToan : IThanhToan
{
    public abstract void ThanhToanMethod(double soTien);
}

class ThanhToanTienMat : ThanhToan{
    public override void ThanhToanMethod(double soTien){
        Console.WriteLine($"Thanh toán {soTien} VND bằng tiền mặt thành công!");
    }
}

class ThanhToanBangThe : ThanhToan{
    private const int PIN = 9999;
    public override void ThanhToanMethod(double soTien){
        Console.Write("Nhập mã PIN để xác nhận giao dịch: ");
        int userPin = Convert.ToInt32(Console.ReadLine());
        if (userPin == PIN){
            Console.WriteLine($"Thanh toán {soTien} VND bằng thẻ thành công!");
        }
        else{
            Console.WriteLine("Mã PIN không đúng. Giao dịch thất bại.");
        }
    }
}

class ThanhToanOnline : ThanhToan{
    private const int OTP = 1234;
    public override void ThanhToanMethod(double soTien){
        Console.Write("Nhập mã OTP được gửi tới điện thoại của bạn: ");
        int userOtp = Convert.ToInt32(Console.ReadLine());
        if (userOtp == OTP){
            Console.WriteLine($"Thanh toán {soTien} VND qua mạng thành công!");
        }else{
            Console.WriteLine("Mã OTP không đúng. Giao dịch thất bại.");
        }
    }
}
