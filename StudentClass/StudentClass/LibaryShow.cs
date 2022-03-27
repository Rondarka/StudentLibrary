using System;
using System.Collections.Generic;
using StudentLibrary;

namespace StudentClass
{
    class LibaryShow
    {

        static void Main(string[] args)
        {
            StudentLibrary.StudentLibrary lib = new StudentLibrary.StudentLibrary();
             
            double[] studentmarks = { 5,5,4,4,3 }; // заполнение оценками для вычисления среднего арифметического
            Console.WriteLine("Среднее арифметическое значение оценки: " + lib.MinAVG(studentmarks));

            Console.WriteLine("Номер студенческого билета: " + lib.GetStudentNumber(2018, 3, "Протапенко Александр Львович")); //Получение номера студенческого билета

             List<Marks> marks = new List<Marks> {  //заполнение класса оценок
                new Marks { Estimation = "5", date = Convert.ToDateTime("27.03.2022") },
                new Marks { Estimation = "Прогул", date = Convert.ToDateTime("29.03.2022") },
                new Marks { Estimation = "Прогул", date = Convert.ToDateTime("06.04.2022") },
                new Marks { Estimation = "Прогул", date = Convert.ToDateTime("25.04.2022") },
                new Marks { Estimation = "Болезнь", date = Convert.ToDateTime("08.04.2022") },
                new Marks { Estimation = "Болезнь", date = Convert.ToDateTime("10.04.2022")},
            };

            Console.WriteLine("Прогулов за месяц: " + lib.GetCountTruancy(marks)); // кол-во прогулов за месяц

            Console.WriteLine("Болезней за месяц: " + lib.GetCountDisease(marks)); // кол-во пропусков по болезни за месяц
        }
    }
}
