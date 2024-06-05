using System.Text.Json;
using System.Xml.Linq;

namespace Lesson_9.Task_2
{
    internal class Weather
    {
        #region Weather init

        public DateTime? Time { get; set; }
        public double? Temperature { get; set; }
        public int? Weathercode { get; set; }
        public double? Windspeed { get; set; }
        public int? Winddirection { get; set; }

        #endregion

        #region JSON => Weather
        public static Weather FromJson(JsonElement json)
        {
            return new Weather
            {
                Time = DateTime.TryParse(json.GetProperty(nameof(Time)).GetString(), out var time) ? time : null,
                Temperature = json.GetProperty(nameof(Temperature)).GetDouble(),
                Weathercode = json.GetProperty(nameof(Weathercode)).GetInt32(),
                Windspeed = json.GetProperty(nameof(Windspeed)).GetDouble(),
                Winddirection = json.GetProperty(nameof(Winddirection)).GetInt32()
            };
        }

        #endregion

        #region Weather => XML
        public XElement ToXml()
        {
            return new XElement("Current",
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
