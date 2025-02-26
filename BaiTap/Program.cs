using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        //Buoi 1
        Bai1();
        Bai3();
        Bai9();
    }
    static void Bai1()
    {
        double so1, so2, so3;

        Console.WriteLine("Tim so lon nhat trong 3 so:");

        Console.WriteLine("Nhap so thu nhat: ");
        while (!double.TryParse(Console.ReadLine(), out so1))
        {
            Console.WriteLine("Vui long nhap mot so hop le! Nhap lai: ");
        }

        Console.WriteLine("Nhap so thu hai: ");
        while (!double.TryParse(Console.ReadLine(), out so2))
        {
            Console.WriteLine("Vui long nhap mot so hop le! Nhap lai: ");
        }

        Console.WriteLine("Nhap so thu ba: ");
        while (!double.TryParse(Console.ReadLine(), out so3))
        {
            Console.WriteLine("Vui long nhap mot so hop le! Nhap lai: ");
        }

        double max = Math.Max(Math.Max(so1, so2), so3);
        Console.WriteLine("So lon nhat trong 3 so la: " + max);

    }

    static void Bai3()
    {
        double a, x, b;

        Console.WriteLine("Giai phuong trinh bac nhat ax+b=0");

        Console.WriteLine("Nhap a (a khac khong): ");
        while (!double.TryParse(Console.ReadLine(), out a) || (a == 0))
        {
            Console.WriteLine("Vui long nhap mot so hop le! Nhap lai: ");
        }

        Console.WriteLine("Nhap x: ");
        while (!double.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine("Vui long nhap mot so hop le! Nhap lai: ");
        }

        Console.WriteLine("Nhap b: ");
        while (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("Vui long nhap mot so hop le! Nhap lai: ");
        }

        x = -b / a;

        Console.WriteLine("Nghiem cua phuong trinh " + a + "x + " + b + " = 0 la: " + x);
    }

    static void Bai9()
    {
        Console.WriteLine("Tinh tong cac phan tu trong mang");

        Console.WriteLine("Nhap so luong phan tu trong mang: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("So luong phan tu phai la so nguyen duong!");
            return; 
        }

        double[] arr = new double[n];
        double sum = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhap phan tu thu {i + 1}: ");
            while (!double.TryParse(Console.ReadLine(), out arr[i]))
            {
                Console.WriteLine("Vui long nhap mot so hop le! Nhap lai: ");
            }
            sum += arr[i];
        }

        Console.WriteLine($"Tong cac phan tu trong mang la: {sum}");
        Console.ReadLine();
    }
}