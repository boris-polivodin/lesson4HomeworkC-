/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
class Program {
    public static void Main (string[] args) {
        Console.Write("Введите первое число: ");
        double firstNumber = GetDoubleNumber();
        Console.Write("Введите второе число: ");
        int secondNumber = GetIntNumber();
        if (CheckNumber(secondNumber)) {
            double result = 1;
            for (int i = 1; i <= secondNumber; i++) {
                result *= firstNumber;
            }
            Console.WriteLine($"Степень числа {firstNumber} с натуральным показателем {secondNumber} равна {result}");
        }
        else {
            Console.WriteLine("Второе число должно быть натуральным, т.е. положительным");
        }
     }

     static int GetIntNumber() {
        String stringNumber = Console.ReadLine() ?? "Значение Null";
        int number;
        bool isNumber = int.TryParse(stringNumber, out number);
        return number;
     }

     static double GetDoubleNumber() {
        String stringNumber = Console.ReadLine() ?? "Значение Null";
        double number;
        bool isNumber = Double.TryParse(stringNumber, out number);
        return number;
     }

     static bool CheckNumber(int number) {
        return number > 0;
     }
}
