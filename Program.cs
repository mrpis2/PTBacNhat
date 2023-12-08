using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Nhap gia tri cua a: ");
        Double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhap gia tri cua b: ");
        Double b = Convert.ToDouble(Console.ReadLine());
        
        if (a!=0)
        {
            Console.WriteLine("Pt co nghiem la: " + -b/a);
        }
        else
        {
            if (b!=0)
            {
                Console.WriteLine("PT vo nghiem");
            }
            else
            {
                Console.WriteLine("PT vo so nghiem");
            }
        }
    }
}