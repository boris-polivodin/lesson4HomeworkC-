/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
class Program {
    public static void Main (string[] args) {
        Console.Write("Введите целое число: ");
        int number = GetIntNumber();
        int summadigits = 0;

        while (number != 0)
        {
            summadigits += number % 10;
            number /= 10;
        }
  
        Console.WriteLine($"Сумма цифр равна {Math.Abs(summadigits)}");
     }

     static int GetIntNumber() {
        String stringNumber = Console.ReadLine() ?? "Значение Null";
        int number;
        bool isNumber = int.TryParse(stringNumber, out number);
        return number;
     }
}