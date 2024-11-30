using System;

class Program
{
    // تعريف multicast delegate داخل نفس الكلاس
    public delegate void RectangleDelegate(Rectangle rectangle);

    static void Main(string[] args)
    {
        // تعريف مستطيل مع الطول والعرض
        var rect = new Rectangle { Length = 10, Width = 5 };

        // إنشاء multicast delegate وإضافة دالتين له
        RectangleDelegate rectangleDelegate = new RectangleDelegate(rect.CalculateArea);
        rectangleDelegate += rect.CalculatePerimeter;  // إضافة دالة ثانية

        // استدعاء الـ delegate لتنفيذ الدوال المرتبطة به
        rectangleDelegate(rect);

        Console.ReadKey();
    }
}

public class Rectangle
{
    public double Length { get; set; }
    public double Width { get; set; }

    // دالة لحساب المساحة
    public void CalculateArea(Rectangle rect)
    {
        double area = rect.Length * rect.Width;
        Console.WriteLine($"Area: {area} square units");
    }

    // دالة لحساب المحيط
    public void CalculatePerimeter(Rectangle rect)
    {
        double perimeter = 2 * (rect.Length + rect.Width);
        Console.WriteLine($"Perimeter: {perimeter} units");
    }
}
