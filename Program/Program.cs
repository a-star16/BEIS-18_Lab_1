using System;

namespace Program
{
    class Program
    {
static void Main (string[] args)  // - началоописанияфункции.
                               //изменяем заголовок окна консоли:
    {
        Console.Title = "Пример использования инструментов класса Console";
        //изменяемцветфона:  
        Console.BackgroundColor = ConsoleColor.Black;
        //изменяемцветтекста% 
        Console.ForegroundColor = ConsoleColor.White;
        Console.Clear();// - очисткаокна
        Console.Write(" Привет, студент! \n\n ");// \n - перевод строки 
    }                                // конец описания функции
}
}

