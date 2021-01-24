using System;

namespace RefAndOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 20;
            int number2 = 100;
            var result = Add(ref number1, number2);
            Console.WriteLine(result); //açıklama aşağıda
            Console.WriteLine(number1); //değer tip olduğu için 20'yi dikkate alır.
        }

        static int Add(ref int number1, int number2) // 30 olarak dikkate alması için referans tipe çevirdik , ref ile.
        {
            //metodun içindeki number1'i dikkate alır.Değer tip olması sebebi ile
            number1 = 30; // ref ile out aynı fakat out yaptığımızda metodun içindeki number 1'i set etmemiz gerekiyor.
            return number1 + number2;
        }


    }

        
}
