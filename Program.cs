using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4_1302204050
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Penjumlahan.JumlahTigaAngka<long>(12, 34, 56));
        }
    }
    class Penjumlahan
    {
        public static T JumlahTigaAngka<T>(T input1, T input2, T input3)
        dynamic a = input1;
        dynamic b = input2;
        dynamic c = input3;

        return a + b + c;
    }
    class SimpleDataBase<T>
    {
        private List<T> storeData;
        private List<DataTime> inputDates;

        public SimpleDataBase()
        {
            this.storeData = new List<T>();
            this.inputDates = new List<T>();

        }
        public void AddNewData(T newData)
        {
            this.inputDates.Add(newData.Now);
            this.storeData.Add(newData);
        }
        public void PrintAllNewData()
        {
            for (int i = 0; i < this.storeData.Count; i++)
            {
                Console.WriteLine("Data" +1 + "berisi" + this.storeData[i] + ",data yang disimpan waktu UTC" + this.inputDates[]);
            }
        }
    }
}