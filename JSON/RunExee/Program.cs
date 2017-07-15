using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using RunExe.Properties;

namespace RunExe
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Write
            
            #endregion

            #region Read
            List<Item> items;
            using (StreamReader r = new StreamReader(Settings.Default.SrcJson))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<Item>>(json);
            }

            Console.WriteLine("Subject:         {0}\n" +
                              "Description:     {1}", items[0].Subject, items[1].Description);
            #endregion
        }
    }

    public class Item
    {
        public string Subject;
        public string Description;
        public DateTime Date;
    }
}