// На вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
string? imputLine = Console.ReadLine();
if (imputLine != null)
{
int imputNumber = 5;
int startNumber = 2;
string lineOutput = ("");
while (startNumber <= imputNumber - 2)
{
lineOutput = lineOutput + startNumber + ", ";
startNumber += 2;
}
lineOutput = lineOutput + startNumber;
Console.WriteLine(lineOutput);
}
