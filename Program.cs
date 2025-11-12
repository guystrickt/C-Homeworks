Console.WriteLine("введите первое число:");
string firstInput = Console.ReadLine();










Console.Write("Введите операцию (+, -, *, /): ");
string operation = Console.ReadLine();
double result;
switch (operation)
{
    case "+":
        result = num1 + num2;
        Console.WriteLine($"Результат: {num1} + {num2} = {result}");
        break;
    case "-":
        result = num1 - num2;
        Console.WriteLine($"Результат: {num1} - {num2} = {result}");
        break;
    case "*":
        result = num1 * num2;
        Console.WriteLine($"Результат: {num1} * {num2} = {result}");
        break;
    case "/":
        if (num2 == 0)
        {
            Console.WriteLine("Ошибка: деление на ноль невозможно!");
            break;
        }
        result = num1 / num2;
        Console.WriteLine($"Результат: {num1} / {num2} = {result}");
        break;
    default:
        Console.WriteLine("Ошибка: неверная операция!");
        break;
}
























































































