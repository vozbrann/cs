using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Practice4.Tools
{
    internal static class SerializeManager
    {
        private static string CheckAndCreatePath(string filename)
        {
            if (!Directory.Exists(StaticResources.ClientDirPath))
                Directory.CreateDirectory(StaticResources.ClientDirPath);

            return Path.Combine(StaticResources.ClientDirPath, filename);
        }

        #region Binary Serialization

        public static void SerializeBinary<TObject>(TObject obj, string fileName)
        {
            try
            {
                var formatter = new BinaryFormatter();
                var filePath = CheckAndCreatePath(fileName);

                using (var fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, obj);
                }
            }
            catch (Exception ex)
            {
                Logger.Log("Failed to serialize object", ex);
                throw;
            }
        }

        public static TObject DeserializeBinary<TObject>(string fileName)
        {
            try
            {
                var formatter = new BinaryFormatter();
                var filePath = CheckAndCreatePath(fileName);
                using (var fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    var deserializedObject = (TObject)formatter.Deserialize(fs);
                    return deserializedObject;
                }
            }
            catch (Exception ex)
            {
                Logger.Log("Failed to deserialize object", ex);
                throw;
            }
        }

        #endregion

        #region XML Serialization

        public static void SerializeXML<TObject>(TObject obj, string fileName)
        {
            try
            {
                var formatter = new XmlSerializer(typeof(TObject));
                var filePath = CheckAndCreatePath(fileName);

                using (var fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, obj);
                }
            }
            catch (Exception ex)
            {
                Logger.Log("Failed to serialize object", ex);
                throw;
            }
        }

        public static TObject DeserializeXML<TObject>(string fileName)
        {
            try
            {
                var formatter = new XmlSerializer(typeof(TObject));
                var filePath = CheckAndCreatePath(fileName);
                using (var fs = new FileStream(filePath, FileMode.OpenOrCreate))
                {
                    return (TObject)formatter.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                Logger.Log("Failed to deserialize object", ex);
                throw;
            }
        }

        #endregion

        #region JSON Serialization

        public static void SerializeJSON<TObject>(TObject obj, string fileName)
        {
            try
            {
                var filePath = CheckAndCreatePath(fileName);
                using (StreamWriter file = File.CreateText(filePath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, obj);
                }
            }
            catch (Exception ex)
            {
                Logger.Log("Failed to serialize object", ex);
            }
        }

        public static TObject DeserializeJSON<TObject>(string fileName)
        {
            try
            {
                var filePath = CheckAndCreatePath(fileName);
                using (StreamReader file = File.OpenText(filePath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    return (TObject)serializer.Deserialize(file, typeof(TObject));
                }
            }
            catch (Exception ex)
            {
                Logger.Log("Failed to deserialize object", ex);
                throw;
            }
        }

        #endregion

    }
}
