
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
namespace com.kpl.jurnal.modul4
{
    public class SimpleDataBase<T>
    {
        private List<T> StoredData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            StoredData = new List<T>();
            inputDates = new List<DateTime>();
        } 

        public void AddNewData(T newData)
        {
            StoredData.Add(newData);
            inputDates.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            for (int i = 0; i < StoredData.Count; i++)
            {
                Console.WriteLine( 
                    "Data " 
                    + (i + 1).ToString()  
                    + " berisi: "
                    + StoredData[i].ToString()
                    + ", yang disimpan pada waktu "
                    + inputDates[i].ToString()
                    );
            }
        }
    }

    class main
    {
        public static void Main()
        {
            SimpleDataBase<double> simpleData = new SimpleDataBase<double>();
            //nim = 1302204054
            double nim1 = 13;
            double nim2 = 02;
            double nim3 = 20;

            simpleData.AddNewData(nim1);
            simpleData.AddNewData(nim2);
            simpleData.AddNewData(nim3);

            simpleData.PrintAllData();
        }
    }
}