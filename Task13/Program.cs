// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

Console.WriteLine($"Введите число ");
int number = int.Parse(Console.ReadLine());



if(number < 100) 
    {
    Console.WriteLine("Третей цифры нет ");
    }
    else
        {while(number > 1000)
            {
                number = number / 10;  
            }

                int result = number % 10;
                Console.WriteLine($"Третья цифра, {result}");
        }    
        

     