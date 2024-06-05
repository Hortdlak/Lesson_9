using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Xml.Linq;
using System.Xml.Serialization;
using Lesson_9.Task_1;
using Lesson_9.Task_2;

namespace Lesson_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Задание 1:

            //var xms = """
            //    <?xml version="1.0" encoding="utf-8"?>
            //    <Data.Root xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
            //        <Data.Root.Names>
            //            <Name>Name1</Name>
            //            <Name>Name2</Name>
            //            <Name>Name3</Name>
            //        </Data.Root.Names>

            //        <Data. Entry LinkedEntry="Name1">
            //            <Data.Name>Name2</Data.Name>
            //        </Data.Entry>

            //        <Data_x0023_ExtendedEntry LinkedEntry="Name2">
            //            <Data.Name>Name1</Data.Name>
            //            <Data_x0023_Extended>NameOne</Data_x0023_Extended>
            //        </Data_x0023_ExtendedEntry>
            //    </Data.Root> 
            //    """;
            //DataRoot dataRoot = new DataRoot();
            //dataRoot.Names = new string [] { "Name1", "Name2", "Name3" };

            //dataRoot.Entry = new DataEntry[2];
            //dataRoot.Entry[0] = new DataEntry();
            //dataRoot.Entry[0].LinkedEntry = dataRoot.Names[0];
            //dataRoot.Entry[0].Name = dataRoot.Names[1];

            //dataRoot.Entry[1] = new DataX { LinkedEntry = "Name2", Name = "Name1", DataExt = "NameOne" };

            //var seriolaze = new XmlSerializer(typeof(DataRoot));

            //seriolaze.Serialize(Console.Out, dataRoot);

            #endregion

            #region Домашняя работа ( вариант основанный на задание 2):

            var fileJson = "{\"Current\":{\"Time\":\"2023-06-18T20:35:06.722127+04:00\",\"Temperature\":29,\"Weathercode\":1," +
                "\"Windspeed\":2.1,\"Winddirection\":1},\"History\":[{\"Time\":\"2023-06-17T20:35:06.77707+04:00\",\"Temperature\":29," +
                "\"Weathercode\":2,\"Windspeed\":2.4,\"Winddirection\":1},{\"Time\":\"2023-06-16T20:35:06.777081+04:00\",\"Temperature\":22," +
                "\"Weathercode\":2,\"Windspeed\":2.4,\"Winddirection\":1},{\"Time\":\"2023-06-15T20:35:06.777082+04:00\",\"Temperature\":21," +
                "\"Weathercode\":4,\"Windspeed\":2.2,\"Winddirection\":1}]}";

            var weatherData = WeatherInfo.FromJson(fileJson);
            XElement xml = weatherData.ToXml();

            Console.WriteLine(xml);

            #endregion

            #region Задание 3:

            //List<string> list = new List<string>();

            //list = FindValueInJSON(fileJson);

            //var weatherInfo = JsonSerializer.Deserialize<WeatherInfo>(fileJson);

            #endregion
        }

        public static List<string> FindValueInJSON(string file)
        { 
            List<string> result = new List<string>();
                
            return result;
        }
    }
}
