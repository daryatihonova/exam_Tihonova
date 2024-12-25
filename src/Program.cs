using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_Tihonova
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во вершин графа:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                Console.Write("Кол-во вершин не должно быть отрицательным числом.");
                n = Convert.ToInt32(Console.ReadLine());
            }
           
            double[,] a = new double[n, n];


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = Double.MaxValue;

                }
                a[i, i] = 0;

            }


            Console.WriteLine("Вывод меток в таблице протоколов: первая метка=0, остальные бесконечность:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    Console.Write(a[i, j] + "" + "\n");


                }

            }

            Console.WriteLine("Заполните вес каждого ребра или поставьте 0, если ребра нет.");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        continue;
                    Console.Write($"Ребро от вершины {i + 1} до вершины {j + 1}:");
                    double input = Convert.ToDouble(Console.ReadLine());
                    if (input != 0)
                    {
                        a[i, j] = input;
                    }

                }

            }

            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    
                    Console.Write(a[i,j] + " ");
                   

                }

            }
            Console.WriteLine(" ");

            Console.Write("Введите начальную вершину от 0:");
            int start = Convert.ToInt32(Console.ReadLine());
            if (start < 0)
            {
                Console.Write("Начальная вершина не может быть отрицательным числом.");
                start = Convert.ToInt32(Console.ReadLine());
            }


            double[] dist = Dijkstra(a, start);

          
                    for (int k = 0; k < dist.Length; k++)
                    {
                        Console.WriteLine($"Расстояние от вершины {start } до вершины {k} : {dist[k]}");
                    }

          

            Console.ReadKey();
        }

        private static double[] Dijkstra(double[,] a, int v0) 
        {
            int n = a.GetLength(0);
            double[] dist = new double[n];  
            bool[] vis = new bool[n]; 
            int unvis = n; 
            int v; 

            for (int i = 0; i < n; i++)   
                dist[i] = Double.MaxValue;
            dist[v0] = 0.0;  

            while (unvis > 0)  
            {
                v = -1;  
                for (int i = 0; i < n; i++)
                {
                    if (vis[i])
                        continue;
                    if ((v == -1) || (dist[v] > dist[i])) 
                        v = i; 
                }
                vis[v] = true; 
                unvis--;
                for (int i = 0; i < n; i++)
                {
                    if (dist[i] > dist[v] + a[v, i])  
                        dist[i] = dist[v] + a[v, i]; 
                }
            }
            return dist; 
        }
    }
}
