// See https://aka.ms/new-console-template for more information


 
    {
 
        int num1, num2, num3;
 
        Console.WriteLine("2,3,7");
 
        num1 = 2;
        num2 = 3;
        num3 = 7;
      
        if (num1 < num2)
 
        {
 
            Console.WriteLine("2");
 
        }
 
        else
 
        {
 
            Console.WriteLine("3");
 
        }
   
    if (num2 > num1)
 {
 
            Console.WriteLine("3");
 
        }
else
 
        {
 
            Console.WriteLine("2");
 
        }
    if (num3>num2)
{
 Console.WriteLine("{0} наибольшее число ", num3);
}

else

{
     Console.WriteLine("{0} наибольшее число ", num2);
}


 Console.ReadLine();
    }
