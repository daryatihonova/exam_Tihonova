using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string inputN = "-9\n9\n";
            using (var stringReader = new StringReader(inputN))
            {
                Console.SetIn(stringReader);
                int n = 0;
                Console.Write("Введите кол-во вершин графа:");
                 n = Convert.ToInt32(Console.ReadLine());
                if (n < 0)
                {
                    Console.Write("Кол-во вершин не должно быть отрицательным числом.");
                    n = Convert.ToInt32(Console.ReadLine());
                }

               
            }
        }
    }
}
