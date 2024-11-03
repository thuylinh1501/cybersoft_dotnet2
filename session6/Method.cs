using System.Reflection.Metadata.Ecma335;

class Method{
    /// <summary>
    /// Hàm kiểm tra số nguyên tố
    /// </summary>
    /// <param name="number">number có kiểu là số nguyên dương</param>
    /// <returns>true: số nguyên tố, false: không là số nguyên tố</returns>
    public static bool checkPrime(int number){
        if (number < 2){
            return false;
        }

        for(int i = 2; i <= Math.Sqrt(number); i++){
            if(number % i == 0){
                return false;
            }
        }
        return true;
    }

    // In tam giác vuông
    public static void printSquareTriangle(int height){
        for(int i = 1; i <= height; i++){
            for(int j = 1; j <= i; j++){
                Console.Write("* ");
            }
            Console.WriteLine("");
        }
    }
}