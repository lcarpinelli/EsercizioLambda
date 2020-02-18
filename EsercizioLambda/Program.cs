using System;
using System.Collections.Generic;

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
            Action<DateTime, DateTime> printLowerDate = (data1, data2) => { if (data1 > data2) {Console.WriteLine($"Tra {data1.ToString("dd/MM/yyyy")} e {data2.ToString("dd/MM/yyyy")} la data piu grande è {data2.ToString("dd/MM/yyyy")}"); } else{ Console.WriteLine($"Tra {data1.ToString("dd/MM/yyyy")} e {data2.ToString("dd/MM/yyyy")} la data piu grande è {data1.ToString("dd/MM/yyyy")}"); };};
            //Esercizio 4
            Func<int,int,int,int> getMinimum = (first, second, third) => { int min = first; if (second < min) { min = second; } if (third < min) { min = third; } return min; };
            //Esercizio 5
            Func<int, bool> bisestile = (year) => { bool value = DateTime.IsLeapYear(year); return value; };

            //Esercizio 1 e Esercizio 4
            int first = 51;
            int second = 62;
            int third = 84;
            int max = getMaximum(first, second, third);
            int min = getMinimum(first, second, third);
            Console.WriteLine($"Il valore più grande tra {first}-{second}-{third} è {max} e il valore più piccolo è {min}");

            //Esercizio 2
            string name = "Lorenzo";
            string surname = "Carpinelli";
            string result = concatFirstAndLastName(name, surname);
            Console.WriteLine($"Il suo nome completo è {result}");

            //Esercizio 3 e Esempio
            DateTime date1 = new DateTime(2000, 12, 20);
            DateTime date2 = new DateTime(2002, 12, 20);
            printLowerDate(date1, date2);
            canDrive(date1);
            canDrive(date2);

            //Esercizio 5
            int year = 2020;
            int year2 = 2030;
            bool b = bisestile(year);
            bool b2 = bisestile(year2);
            Console.WriteLine($"L'anno {year} è bisestile = {b}");
            Console.WriteLine($"L'anno {year2} è bisestile = {b2}");


        }
    }
}
