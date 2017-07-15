using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using RunExe.Properties;
using RunExe.Model;

namespace RunExe
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Write
            List<Appointment> Appointments = new List<Appointment>();

            int length = 10;
            for (int i = 0; i < length; i++)
            {
                Appointments.Add(new Appointment()
                {
                    Subject = "I'm: " + i,
                    Description = "I'm " + i + " text",
                    Date = Convert.ToDateTime("2017/07/15")
                }); 
            }

            //open file stream
            using (StreamWriter _file = File.CreateText(Settings.Default.File))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(_file, Appointments);
            }
            #endregion

            #region Read
            List<Appointment> RAppointments;
            using (StreamReader r = new StreamReader(Settings.Default.File))
            {
                string json = r.ReadToEnd();
                RAppointments = JsonConvert.DeserializeObject<List<Appointment>>(json);
            }

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Subject:         {0}\n" +
                                  "Description:     {1}\n" +
                                  "Date:            {2}\n" +
                                  "-----------------------------", RAppointments[i].Subject, RAppointments[i].Description, RAppointments[i].Date); 
            }
            #endregion
        }
    }
}