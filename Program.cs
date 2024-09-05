using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Input from numpad except equal to
namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number1 = "";
            string number2 = "";
            char _operator = ' ';
            bool _number1 = true;

            while (true)
            {
                ConsoleKey consoleKey = Console.ReadKey().Key;
                switch (consoleKey)
                {
                    case ConsoleKey.D0:
                        if (_number1)
                        {
                            number1 = number1 + "0";
                        }
                        else
                        {
                            number2 = number2 + "0";
                        }
                        break;
                    case ConsoleKey.D1:
                        if (_number1)
                        {
                            number1 = number1 + "1";
                        }
                        else
                        {
                            number2 = number2 + "1";
                        }
                        break;
                    case ConsoleKey.D2:
                        if (_number1)
                        {
                            number1 = number1 + "2";
                        }
                        else
                        {
                            number2 = number2 + "2";
                        }
                        break;
                    case ConsoleKey.D3:
                        if (_number1)
                        {
                            number1 = number1 + "3";
                        }
                        else
                        {
                            number2 = number2 + "3";
                        }
                        break;
                    case ConsoleKey.D4:
                        if (_number1)
                        {
                            number1 = number1 + "4";
                        }
                        else
                        {
                            number2 = number2 + "4";
                        }
                        break;
                    case ConsoleKey.D5:
                        if (_number1)
                        {
                            number1 = number1 + "5";
                        }
                        else
                        {
                            number2 = number2 + "5";
                        }
                        break;
                    case ConsoleKey.D6:
                        if (_number1)
                        {
                            number1 = number1 + "6";
                        }
                        else
                        {
                            number2 = number2 + "6";
                        }
                        break;
                    case ConsoleKey.D7:
                        if (_number1)
                        {
                            number1 = number1 + "7";
                        }
                        else
                        {
                            number2 = number2 + "7";
                        }
                        break;
                    case ConsoleKey.D8:
                        if (_number1)
                        {
                            number1 = number1 + "8";
                        }
                        else
                        {
                            number2 = number2 + "8";
                        }
                        break;
                    case ConsoleKey.D9:
                        if (_number1)
                        {
                            number1 = number1 + "9";
                        }
                        else
                        {
                            number2 = number2 + "9";
                        }
                        break;
                    case ConsoleKey.Multiply:
                        _number1 = false;
                        _operator = '*';
                        break;
                    case ConsoleKey.Add:
                        _number1 = false;
                        _operator = '+';
                        break;
                    case ConsoleKey.Separator:
                        _number1 = false;
                        _operator = '-';
                        break;
                    case ConsoleKey.Subtract:
                        _number1 = false;
                        _operator = '-';
                        break;
                    case ConsoleKey.Divide:
                        _number1 = false;
                        _operator = '/';
                        break;
                    case ConsoleKey.OemPlus:
                        switch (_operator)
                        {
                            case '+':
                                Console.Write(" " + (int.Parse(number1) + int.Parse(number2)) + " ");
                                break;
                            case '-':
                                Console.Write(" " + (int.Parse(number1) - int.Parse(number2)) + " ");
                                break;
                            case '*':
                                Console.Write(" " + (int.Parse(number1) * int.Parse(number2)) + " ");
                                break;
                            case '/':
                                Console.Write(" " + (int.Parse(number1) / int.Parse(number2)) + " ");
                                break;
                        }
                        return;
                    default:
                        break;
                }
            }

        }
    }
}
