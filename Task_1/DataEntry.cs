using System.Xml.Serialization;

namespace Lesson_9.Task_1
{
    [XmlType("Data.Entry")]
    public class DataEntry
    {
        [XmlAttribute]
        public string? LinkedEntry;
        [XmlElement("Data.Name")]
        public string? Name;
    }
}
