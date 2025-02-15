using System;
using System.Net;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Http.HttpResults;

namespace ExamenU1_POO_ElkinBohorquez.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class LogicController  : ControllerBase
    {
        public class PrimeController : ControllerBase 
        {
            [HttpGet("is-prime/{number}")]
            public IActionResult Prime(int number)
            {

                int num = Convert.ToInt32(Console.ReadLine());
                int div = 2;

                while (num % div != 0)
                {
                    div++;
                }

                if (div == num)
                {
                    Console.WriteLine("El numero que ingreso si es primo");
                }
                else
                {
                    Console.WriteLine("El numero que ingreso no es primo");
                }
            }
        }

        public class FactorialController : ControllerBase
        {
            [HttpGet("is-factorial/{number}")]
            public IActionResult Factorial(int number)
            {
                Console.WriteLine("Ingrese el numero del cual desea calcular el factorial: ");

                int num = int.Parse(Console.ReadLine());
                int fact = 1;

                for (int i = 1; i <= num; i++)
                {
                    fact = fact * i;
                }

                Console.WriteLine($"El factorial de {num} es {fact}");
            }

        }

        public class FibonacciController : ControllerBase
        {
            [HttpGet("is-fibonacci/{limit}")]
            public IActionResult Fibonacci(int limit)
            {
                if (limit <= 0)
                {
                    Console.WriteLine("El numero que debe de ingresar deber ser mayor que cero");
                }

                List<int> sequence = new List<int>();
                int n1 = 0, n2 = 1;

                sequence.Add(n1);
                if (limit >= n2)
                    sequence.Add(n2);

                while (true)
                {
                    int next = n1 + n2;
                    if (next > limit)
                        break;

                    sequence.Add(next);
                    n1 = n2;
                    n2 = next;
                }

                var response = new
                {
                    limit = limit,
                    sequence = sequence
                };

            }
        }

        public class CountVowelsController : ControllerBase 
        {
            [HttpGet("count-vowels")]
            public IActionResult Vowels(string text)
            {
                Console.WriteLine("Ingrese una oracion: ");
                
                string cant;

                cant = Convert.ToString(Console.ReadLine());

                int a = 0;
                int e = 0;
                int i = 0;
                int o = 0;
                int u = 0;

                foreach (char c in cant) 
                { 
                cant = cant.ToUpper();

                    if (c == 'a') 
                    { 
                        a++;
                    }
                    if (c == 'e')
                    {
                        e++;
                    }
                    if (c == 'i')
                    {
                        i++;
                    }
                    if (c == 'o')
                    {
                        o++;
                    }
                    if (c == 'u')
                    {
                        u++;
                    }
                }

                Console.WriteLine("La cantidad de vocales A en la oracion es: " + a);
                Console.WriteLine("\nLa cantidad de vocales E en la oracion es: " + e);
                Console.WriteLine("\nLa cantidad de vocales I en la oracion es: " + i);
                Console.WriteLine("\nLa cantidad de vocales O en la oracion es: " + o);
                Console.WriteLine("\nLa cantidad de vocales U en la oracion es: " + u);

            }
        }

        public class PalindromoController : ControllerBase 
        {
            [HttpGet("is-palindrome/{word}")]
            public IActionResult Palindromo(string text) 
            {
                string word;
                bool isPalindromo = IsPalindromo(word);

                if (isPalindromo)
                {
                    Console.WriteLine("La palabra " + word + "si es Palindromo");
                }
                else 
                { 
                    Console.WriteLine("La palabra " + word + "no es Palindromo");
                }

                bool IsPalindromo(string bind) 

                { 
                    bind = bind.Replace(" ", "").ToLower();

                    int length = bind.Length;

                    for(int i = 0; i < length / 2; i++)
                    {
                        if (bind[i] != bind[length - 1 - i]) 
                        { 
                            return false;
                        }
                    }
                }
            }
        }
    }
} 

