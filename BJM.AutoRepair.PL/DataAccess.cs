using System.Xml.Serialization;

namespace BJM.AutoRepair.PL
{
    public static class DataAccess
    {
        public static string XMLFilePath { get; set; } = string.Empty;

        public static void SaveXml(Type type, object obj)
        {
            using (StreamWriter writer = new StreamWriter(XMLFilePath))
            {

                XmlSerializer serializer = new XmlSerializer(type);
                serializer.Serialize(writer, obj);
            }
        }
        public static object? LoadXml(Type type)
        {

            using (StreamReader reader = new StreamReader(XMLFilePath))
            {
                XmlSerializer serializer = new XmlSerializer(type);
                return serializer.Deserialize(reader);
            }
        }
    }
}