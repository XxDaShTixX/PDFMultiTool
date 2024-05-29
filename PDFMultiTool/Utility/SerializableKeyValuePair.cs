using System;
using System.Xml.Serialization;

namespace PDFMultiTool.Utility
{
    [Serializable]
    public class SerializableKeyValuePair<TKey, TValue>
    {
        public TKey Key;
        public TValue Value;

        public SerializableKeyValuePair() { }

        public SerializableKeyValuePair(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }
    }

    [XmlRoot("Configuration")]
    public class ConfigurationData
    {
        [XmlElement("GhostScriptPath")]
        public string GhostScriptPath { get; set; }

        // Add other configuration properties as needed...
    }
}
