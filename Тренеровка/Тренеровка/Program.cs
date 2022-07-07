using System;
using System.Text;
namespace Тренеровка
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 1 до 11");
            int n = Convert.ToInt32(Console.ReadLine());
            switch(n)
            {
                // квадрат вводимого числа
                case 1:
                    Console.WriteLine("Укажите размер массива");
                    int[] arr = new int[Convert.ToInt32(Console.ReadLine())];
                    Console.WriteLine("Введите элементы массива");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = Convert.ToInt32(Console.ReadLine());

                    }
                    for (int w = 0; w < arr.Length;w++ )
                    {
                        Console.Write(arr[w] * arr[w] + " ");
                    }

                    break;
                case 2:
                    // Проверка данных на построение треугольника
                    Console.WriteLine("Введите углы треугольника");
                    int o, l, e;
                    o = Convert.ToInt32(Console.ReadLine());
                    l = Convert.ToInt32(Console.ReadLine());
                    e = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите стороны треугольника");
                    int a, b, c;
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    c = Convert.ToInt32(Console.ReadLine());
                    if (a > 0 && b > 0 && c > 0 && o > 0 && l > 0 && e > 0) 
                        if (a < b + c && b < a + c && c < b + a && o + l + e == 180)
                        
                            Console.WriteLine("Треугольник можно построить");
                    else
                                Console.WriteLine("Треугольник нельзя построить");
                        
                        else
                            Console.WriteLine("Нельзя вводить нуль");
                                
                    break;
                case 3:
                    // Проверка массивов на четность или нечетность 
                    Console.WriteLine("Введите размер четного массива");
                    int[] arr1 = new int [Convert.ToInt32(Console.ReadLine())];
                    int schet = 0;
                    for(int i = 0; i < arr1.Length;i++)
                    {
                        arr1[i] = Convert.ToInt32(Console.ReadLine());
                    }
                   Console.WriteLine("Введите размер нечетный массив");
                    int[] arr2 = new int [Convert.ToInt32(Console.ReadLine())];
                    for (int m = 0; m < arr2.Length;m++)
                    {
                        arr2[m] = Convert.ToInt32(Console.ReadLine());
                    }
                    for (int i = 0; i < arr1.Length; i++)
                    {
                        if (arr1[i] % 2 == 0)
                            schet++;
                    }
                    if (arr1.Length == schet)
                        Console.WriteLine("Массив верный");
                    else
                        Console.WriteLine("Массив неверный");
                    schet = 0;
                    for (int i = 0; i < arr2.Length; i++)
                    {
                        if (arr2[i] % 2 != 0)
                            schet++;
                    }
                    if (arr2.Length == schet)
                        Console.WriteLine("Массив верный");
                    else
                        Console.WriteLine("Массив неверный");
                    break;
                case 4:
                    // Удаление среднего символа из слова
                    Console.WriteLine("Введите слово");
                    string arr3 = Console.ReadLine();
                    string result = null;
                    for (int i = 0; i < arr3.Length; i++)
                    {
                        if (arr3.Length % 2 != 0)
                            result = arr3.Remove((arr3.Length / 2), 1);

                        else
                            result = arr3.Remove((arr3.Length / 2) - 1, 2);
                    }
                    Console.WriteLine(result);
                    break;
                case 5:
                    // Проверка суммы чисел на четность или нечетность 
                    Console.WriteLine("Введите размера массива");
                    int[] arr4 = new int [Convert.ToInt32(Console.ReadLine())];
                    int sum = 0;
                    for (int i = 0; i < arr4.Length;i++)
                    {
                        arr4[i] = Convert.ToInt32(Console.ReadLine());
                        sum += arr4[i]; 
                    }
                    if (sum % 2 != 0)
                        Console.WriteLine("Сумма нечетная");
                    else
                        Console.WriteLine("Сумма четная");
                    break;
                case 6:
                    //Подсчет денег через n количество времени 
                    double p, j, t, r, y;
                    Console.WriteLine("Введите сумму денег");
                    p = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите проценты за год");
                    j = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите налог ( в процентах )");
                    t = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("На сколько лет");
                    y = Convert.ToDouble(Console.ReadLine());
                    j = j * 100;
                    t = t * 100;
                        r = p * Math.Pow(((1 + j) / (1 + t)), y);
                        Console.WriteLine("Сумма денег " + r + " через " + y + " лет");
                        Console.WriteLine("Сумма денег " + "{0:0.00}", r);
                    break;
                case 7: 
                    // Сортировка нечетный чисел массива
                    Console.WriteLine("Введите размер массива");
                    int[] str = new int [Convert.ToInt32(Console.ReadLine())];
                    for(int i = 0; i < str.Length;i++)
                    {
                        str[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    int u;
                    int temp = 0;

                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i] % 2 == 0)
                            continue;
                        for (int g = (i + 1); g < str.Length; g++)
                        {
                            if (str[g] % 2 != 0)
                            {
                                if (str[i] > str[g])
                                {
                                    temp = str[i];
                                    str[i] = str[g];
                                    str[g] = temp;
                                }
                            }
                        }
                    }
                    for(int k = 0; k < str.Length;k++)
                    {
                        Console.Write(str[k] + " ");
                    }

                    break;
                case 8:
                    // Вывод самого короткого слова в строке
                    Console.WriteLine("Введите строку: ");
                    string str2 = Console.ReadLine();
                    char[] seps = { ' ', '.', ',', '!', '?', '-' };
                    string[] parts = str2.Split(seps);
                    int min = 1000;
                    int x = 0;
                    for (int i = 0; i < parts.Length; i++)
                    {
                        if (parts[i].Length <= min)
                        {
                            min = parts[i].Length;
                            x = i;
                        }
                        if (parts[x].Length == parts[i].Length)
                            Console.WriteLine(parts[i]);
                    }
                        break;
                case 9:
                    // Поиск всех делителей числа и их количество
                    Console.WriteLine("Введите число ");
                    int chislo = Convert.ToInt32(Console.ReadLine());
                    int da = 0;
                    for (int i = 1; i <= chislo; i++)
                    {
                        if (chislo % i == 0)
                        {
                            Console.Write(i + " ");
                            da++;
                        }
                    }
                    Console.WriteLine("\n" + da);
                   
                    break;
                case 10:
                    //Нахождение суммы в промежутке чисел
                    int z, q;
                    Console.WriteLine("Введите два числа");
                    z = Convert.ToInt32(Console.ReadLine());
                    q = Convert.ToInt32(Console.ReadLine());
                    int sum1 = 0;
                    if (z > q)
                    {
                        for (int i = z; i > q; i--)
                            sum1 += i;
                        Console.WriteLine(sum1);
                    }
                    else if (q > z)
                    {
                        for (int i = q; i > z; i--)
                            sum1 += i;
                        Console.WriteLine(sum1);
                    }
                    break;
                case 11:
                    //Проверка кирпича на вхождение в отверстие определ
                    int len, wid, hei, leng, heig;
                    Console.WriteLine("Введите длину кирпича");
                    len = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите ширину кирпича");
                    wid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите высота кирпича");
                    hei = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите длину отверстия");
                    leng = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите высоту отверстия");
                    heig = Convert.ToInt32(Console.ReadLine());
                    if (wid <= leng && hei <= heig)
                        Console.WriteLine("Кирипич влезет первой стороной");
                    else if (len <= leng && hei <= heig)
                        Console.WriteLine("Кирпич влезет второй стороной");
                    else if (len <= leng && wid <= heig)
                        Console.WriteLine("Кирпич влезет третьей стороной");
                    else
                        Console.WriteLine("Кирпич не влезет");
                        

                    break;
            }
           
        }
    }
}
