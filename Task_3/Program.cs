//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

int[] aCoordinate = new int[2];

System.Console.Write("Введите X первой точки: ");
aCoordinate[0] = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите Y первой точки: ");
aCoordinate[1] = Convert.ToInt32(Console.ReadLine());

int[] bCoordinate = new int[2];

System.Console.Write("Введите X второй точки: ");
bCoordinate[0] = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите Y второй точки: ");
bCoordinate[1] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow((bCoordinate[0] - aCoordinate[0]), 2) + Math.Pow((bCoordinate[1] - aCoordinate[1]),2)),3));