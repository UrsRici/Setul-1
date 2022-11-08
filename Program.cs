using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Setu_1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Introduceti numarul exercitiului(1-21): ");
            int n = int.Parse(Console.ReadLine());
            if (n == 1) ex1();
            if (n == 2) ex2();
            if (n == 3) ex3();
            if (n == 4) ex4();
            if (n == 5) ex5();
            if (n == 6) ex6();
            if (n == 7) ex7();
            if (n == 8) ex8();
            if (n == 9) ex9();
            if (n == 10) ex10();
            if (n == 11) ex11();
            if (n == 12) ex12();
            if (n == 13) ex13();
            if (n == 14) ex14();
            if (n == 15) ex15();
            if (n == 16) ex16();
            if (n == 17) ex17();
            if (n == 18) ex18();
            if (n == 19) ex19();
            if (n == 20) ex20();
            if (n == 21) ex21();
            if (n > 21 || n < 1) Main();
        }
        static void ex1()
        {
            double a, b;
            Console.WriteLine("1.Sa se rezolve ecuatia de forma:ax + b = 0");
            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("x = " + (-b / a));
            Main();
        }
        static void ex2()
        {
            double x1, x2, del, a, b, c;
            Console.WriteLine("2.Sa se rezolve ecuatia de forma:ax^2 + bx + c = 0");
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = int.Parse(Console.ReadLine());
            del = (b * b) - (4 * a * c);
            if (del == 0)
                Console.WriteLine(-b / (2 * a));
            else
            {
                if (del < 0)
                    Console.WriteLine("Ecuatia nu are solutii reale");
                else
                {

                    x1 = (-b - Math.Sqrt(del)) / (2 * a);
                    x2 = (-b + Math.Sqrt(del)) / (2 * a);
                    Console.WriteLine("x1 = " + x1 + " x2 = " + x2);
                }
            }
            Main();
        }
        static void ex3()
        {
            Console.WriteLine("3.Determinati daca n se divide cu k:");
            int n, k;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            k = int.Parse(Console.ReadLine());
            if (n % k == 0)
                Console.WriteLine(n + " divide pe " + n);
            else
                Console.WriteLine(n + " nu divide pe " + n);
            Main();
        }
        static void ex4()
        {
            Console.WriteLine("4.Sa se determine daca un an y este an bisect:");
            int y;
            Console.Write("y = ");
            y = int.Parse(Console.ReadLine());
            if (y % 400 == 0 || (y % 4 == 0 && y % 100 != 0))
                Console.WriteLine(y + " este an bisect");
            else
                Console.WriteLine(y + " nu este an bisect");
            Main();
        }
        static void ex5()
        {
            Console.WriteLine("5.Sa se afiseze a k-a cifra a numarului n:");
            int n, k, s = 1, i;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            k = int.Parse(Console.ReadLine());
            for (i = 1; i < k; i++)
                s = s * 10;
            Console.WriteLine(n / s % 10 + " este a " + k + "cifra a numarului" + n);
            Main();
        }
        static void ex6()
        {
            Console.WriteLine("6.Sa se determine daca segmentele a, b, c formeaza un triunghi:");
            int a, b, c;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = int.Parse(Console.ReadLine());
            if (a < b + c && b < a + c && c < a + b)
                Console.WriteLine("a, b, c formeaza un triunghi");
            else
                Console.WriteLine("a, b, c nu formeaza un triunghi");
            Main();
        }
        static void ex7()
        {
            Console.WriteLine("7.Sa se intrerschimbe valorile lui a si b:");
            int a, b, c;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            c = a;
            a = b;
            b = c;
            Console.WriteLine("a = " + a + " b = " + b);
            Main();
        }
        static void ex8()
        {
            Console.WriteLine("8.Sa se intrerschimbe valorile lui a si b fara a lua inca o variabila:");
            int a, b;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a = " + a + " b = " + b);
            Main();
        }
        static void ex9()
        {
            Console.WriteLine("9.Sa se afiseza toti divisozii lu n:");
            int n, i;
            Console.WriteLine("n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Divisori lun " + n + " sunt:");
            for (i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                    Console.Write(i + " ");
            }
            Console.WriteLine(n);
            Main();
        }
        static void ex10()
        {
            Console.WriteLine("10.Sa se determine daca n este numar prim:");
            int n, i, steag = 0;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write(n);
            for (i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    steag = 1;
                    break;
                }
            }
            if (steag == 0)
                Console.WriteLine(" este prim");
            else
                Console.WriteLine(" NU este prim");
            Main();
        }
        static void ex11()
        {
            Console.WriteLine("11.Sa se afiseze in ordine inversa cifrele numarului n:");
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                Console.Write(n % 10);
                n = n / 10;
            }
            Console.WriteLine();
            Main();
        }
        static void ex12()
        {
            Console.WriteLine("12.Sa se afiseze cate numere divizibile cu n se afla in intervalul [a,b]:");
            int i, a, b, n, s = 0;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            for (i = a; i <= b; i++)
                if (i % n == 0)
                    s++;
            Console.WriteLine("Sunt " + s + " numere diviszibile cu " + n + " in intervalul [" + a + "," + b + "]");
            Main();
        }
        static void ex13()
        {
            Console.WriteLine("13.Sa se determine cati ani bisecti se afla in intervalul [y1, y2]:");
            int y1, y2;
            Console.Write("y1 = ");
            y1 = int.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            y2 = int.Parse(Console.ReadLine());
            Console.Write("Sunt ");
            if ((y1 % 4 == 0) && (y1 % 100 != 0) || (y1 % 400 == 0))
                if ((y2 % 4 == 0) && (y2 % 100 != 0) || (y2 % 400 == 0))
                    Console.Write(2 + (((y2 / 4) - (y1 / 4)) - ((y2 / 100) - (y1 / 100)) + ((y2 / 400) - (y1 / 400))));
                else
                    Console.Write(1 + (((y2 / 4) - (y1 / 4)) - ((y2 / 100) - (y1 / 100)) + ((y2 / 400) - (y1 / 400))));
            else
                Console.Write((((y2 / 4) - (y1 / 4)) - ((y2 / 100) - (y1 / 100)) + ((y2 / 400) - (y1 / 400))));
            Console.WriteLine(" anii bisecti in intervalul [" + y1 + "," + y2 + "]");
            Main();
        }
        static void ex14()
        {
            Console.WriteLine("14.Sa se determine daca numarul n este palindrom:");
            int n, a, b = 0;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            for (a = n; a > 0; a /= 10)
            {
                b = b * 10 + a % 10;

            }
            if (n == b)
                Console.WriteLine("Numarul " + n + " este palindrom");
            else
                Console.WriteLine("Numarul " + n + " NU este palindrom");
            Main();
        }
        static void ex15()
        {
            Console.WriteLine("15.Sa se ordoneze crescator numerele a, b, c:");
            int a, b, c;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = int.Parse(Console.ReadLine());
            if (a <= b && a <= c)
                if (b <= c)
                    Console.WriteLine(a + " " + b + " " + c);
                else
                    Console.WriteLine(a + " " + c + " " + b);
            else
                if (b <= c)
                if (a <= c)
                    Console.WriteLine(b + " " + a + " " + c);
                else
                    Console.WriteLine(b + " " + c + " " + a);
            else
                    if (a <= b)
                Console.WriteLine(c + " " + a + " " + b);
            else
                Console.WriteLine(c + " " + b + " " + a);
            Main();
        }
        static void ex16()
        {
            Console.WriteLine("15.Sa se ordoneze crescator numerele a, b, c, d, e:");
            int a, b, c, d, e;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = int.Parse(Console.ReadLine());
            Console.Write("d = ");
            d = int.Parse(Console.ReadLine());
            Console.Write("e = ");
            e = int.Parse(Console.ReadLine());
            if (a > b) { a += b; b = a - b; a -= b; }
            if (a > c) { a += c; c = a - c; a -= c; }
            if (a > d) { a += d; d = a - d; a -= d; }
            if (a > e) { a += e; e = a - e; a -= e; }
            if (b > c) { b += c; c = b - c; b -= c; }
            if (b > d) { b += d; d = b - d; b -= d; }
            if (b > e) { b += e; e = b - e; b -= e; }
            if (c > d) { c += d; d = c - d; c -= d; }
            if (c > e) { c += e; e = c - e; c -= e; }
            if (d > e) { d += e; e = d - e; d -= e; }
            Console.WriteLine(a + " " + b + " " + c + " " + d + " " + e);
            Main();
        }
        static void ex17()
        {
            Console.WriteLine("17.Sa se determine CMMDC si CMMMC al numerelor a si b:");
            int a, b, x, y;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            x = a;
            y = b;
            while (x != y)
            {
                if (x > y)
                    x -= y;
                else
                    y -= x;
            }
            Console.WriteLine("CMMDC = " + x);
            x = a;
            y = b;
            while (x != y)
            {
                if (x > y)
                    y += b;
                else
                    x += a;
            }
            Console.WriteLine("CMMMC = " + x);
            Main();
        }
        static void ex18()
        {
            Console.WriteLine("18.Sa se afiseze in factori prim numarul n:");
            int n, s, i;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            for (i = 2; i <= n; i++)
            {
                s = 0;
                while (n % i == 0)
                {
                    n /= i;
                    s++;
                }
                if (s != 0)
                    Console.WriteLine(i + "^" + s);
            }
            Main();
        }
        static void ex19()
        {
            Console.WriteLine("19.Sa se determine daca numarul n este format doar din 2 cifre:");
            int n, a, b = 10, st = 0;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            a = n % 10;
            n /= 10;
            while (n > 0)
            {
                if (a == n % 10)
                    n /= 10;
                else
                {
                    b = n % 10;
                    break;
                }
            }
            n /= 10;
            while (n > 0)
            {
                if (n % 10 != a && n % 10 != b)
                {
                    st = 1;
                    break;
                }
                else
                    n /= 10;
            }
            if (b == 10)
                Console.WriteLine("Numarul este format dintr-o cifra");
            else
                if (st == 1)
                Console.WriteLine("Numarul este format din mai mult de 2 cifre");
            else
                Console.WriteLine("Numarul este format din 2 cifre");
            Main();
        }
        static void ex20()
        {
            Console.WriteLine("20.Sa se afiseze fractia m/n cu perioada daca e necesar:");
            int n, m, x, y, semn = 0;
            double d;
            Console.Write("m = ");
            m = int.Parse(Console.ReadLine());
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            if (m < 0 && n > 0 || m > 0 && n < 0)
                semn = 1;
            if (semn == 1)
                Console.Write("-");
            if (n < 0)
                n = -n;
            if (m < 0)
                m = -m;
            d = (double)m / n;
            x = n;
            y = m;
            while (x != y)      //Sa fie prime intre ele
            {
                if (x > y)
                    x -= y;
                else
                    y -= x;
            }                   //Sa fie prime intre ele
            n /= y;
            m /= y;
            x = n;
            while (x != 1)
            {
                if (x % 2 == 0)
                    x /= 2;
                else
                {
                    if (x % 5 == 0)
                        x /= 5;
                    else
                        break;
                }
            }
            if (x == 1)                         // fractie neperiodica
                Console.WriteLine(d);
            else
            {
                if (x == n)                 // fractie periodica simpla
                {
                    double z, s = 100;
                    int steag = 0;

                    d = (double)m / n;
                    //Console.WriteLine(d);
                    while (s < 100000001)
                    {
                        d = (double)m / n;
                        z = ((int)(d * s) % s) / s;
                        d = (int)(((d * s) - (int)(d * s)) * s) / s;
                        if (z == d)
                        {
                            steag = 1;
                            //Console.WriteLine(z);
                            break;
                        }
                        else
                            s *= 10;
                        //Console.WriteLine(z);
                    }
                    //Console.WriteLine(steag);
                    //Console.WriteLine(d);
                    //Console.WriteLine((int)(d*10));
                    //Console.WriteLine((int)(d * 100) % 10);
                    if (steag == 0)
                        Console.WriteLine((double)m / n);
                    else
                    {
                        //Console.WriteLine(s);
                        if (s == 100 && (int)(d * 10) == (int)(d * 100) % 10)
                            Console.WriteLine(m / n + ".(" + ((int)(d * 10)) + ")");
                        else
                        {
                            Console.Write(m / n + ".(");
                            while (s > 10)
                            {
                                //Console.WriteLine(d);
                                Console.Write((int)(d * 10));
                                //Console.WriteLine((d * 10));
                                d = (double)(d * 10) - (int)(d * 10);
                                //Console.WriteLine(d);
                                s /= 10;
                            }
                            Console.WriteLine((d * 10) + ")");
                        }
                    }
                }               // fractie periodica simpla

                else
                {                              // fractie periodica mixta
                    //Console.WriteLine(d);
                    int i = 0, j = 0;
                    double s = 10;
                    x = n;
                    while (x != 1)
                    {
                        if (x % 2 == 0)
                        {
                            x /= 2;
                            i++;
                        }
                        else
                        {
                            if (x % 5 == 0)
                            {
                                x /= 5;
                                j++;
                            }
                            else
                                break;
                        }
                    }
                    int max;
                    if (i > j)
                        max = i;
                    else
                        max = j;
                    Console.Write(m / n + ".");
                    d = d - (int)d;
                    for (i = 0; i < max; i++)
                    {
                        Console.Write((int)(d * 10));
                        d = (d * 10) - (int)(d * 10);
                    }
                    double z, q;
                    s = 100;
                    int steag = 0;
                    q = d;
                    //Console.WriteLine(d);
                    while (s < 100000001)
                    {
                        d = q;
                        z = ((int)(d * s) % s) / s;
                        d = (int)(((d * s) - (int)(d * s)) * s) / s;
                        if (z == d)
                        {
                            steag = 1;
                            //Console.WriteLine(z);
                            break;
                        }
                        else
                            s *= 10;
                        //Console.WriteLine(z);
                    }
                    /*Console.WriteLine(steag);
                    Console.WriteLine(d);
                    Console.WriteLine((int)(d*10));
                    Console.WriteLine((int)(d * 100) % 10);*/
                    if (steag == 0)
                        Console.WriteLine(q);
                    else
                    {
                        if (s == 100 && (int)(d * 10) == (int)(d * 100) % 10)
                            Console.WriteLine("(" + ((int)(d * 10)) + ")");
                        else
                        {
                            Console.Write("(");
                            while (s > 1)
                            {
                                Console.Write((int)(d * 10));
                                d = (d * 10) - (int)(d * 10);
                                s /= 10;
                            }
                            Console.WriteLine(")");
                        }
                    }
                }                       // fractie periodica mixta
            }
            Main();
        }
        static void ex21()
        {
            Console.WriteLine("21.Sa se derermine un numar din intervalul " +
                "(1, 1024) prin intrebarea: Numarul este mai mare, mai mic sau egal cu x?");
            int min = 1, max = 1024, mij = 0, i;
            string[] sir = { "0" };
            for (i = 0; i < 9; i++)
            {
                if (min == 1)
                    mij = max / 2;
                else
                    mij = (max + min) / 2;
                Console.WriteLine("Numarul este mai mare, mai mic sau egal cu " + mij + "?");
                sir = Console.ReadLine().Split('\0');
                if (sir[0] == "mai mare")
                    min = mij;
                if (sir[0] == "mai mic")
                    max = mij;
                if (sir[0] == "egal")
                    break;
                if (max != mij && min != mij)
                    i--;
            }
            if (i == 9)
            {
                if (sir[0] == "mai mare")
                    Console.WriteLine("Numarul tau este: " + (mij + 1));
                else
                    Console.WriteLine("Numarul tau este: " + (mij - 1));
            }
            else
                Console.WriteLine("Numarul tau este: " + mij);
            Main();
        }
    }
}