class Student{
    private int studentId;
    public int StudentId{
        get { return studentId; }
        set { studentId = value; }
    }
    private string name;
    public string Name{
        get { return name; }
        set { name = value; }
    }

    private double mathScore;
    public double MathScore{
        get { return mathScore; }
        set { mathScore = value; }
    }
    private double literatureScore;
    public double LiteratureScore{
        get { return literatureScore; }
        set { literatureScore = value; }
    }

    private double englishScore;
    public double EnglishScore{
        get { return englishScore; }
        set { englishScore = value; }
    }

    public double CalculateAverage(){
        return (MathScore + LiteratureScore + EnglishScore) / 3;
    }

    public string GetClassification(){
        double average = CalculateAverage();
        if (average < 5) return "Yếu";
        if (average < 6.5) return "Trung bình";
        if (average < 8) return "Khá";
        return "Giỏi";
    }

    public void DisplayInfo(){
        Console.WriteLine($"Mã HS: {StudentId}");
        Console.WriteLine($"Tên: {Name}");
        Console.WriteLine($"Toán: {MathScore}");
        Console.WriteLine($"Văn: {LiteratureScore}");
        Console.WriteLine($"Anh: {EnglishScore}");
        Console.WriteLine($"ĐTB: {CalculateAverage()}");
        Console.WriteLine($"Xếp loại: {GetClassification()}");
    }
}