using System.Xml.Serialization;

namespace Lesson_9.Task_1
{
    [XmlRoot("Data.Root")]
    public class DataRoot
    {
        [XmlArray("Data.Root.Names")]
        [XmlArrayItem("Name")]
        public string[]? Names;

        [XmlElement(typeof(DataEntry))]
        [XmlElement(typeof(DataX))]
        public DataEntry[]? Entry;

    }
}
