Console.WriteLine("---Калькулятор Индекса Массы Тела(ИМТ)---");
Console.WriteLine("Введите ваш вес в кг:");
string firstInput = Console.ReadLine();
double firstNumber = Convert.ToDouble(firstInput);
Console.WriteLine("Введите ваш рост в метрах (например 1.75)");
string secondInput = Console.ReadLine();
    double secondNumber = Convert.ToDouble(secondInput);
double quotient = firstNumber / (secondNumber * secondNumber);
Console.WriteLine("---Ваш результат---");
Console.WriteLine($"{firstNumber} / ({secondNumber} * {secondNumber}) = {quotient}");
Console.ReadLine();






































