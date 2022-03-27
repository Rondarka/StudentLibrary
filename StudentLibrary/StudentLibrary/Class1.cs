using System;
using System.Collections.Generic;

namespace StudentLibrary
{
    public class StudentLibrary
    {
        public double MinAVG(double[] marks)
        {
            double marksum = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                marksum += marks[i];
            }
            double minavg = marksum / marks.Length;
            return Math.Round(minavg, 2);
        }

        public string GetStudentNumber(int year, int group, string fio)
        {
            string[] studfio = fio.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string initial = "";
            for (int i = 0; i < studfio.Length; i++)
            {
                if (i != 0)
                {
                    initial += studfio[i].Substring(0, 1);
                }
                else
                {
                    initial += studfio[i];
                }
            }
            string studnumber = year + "." + group + "." + initial;
            return studnumber;
        }


        public int GetCountTruancy(List<Marks> marks)
        {
            int P = 0;
            for (int i = 0; i < marks.Count; i++)
            {
                if (DateTime.Now.AddDays(31) >= marks[i].date && DateTime.Now <= marks[i].date && marks[i].Estimation == "Прогул")
                {
                    P++;
                }
            }
            return P;
        }

        public int GetCountDisease(List<Marks> marks)
        {
            int P = 0;
            for (int i = 0; i < marks.Count; i++)
            {
                if (DateTime.Now.AddDays(31) >= marks[i].date && DateTime.Now <= marks[i].date && marks[i].Estimation == "Болезнь")
                {
                    P++;
                }
            }
            return P;
        }
    }
}
