using System;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TASK12();

        }

        static void TASK1()
        {    /*  a massivinin (a[0],a[1] .... a[n])  |a[i]| < c sertini odeyen elementlerini cap etmek  
              (c deyisheninin qiymeti istifadeciden sorushulur,hemcinin a massivinin elementleri de) */

            Console.Write("Enter the size of the Array: ");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Methods.FillArray(a);

            Console.Write("Enter the variable c: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Elemets less than c: ");
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < c) Console.Write(a[i] + " ");
            }
        }

        static void TASK2()
        {    /*  a massivinin (a[0],a[1] .... a[n])  |a[i]| < c sertini odeyen 
              elementlerinin ededi ortasini tapmaq */

            Console.Write("Enter the size of the Array: ");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Methods.FillArray(a);

            Console.Write("Enter the variable c: ");
            int c = int.Parse(Console.ReadLine());

            int sum = 0;
            int count = 0;
            double ave;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < c)
                {
                    sum += a[i];
                    count++;
                }
            }
            ave = (double)sum / count;
            Console.WriteLine("Average: " + ave);
        }

        static void TASK3()
        {    /*  a massivinin (a[0],a[1] .... a[n])  |a[i]| < c sertini odeyen 
              elementlerinin hendesi ortasini tapmaq */

            Console.Write("Enter the size of the Array: ");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Methods.FillArray(a);

            Console.Write("Enter the variable c: ");
            int c = int.Parse(Console.ReadLine());

            int product = 1;
            int count = 0;
            double geoMean;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < c)
                {
                    product *= a[i];
                    count++;
                }
            }
            geoMean = Math.Pow(product, (double)1 / count);

            Console.WriteLine("Geometric mean: " + geoMean);
        }

        static void TASK4()
        {    /*   a massivinin (a[0],a[1] .... a[n])  |a[i]| > c sertini odeyen 
               elementlerini coxdan aza dogru siralamaq */

            Console.Write("Enter the size of the Array: ");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Methods.FillArray(a);

            Methods.PrintArray(a);
            Console.WriteLine();

            Console.Write("Enter the variable c: ");
            int c = int.Parse(Console.ReadLine());

            int temp;

            for (int i = 0; i < a.Length - 1; i++)
            {

                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] < a[j] && a[i] < c)
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;

                    }
                }
            }
            Methods.PrintArray(a);
        }

        static void TASK5()
        {    /*   a massivinin (a[0],a[1] .... a[n])  |a[i]| < c sertini 
              odeyen elementler icinden maximum elementi tapmaq */

            Console.Write("Enter the size of the Array: ");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Methods.FillArray(a);

            Console.Write("Enter the variable c: ");
            int c = int.Parse(Console.ReadLine());

            int max = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < c)
                {
                    if (a[i] > max)
                        max = a[i];

                }

            }
            Console.WriteLine("Max: " + max);
        }

        static void TASK6()
        {    /*   X(n) ve Y(n) deye 2 massiv verilmishdir/Ele x[i] elementi tapmaq lazimdir ki 
                x[i] = y[i] ^ 2 (eyni indexdeki x elementi hemin indexdeki y elementin kvadratina 
               beraber olsun) */

            Console.Write("Enter the size of the Arrays: ");
            int n = int.Parse(Console.ReadLine());
            int[] y = new int[n];
            for (int i = 0; i < y.Length; i++)
            {
                Console.Write($"y[{i}]=");
                y[i] = int.Parse(Console.ReadLine());

            }

            int[] x = new int[n];
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write($"x[{i}]=");
                x[i] = int.Parse(Console.ReadLine());

            }

            int index = 0;

            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == y[i] * y[i])
                {
                    index = i;
                    Console.WriteLine($"x[{index}]=y[{index}]^2= {x[i]}");

                }

            }
        }

        static void TASK7()
        {    /*   a massivinin (a[0],a[1] .... a[n]) en kicik ve en boyuk elementlerinin 
              hendesi ve ededi ortasini tapmali*/

            Console.Write("Enter the size of the Array: ");
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            Methods.FillArray(a);


            int max = a[0];
            int min = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                    max = a[i];

                if (a[i] < min)
                    min = a[i];

            }
            double ave = (min + max) / 2;
            double geoMean = (double)Math.Pow(min * max, (double)1 / 2);

            Console.WriteLine("Average: " + ave);
            Console.WriteLine("Geometric Mean: " + ave);


        }

        static void TASK8()
        {    /*   Heriri 14 elementli 2 massivin uygun elementlerini bir birine vurub 
              alinan musbet hasillerden  yeni massiv duzeltmeli */


            int n = 14;
            int[] y = new int[n];
            for (int i = 0; i < y.Length; i++)
            {
                Console.Write($"y[{i}]=");
                y[i] = int.Parse(Console.ReadLine());

            }

            int[] x = new int[n];
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write($"x[{i}]=");
                x[i] = int.Parse(Console.ReadLine());

            }

            int[] z = new int[14];

            for (int i = 0; i < x.Length; i++)
            {
                z[i] = x[i] * y[i];



            }
            Methods.PrintArray(z);
        }

        static void TASK9()
        {    /*   25 elementli massivin ilk 8 elementini kvadrata yukseltmeli,
                  qalanini ise 4-e bolub,yeni iki massiv duzeltmeli */


            int n = 25;
            double[] y = new double[n];
            for (int i = 0; i < y.Length; i++)
            {
                Console.Write($"y[{i}]=");
                y[i] = int.Parse(Console.ReadLine());

            }


            double[] z = new double[8];
            double[] x = new double[17];

            for (int i = 0; i < 8; i++)
            {
                z[i] = y[i] * y[i];

            }
            Console.Write("Z-array: ");
            foreach (double item in z) Console.Write(item + " ");
            Console.WriteLine();


            for (int i = 0; i < 17; i++)
            {
                x[i] = y[i + 8] / 4;
            }
            Console.Write("X-array: ");
            foreach (var item in x) Console.Write(item + " ");
        }

        static void TASK10()
        {    /*   X(n) massivinden ancaq menfi elementlerin maximum elementi tapin*/

            Console.Write("Enter the size of the Array: ");
            int n = int.Parse(Console.ReadLine());
            int[] x = new int[n];
            Methods.FillArray(x);


            int max = x[0];


            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] < 0)
                {
                    if (x[i] > max)
                        max = x[i];
                }

            }
            Console.WriteLine("Max=" + max);



        }

        static void TASK11()
        {    /*   X(n) massivinin elementlerini random olaraq 0-100 arasi ededlerle doldurub,
                  sonra ise azalma sirasina gore duzmeli */

            Random random = new Random();
            int n = random.Next(4, 7);
            int[] x = new int[n];

            for (int i = 0; i < x.Length; i++)
            {
                int a = random.Next(0, 100);
                x[i] = a;
            }

            foreach (var item in x)
            {
                Console.Write(item + " ");
            }


            Console.WriteLine();


            int temp;

            for (int i = 0; i < x.Length - 1; i++)
            {

                for (int j = i + 1; j < x.Length; j++)
                {
                    if (x[i] < x[j])
                    {
                        temp = x[i];
                        x[i] = x[j];
                        x[j] = temp;

                    }
                }
            }
            Methods.PrintArray(x);
        }

        static void TASK12()
        {    /*   X(20) massivinin ilk yarisinin ededi ortasini ikinci yarisinin hendesi ortasini tapma */


            int n = 20;
            int[] x = new int[n];

            for (int i = 0; i < x.Length; i++)
            {
                Console.Write($"x[{i}]=");
                x[i] = int.Parse(Console.ReadLine());

            }

            double sum = 0;
            double count = 0;
            double product = 1;
            double counter = 0;

            for (int i = 0; i < x.Length - 10; i++)
            {
                sum += x[i];
                count++;

            }
            double ave = (double)sum / count;
            Console.WriteLine("Average: " + ave);


            for (int i = 0; i < x.Length - 10; i++)
            {
                product *= x[i + 10];
                counter++;
            }

            double geoMean = Math.Pow(product, (double)1 / counter);

            Console.WriteLine("Geometric mean: " + geoMean);

        }

    }
}
