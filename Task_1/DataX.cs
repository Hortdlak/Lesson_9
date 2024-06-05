
using System.Xml.Serialization;

namespace Lesson_9.Task_1
{
    [XmlType("Data#ExtendedEntry")]
    public class DataX : DataEntry
    {
        [XmlElement("Data#Extended")]
        public string? DataExt;
    }
}
