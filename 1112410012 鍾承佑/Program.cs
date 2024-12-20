using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1112410012_鍾承佑
{
    internal class Program
    {
        static void Main()
        {
            MyHomeWork01();
            MyHomeWork02();
        }

        static void MyHomeWork01()
        {
            int[] intArray = new int[4];
            float[] floatArray = new float[4];
            double[] doubleArray = new double[4];
            string[] stringArray = new string[4];

            Console.WriteLine("請分別輸入四個整數：");
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write($"整數[{i}]：");
                intArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("請分別輸入四個浮點數：");
            for (int i = 0; i < floatArray.Length; i++)
            {
                Console.Write($"浮點數[{i}]：");
                floatArray[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("請分別輸入四個倍精確度數：");
            for (int i = 0; i < doubleArray.Length; i++)
            {
                Console.Write($"倍精確度數[{i}]：");
                doubleArray[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("請分別輸入四個字串：");
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.Write($"字串[{i}]：");
                stringArray[i] = Console.ReadLine();
            }

            Console.WriteLine("\n整數陣列內容：" + string.Join(", ", intArray));
            Console.WriteLine("整數平均值：" + intArray.Average());

            Console.WriteLine("\n浮點數陣列內容：" + string.Join(", ", floatArray));
            Console.WriteLine("浮點數平均值：" + floatArray.Average());

            Console.WriteLine("\n倍精確度數陣列內容：" + string.Join(", ", doubleArray));
            Console.WriteLine("倍精確度數平均值：" + doubleArray.Average());

            Console.WriteLine("\n字串陣列內容：" + string.Join(", ", stringArray));
        }

        static void MyHomeWork02()
        {
            int[] intArrayInit = { 1, 2, 3, 4, 5 };
            float[] floatArrayInit = { 1.2f, 2.3f, 3.4f, 4.5f, 5.6f };
            double[] doubleArrayInit = { 1.22, 2.33, 3.44, 4.55, 5.66 };
            string[] stringArrayInit = { "王小明", "陳大明", "李小英", "張小美", "陳不良" };

            Console.WriteLine("\n有初始值的整數陣列內容：" + string.Join(", ", intArrayInit));
            Console.WriteLine("整數平均值：" + intArrayInit.Average());

            Console.WriteLine("\n有初始值的浮點數陣列內容：" + string.Join(", ", floatArrayInit));
            Console.WriteLine("浮點數平均值：" + floatArrayInit.Average());

            Console.WriteLine("\n有初始值的倍精確度數陣列內容：" + string.Join(", ", doubleArrayInit));
            Console.WriteLine("倍精確度數平均值：" + doubleArrayInit.Average());

            Console.WriteLine("\n有初始值的字串陣列內容：" + string.Join(", ", stringArrayInit));
        }
    }
}