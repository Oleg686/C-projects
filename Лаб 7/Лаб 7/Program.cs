using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lab_7
{
    class Program
    {
        static void Rachet(int i)
        {
            //Нахождение чисел с одинаковым количество четных и нечетных делетелей(при этом в каждой из таких групп делителей не менее 70 элементов) и наименьшим делителем больше 1000 (с импользованием многопоточности)
            int chet = 0;
            int nechet = 0;
            int maxvalue = 0;
            if (i % 2 == 0)
            {
                maxvalue = i / 2;
                chet++;
            }
            else
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        maxvalue = i / j;
                        nechet++;
                        break;
                    }
                }
            }
            for (int g = 1; g <= maxvalue; g++)
            {
                if (i % g == 0)
                {
                    if (g % 2 == 0)
                    {
                        chet++;
                    }
                    else
                    {
                        nechet++;
                    }
                }
            }
            if (chet > 69 && nechet > 69 && chet == nechet)
            {
                for (int r = 1000; r < 450500; r++)
                {
                    if (i % r == 0)
                    {
                        Console.WriteLine(i + "\n" + chet + "\n" + nechet + "\n" + r + "\n");
                        break;
                    }
                }
            }
        }
        public static void D1() //323136 //20196 // 2:25
        {
            for (int i = 326496; i < 346692; i++)
            {
                Rachet(i);
            }
            Thread currentThread = Thread.CurrentThread;
            Console.WriteLine($"Id поток кончил: {currentThread.ManagedThreadId}");
        }
        public static void D2() //107712
        {
            for (int i = 346692; i < 366888; i++)
            {
                Rachet(i);
            }
            Thread currentThread = Thread.CurrentThread;
            Console.WriteLine($"Id поток кончил: {currentThread.ManagedThreadId}");
        }
        public static void D3()
        {
            for (int i = 366888; i < 387084; i++)
            {
                Rachet(i);
            }
            Thread currentThread = Thread.CurrentThread;
            Console.WriteLine($"Id поток кончил: {currentThread.ManagedThreadId}");
        }
        public static void D4()
        {
            for (int i = 387084; i < 407280; i++)
            {
                Rachet(i);
            }
            Thread currentThread = Thread.CurrentThread;
            Console.WriteLine($"Id поток кончил: {currentThread.ManagedThreadId}");
        }
        public static void D5()
        {
            for (int i = 407280; i < 427476; i++)
            {
                Rachet(i);
            }
            Thread currentThread = Thread.CurrentThread;
            Console.WriteLine($"Id поток кончил: {currentThread.ManagedThreadId}");
        }
        public static void D6()
        {
            for (int i = 427476; i < 447672; i++)
            {
                Rachet(i);
            }
            Thread currentThread = Thread.CurrentThread;
            Console.WriteLine($"Id поток кончил: {currentThread.ManagedThreadId}");
        }
        public static void D7() //323136 //53856 // 2:25
        {
            for (int i = 447672; i < 467868; i++)
            {
                Rachet(i);
            }
            Thread currentThread = Thread.CurrentThread;
            Console.WriteLine($"Id поток кончил: {currentThread.ManagedThreadId}");
        }
        public static void D8() //107712
        {
            for (int i = 467868; i < 488064; i++)
            {
                Rachet(i);
            }
            Thread currentThread = Thread.CurrentThread;
            Console.WriteLine($"Id поток кончил: {currentThread.ManagedThreadId}");
        }
        public static void D9()
        {
            for (int i = 488064; i < 508260; i++)
            {
                Rachet(i);
            }
            Thread currentThread = Thread.CurrentThread;
            Console.WriteLine($"Id поток кончил: {currentThread.ManagedThreadId}");
        }
        public static void D10()
        {
            for (int i = 508260; i < 528456; i++)
            {
                Rachet(i);
            }
            Thread currentThread = Thread.CurrentThread;
            Console.WriteLine($"Id поток кончил: {currentThread.ManagedThreadId}");
        }
        public static void D11()
        {
            for (int i = 528456; i < 548652; i++)
            {
                Rachet(i);
            }
            Thread currentThread = Thread.CurrentThread;
            Console.WriteLine($"Id поток кончил: {currentThread.ManagedThreadId}");
        }
        public static void D12()
        {
            for (int i = 548652; i < 568848; i++)
            {
                Rachet(i);
            }
            Thread currentThread = Thread.CurrentThread;
            Console.WriteLine($"Id поток кончил: {currentThread.ManagedThreadId}");
        }
        public static void D13()
        {
            for (int i = 568848; i < 589044; i++)
            {
                Rachet(i);
            }
            Thread currentThread = Thread.CurrentThread;
            Console.WriteLine($"Id поток кончил: {currentThread.ManagedThreadId}");
        }
        public static void D14()
        {
            for (int i = 589044; i < 609240; i++)
            {
                Rachet(i);
            }
            Thread currentThread = Thread.CurrentThread;
            Console.WriteLine($"Id поток кончил: {currentThread.ManagedThreadId}");
        }
        public static void D15()
        {
            for (int i = 609240; i < 629436; i++)
            {
                Rachet(i);
            }
            Thread currentThread = Thread.CurrentThread;
            Console.WriteLine($"Id поток кончил: {currentThread.ManagedThreadId}");
        }
        public static void D16()
        {
            for (int i = 629436; i < 649632; i++)
            {
                Rachet(i);
            }
            Thread currentThread = Thread.CurrentThread;
            Console.WriteLine($"Id поток кончил: {currentThread.ManagedThreadId}");
        }
        static void Main()
        {
            Thread p1 = new Thread(D1);
            Thread p2 = new Thread(D2);
            Thread p3 = new Thread(D3);
            Thread p4 = new Thread(D4);
            Thread p5 = new Thread(D5);
            Thread p6 = new Thread(D6);
            Thread p7 = new Thread(D7);
            Thread p8 = new Thread(D8);
            Thread p9 = new Thread(D9);
            Thread p10 = new Thread(D10);
            Thread p11 = new Thread(D11);
            Thread p12 = new Thread(D12);
            Thread p13 = new Thread(D13);
            Thread p14 = new Thread(D14);
            Thread p15 = new Thread(D15);
            Thread p16 = new Thread(D16);

            p1.Start();
            p2.Start();
            p3.Start();
            p4.Start();
            p5.Start();
            p6.Start();
            p7.Start();
            p8.Start();
            p9.Start();
            p10.Start();
            p11.Start();
            p12.Start();
            p13.Start();
            p14.Start();
            p15.Start();
            p16.Start();
        }
    }
}
    
