using System;

namespace ArrayCRUD
{
    class Program
    {
        private const double FloatNumber = 3.4647;
        private const int Index1 = 2;
        private const int Index2 = 3;

        static void Main()
        {
            var sut = new ObjectArray();
            var intArr = new[] { 2, 3, 4 };
            sut.Add(0);
            sut.Add(true);
            sut.Add(FloatNumber);
            sut.Add("string");
            sut.Add(intArr);
            sut.IndexOf(false);
            Console.WriteLine(sut[Index1]);
            Console.WriteLine(sut[Index2]);
            Console.WriteLine("Hello World!");
            Console.Read();
        }
    }
}
