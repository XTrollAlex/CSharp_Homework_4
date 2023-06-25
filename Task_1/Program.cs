// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.Write("Введите числа A и B через запятую: ");
double[] number = Array.ConvertAll(Console.ReadLine()!.Split(","), double.Parse);

double BGrade(double A, double B)
{
    double grade = Math.Pow(A, B);
    return grade;
}

double bGrade = BGrade(number[0], number[1]);

System.Console.WriteLine($"A (число {number[0]}) в степени B (число {number[1]}) = " + bGrade);