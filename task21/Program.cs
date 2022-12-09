// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] point = new int[6];  
System.Console.WriteLine("Введите координату Х1: ");
point[0] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y1: ");
point[1] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Z1: ");
point[2] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату X2: ");
point[3] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y2: ");
point[4] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Z2: ");
point[5] = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine( Math.Sqrt(Math.Pow(point[3] - point[0], 2) + Math.Pow(point[4] - point[1],2) + Math.Pow(point[5] - point[2],2)));