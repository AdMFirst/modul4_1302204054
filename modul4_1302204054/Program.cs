
namespace com.kpl.jurnal.modul4
{
    class Penjumlahan
    {
        public static T JumlahTigaAngka<T>(T num1, T num2, T num3)
        {
            dynamic a = num1;
            dynamic b = num2;
            dynamic c = num3;
            return a + b + c;
        }
    }

    class main
    {
        public static void Main()
        {
            //nim = 1302204054
            double nim1 = 13;
            double nim2 = 02;
            double nim3 = 20;

            Console.WriteLine(Penjumlahan.JumlahTigaAngka<double>(nim1, nim2, nim3));
        }
    }
}