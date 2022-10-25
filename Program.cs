using System;

namespace KartaPracy3b
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. (very easy) Napisz pętle wypisujacą dni miesiąca listopada 2022 roku
            // WE: -
            // WY: dni
            /*
            for (int i = 1; i <= 30; i++)
            {
                Console.WriteLine($"Jest to {i} dzień listopada 2022 roku.");
            }
            */

            // 2. (easy) Napisz pętle wypisujacą kwadraty cyfr nieparzystych
            // WE: -
            // WY: no kwadraty ma się rozumieć
            /*
            for (int i = 1; i <= 100; i+=2)
            {
                if (i%2==1)
                {
                    Console.WriteLine(i*i);
                }
            }
            */

            // 3. (easy) Napisz pętle wypisującą liczby czterocyfrowe dzielące się przez 379
            // WE: -
            // WY: las liczb
            /*
            for (int i = 1000; i < 10000; i++)
            {
                if (i%379==0)
                {
                    Console.WriteLine(i);
                }
            }
            */

            // 4. (medium) Napisz pętle wypisującą liczby trzycyfrowe podzielne przez 5, 6 lub ewentualnie 11
            // WE: -
            // WY: liczby
            /*
            for (int i = 100; i < 1000; i++)
            {
                if (i%5==0 & i%6==0 | i%11==0)
                {
                    Console.WriteLine(i);
                }
            }
            */

            // 5. (medium) Napisz program, który podaje sumę wpisanych przez usera liczb. User najpierw podaje ile liczb
            // poda, a potem w pętli te liczby są czytane.
            // WE: n, n-liczb
            // WY: suma
            /*
            int n = int.Parse(Console.ReadLine()),suma=0;

            for (int i = 0; i < n; i++)
            {
                suma += int.Parse(Console.ReadLine());
            }
            Console.WriteLine(suma);
            */

            // 6. (light hard) Napisz program wyznaczający sumę k początkowych liczb parzystych.
            // WE: k
            // WY: suma
            /*
            int k = int.Parse(Console.ReadLine());

            int suma = 0, pow = 0;
            for (int i = 1; i <= k; i++)
            {
                pow = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i%j==0)
                    {
                        pow += 1;
                        break;
                    }
                }
                if (pow == 0)
                {
                    if (i%2==0)
                    {
                        suma += i;
                    }
                }
            }
            Console.WriteLine(suma);
            */

            // 7. (light hard) Napisz program wyznaczający sumę m początkowych dwucyfrowych liczb nieparzystych.
            // WE: m
            // WY: suma
            /*
            int m = int.Parse(Console.ReadLine());
            if (m<=10 & m>=99){
                int suma = 0, pow = 0;
                for (int i = 1; i <= m; i++)
                {
                    pow = 0;
                    for (int j = 2; j < i; j++)
                    {
                        if (i%j==0)
                        {
                            pow += 1;
                            break;
                        }
                    }
                    if (pow == 0)
                    {
                        if (i%2==1)
                        {
                            suma += i;
                        }
                    }
                }
                Console.WriteLine(suma);
            }
            */

            // 8. (light hard) Napisz program, który W PĘTLI obliczy wartość inwestycji, która jest kapitalizowana co miesiąc w stosunku 6% rocznie. User podaje kwotę wejściową W0 oraz okres inwestycji w latach L z dokładnością do pół roku.
            // WE: W0, L
            // WY: wartość

            // 9. (hard) Napisz program wyznaczający sumę n początkowych liczb kończących się liczbą 21
            // WE: n
            // WY: suma
            int n = int.Parse(Console.ReadLine());
            int pow = 0;
            for (int i = 1; i <= n; i++)
            {
                pow = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i%j==0)
                    {
                        pow += 1;
                        break;
                    }
                }
                if (pow == 0)
                {
                    if (i%10==0)
                    {
                        if (i%100==0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }
        }
    }
}
