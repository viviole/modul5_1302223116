using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302223116
{
    internal class SimpleDataBase<T>
    {
        private List <T> storedData;
        private List <DateTime> inputDates;

        public SimpleDataBase() {
            storedData = new List <T>();
            inputDates = new List <DateTime>();
        }

        public void AddNewData(T newData)
        {
            storedData.Add(newData);
            inputDates.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine($"Data {i+1} berisi: {storedData.ElementAt(i)} yang disimpan pada waktu {inputDates.ElementAt(i)}");
            }
            
        }
    } 
}
