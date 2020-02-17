using System;

namespace EsercizioLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esempio
            Action<DateTime> canDrive = data => { bool value= data.AddYears(18) <= DateTime.Today; Console.WriteLine($"La data {data.ToString("dd/MM/yyyy")} è maggiorenne = {value}"); };
            //Esercizio 1
            Func<string, string, string> concatFirstAndLastName = (name, surname) => {string FullName = $"{name} {surname}"; return FullName;};
            //Esercizio 2
            Func<int, int, int, int> getMaximum = (first, second, third) => { int max = first; if(second > max) {max = second;} if(third > max) {max = third;} return max; };
            //Esercizio 3
            Action<DateTime, DateTime> printLowerDate = (data1, data2) => { if (data1 > data2) {Console.WriteLine($"Piu grande {data2.ToString("dd/MM/yyyy")}"); } else { Console.WriteLine($"Piu grande {data1.ToString("dd/MM/yyyy")}"); }; };

            //Esercizio 1
            int first = 1;
            int second = 2;
            int third = 4;
            int max = getMaximum(first, second, third);
            Console.WriteLine(max);

            //Esercizio 2
            string name = "NOME";
            string surname = "COGNOME";
            string result = concatFirstAndLastName(name, surname);
            Console.WriteLine(result);

            //Esercizio 3 e Esempio
            DateTime date1 = new DateTime(2000, 12, 20);
            DateTime date2 = new DateTime(2000, 8, 23);
            printLowerDate(date1, date2);
            canDrive(date1);
            canDrive(date2);
          
        }
    }
}
