using System.Text.Json;
using System.Xml.Linq;

namespace Lesson_9.Task_2
{
    public class WeatherHistory
    {
        #region WeatherHistory init

        public string? Time { get; set; }
        public int? Temperature { get; set; }
        public int? Weathercode { get; set; }
        public double? Windspeed { get; set; }
        public int? Winddirection { get; set; }

        #endregion

        #region JSON => WeatherHistory
        public static WeatherHistory FromJson(JsonElement json)
        {
            return new WeatherHistory
            {
                Time = json.GetProperty(nameof(Time)).GetString(),
                Temperature = json.GetProperty(nameof(Temperature)).GetInt32(),
                Weathercode = json.GetProperty(nameof(Weathercode)).GetInt32(),
                Windspeed = json.GetProperty(nameof(Windspeed)).GetDouble(),
                Winddirection = json.GetProperty(nameof(Winddirection)).GetInt32()
            };
        }

        #endregion

        #region WeatherHistory => XML
        public XElement ToXml()
        {
            return new XElement("Entry",
                new XElement("Time", Time),
                new XElement("Temperature", Temperature),
                new XElement("Weathercode", Weathercode),
                new XElement("Windspeed", Windspeed),
                new XElement("Winddirection", Winddirection)
            );
        }

        #endregion
    }
}

