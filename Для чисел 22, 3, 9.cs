//Считываем данные с консоли
string? inputLine1 = Console.ReadLine();
string? inputLine2 = Console.ReadLine();
string? inputLine3 = Console.ReadLine();
//Проверяем, чтобы данные были не пустыми
if (inputLine1 != null && inputLine2 != null && inputLine3 != null)
{
//Вводим первое число
int number1 = 22;
//Вводим второе число
int number2 = 3;
//Вводим третье число
int number3 = 9;
//Ищем самое большое число
int outResult = number1;
if (number1 > number2 && number1 > number3)
{
outResult = number1;
}
if (number2 > number1 && number2 > number3)
{
outResult = number2;
}
if (number3 > number2 && number3 > number1)
{
outResult = number3;
}
// Выводим данные в консоль
Console.WriteLine("max = " + outResult);
}
