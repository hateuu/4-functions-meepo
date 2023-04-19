using System;
using System.Collections.Generic;
using System.Linq;
using static ConsoleApp.encrypt1;
using static ConsoleApp.decrypt1;
using static ConsoleApp.encrypt2;
using static ConsoleApp.decrypt2;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            a1:
            Console.WriteLine("\nВыберите режим:");
            Console.WriteLine("1 - Шифрование текста с помощью частотного анализа");
            Console.WriteLine("2 - Шифрование текста с помощью ключа");
            Console.WriteLine("3 - Дешифрование текста с помощью частотного анализа");
            Console.WriteLine("4 - Дешифрование текста с помощью ключа");

            string mode = Console.ReadLine();
            switch (mode)
            {
                case "1":
                {
                    Console.Write("Введите текст для шифрования: ");
                    string message = Console.ReadLine();
                    if (message.Length < 1)
                    {
                        Console.WriteLine("Ошибка. Пожалуйста, введите текст");
                    }
                    else
                    {
                        Console.Write("Введите ключ (строка без повторяющихся символов): ");
                        string key = Console.ReadLine();
                        if (key.Length < 1)
                        {
                            Console.WriteLine("Ошибка. Пожалуйста, введите ключ");
                        }
                        else
                        {
                            string encryptedMessage = EncryptByFrequencyAnalysis(message, key);
                            Console.Write("Зашифрованный текст: ");
                            Console.WriteLine(encryptedMessage);
                        }
                    }
                    goto a1;
                }
                case "2":
                {
                    Console.Write("Введите текст для шифрования: ");
                    string message = Console.ReadLine();
                    if (message.Length < 1)
                    {
                        Console.WriteLine("Ошибка. Пожалуйста, введите текст");
                    }
                    else
                    {
                        Console.Write("Введите ключ (строка без повторяющихся символов): ");
                        string key = Console.ReadLine();
                        if (key.Length < 1)
                        {
                            Console.WriteLine("Ошибка. Пожалуйста, введите ключ");
                        }
                        else
                        {
                            string encryptedMessage = EncryptByKey(message, key);
                            Console.Write("Зашифрованный текст: ");
                            Console.WriteLine(encryptedMessage);
                        }
                    }

                    goto a1;
                }
                case "3":
                {
                    Console.Write("Введите текст для дешифрования: ");
                    string encryptedMessage = Console.ReadLine();
                    if (encryptedMessage.Length < 1)
                    {
                        Console.WriteLine("Ошибка. Пожалуйста, введите текст");
                    }
                    else
                    {
                        Console.Write("Введите ключ (строка без повторяющихся символов): ");
                        string key = Console.ReadLine();
                        if (key.Length < 1)
                        {
                            Console.WriteLine("Ошибка. Пожалуйста, введите ключ");
                        }
                        else
                        {
                            string decryptedMessage = DecryptByFrequencyAnalysis(encryptedMessage, key);
                            Console.Write("Расшифрованный текст: ");
                            Console.WriteLine(decryptedMessage);
                        }
                    }
                   
                    goto a1;
                }
                case "4":
                {
                    Console.Write("Введите текст для дешифрования: ");
                    string encryptedMessage = Console.ReadLine();
                    if (encryptedMessage.Length < 1)
                    {
                        Console.WriteLine("Ошибка. Пожалуйста, введите текст");
                    }
                    else
                    {
                        Console.Write("Введите ключ (строка без повторяющихся символов): ");
                        string key = Console.ReadLine();
                        if (key.Length < 1)
                        {
                            Console.WriteLine("Ошибка. Пожалуйста, введите ключ");
                        }
                        else
                        {
                            string decryptedMessage = DecryptByKey(encryptedMessage, key);
                            Console.Write("Расшифрованный текст: ");
                            Console.WriteLine(decryptedMessage);
                        }
                    }
                    goto a1;
                }
                default:
                    Console.WriteLine("Некорректный режим.");
                    goto a1;
            }
            
        }
    }
}