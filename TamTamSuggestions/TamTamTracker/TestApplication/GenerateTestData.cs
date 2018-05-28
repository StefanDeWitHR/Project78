using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TestApplication
{
    public  class GenerateTestData
    {
        public DateTime GetRandomDate()
        {
            DateTime dtStart = new DateTime(2015, 1, 1);
            DateTime dtEnd = new DateTime(2018, 1, 1);
            Random rnd = new Random();

            int cdayRange = (dtEnd - dtStart).Days;

            return dtStart.AddDays(rnd.NextDouble() * cdayRange);
        }
        public List<string> GenerateListKwartieren()
        {
            List<string> kwartieren = new List<string>();
            //kwartieren.Add("08:00");
            //kwartieren.Add("08:15");
            //kwartieren.Add("08:30");
            //kwartieren.Add("08:45");
            //kwartieren.Add("09:00");
            //kwartieren.Add("09:15");
            //kwartieren.Add("09:30");
            //kwartieren.Add("09:45");
            kwartieren.Add("10:00");
            kwartieren.Add("10:15");
            kwartieren.Add("10:30");
            kwartieren.Add("10:45");
            kwartieren.Add("11:00");
            kwartieren.Add("11:15");
            kwartieren.Add("11:30");
            kwartieren.Add("11:45");
            kwartieren.Add("12:00");
            kwartieren.Add("12:00");
            kwartieren.Add("12:15");
            kwartieren.Add("12:30");
            kwartieren.Add("12:45");
            kwartieren.Add("13:00");
            kwartieren.Add("13:15");
            kwartieren.Add("13:30");
            kwartieren.Add("13:45");
            kwartieren.Add("14:00");       
            kwartieren.Add("14:15");
            //kwartieren.Add("14:30");
            //kwartieren.Add("14:45");
            //kwartieren.Add("15:00");
            //kwartieren.Add("15:15");
            //kwartieren.Add("15:30");
            //kwartieren.Add("15:45");
            //kwartieren.Add("16:00");
            //kwartieren.Add("16:15");
            //kwartieren.Add("16:30");
            //kwartieren.Add("16:45");
            //kwartieren.Add("17:00");

            return kwartieren;
        }
        public void  Run()
        {

            Random rnd = new Random();
            int schoolvakantie = rnd.Next(0, 1);
            int feestdag = rnd.Next(0, 1);
            int file = rnd.Next(0, 1);
            DateTime maand_jaar  =  GetRandomDate();
            List<string> kwartieren = GenerateListKwartieren();
            string module = "lunch";
            int keuze = 0;
            DB.OpenCon();
            DateTime d;
            for (int i = 0; i < 10000; i++)
            {

                // after save generate_new_ids
               
                schoolvakantie = rnd.Next(0, 2);
                feestdag = rnd.Next(0, 2);
                file = rnd.Next(0, 2);
                maand_jaar = GetRandomDate();
                
                kwartieren = GenerateListKwartieren();
                keuze = rnd.Next(0, kwartieren.Count());
                kwartieren.ElementAt(keuze);

                var temp = kwartieren[keuze];
                

                if (DateTime.TryParse(temp, out maand_jaar))
                {
                    maand_jaar.AddTicks(maand_jaar.TimeOfDay.Ticks);
                }
               
                DB.QueryInsert<string>("INSERT INTO  data_beacon(`school_holiday`,`feast_day`,`file`,`dt_created`,`module`) VALUES ('" + schoolvakantie + "' , '" + feestdag + "','" + file + "','" + maand_jaar + "','" + module + "')"); // Save results in DB

            }
           DB.CloseCon();


        }       
    }
}