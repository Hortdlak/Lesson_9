using System.Text.Json;
using System.Xml.Linq;

namespace Lesson_9.Task_2
{
    internal class WeatherInfo
    {
        #region WeatherInfo init

        public required Weather Current { get; set; }

        public required List<WeatherHistory> History { get; set; }

        #endregion

        #region JSON => WeatherInfo
        public static WeatherInfo FromJson(string json)
        {
            using (JsonDocument doc = JsonDocument.Parse(json))
            {
                JsonElement root = doc.RootElement;
                var current = Weather.FromJson(root.GetProperty(nameof(Current)));
                var history = root.GetProperty(nameof(History)).EnumerateArray()
                    .Select(WeatherHistory.FromJson).ToList();

                return new WeatherInfo { Current = current, History = history };
            }
        }

        #endregion

        #region WeatherInfo => XML
        public XElement ToXml()
        {
            return new XElement("WeatherInfo",
                Current.ToXml(),
                new XElement("History",
                    History.Select(entry => entry.ToXml())
                )
            );
        }
        #endregion
    }
}