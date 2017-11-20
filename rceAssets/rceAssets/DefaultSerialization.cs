using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace rceAssets
{
    public class DefaultSerialization
    {

        //Generic to (de)serialize any object based on its path for a more dynamic system
        private static readonly string pluginsDir = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)).FullName.ToString() + "\\RocketApp\\Plugins\\";
        public static void serialize<T>(T obj, string fileFullName)
        {
            try
            {
                XmlSerializer xSerialize = new XmlSerializer(typeof(T));
                FileStream stream = new FileStream(pluginsDir + fileFullName, FileMode.Create, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(stream);
                TextWriter tWrite = (TextWriter)streamWriter;
                xSerialize.Serialize(tWrite, obj);
                tWrite.Flush();
                streamWriter.Flush();
                stream.Flush();

                tWrite.Close();
                streamWriter.Close();
                stream.Close();
            }
            catch (Exception e)
            {

                throw new Exception(string.Format("Failed to Serialize {0}\n", pluginsDir+fileFullName), e);
            }
        }
        public static T deserialize<T>(T obj, string fileFullName)
        {
            try
            {
                if (File.Exists(pluginsDir+ fileFullName))
                {
                    XmlSerializer xSerialize = new XmlSerializer(typeof(T));
                    FileStream stream = new FileStream(pluginsDir+ fileFullName, FileMode.Open, FileAccess.Read);
                    StreamReader streamReader = new StreamReader(stream);
                    TextReader tRead = (TextReader)streamReader;
                    obj = (T)xSerialize.Deserialize(tRead);
                    tRead.Close();
                    streamReader.Close();
                    stream.Close();
                    return obj;
                }
                else
                {
                    throw new rceException(string.Format("The following file could not be found\n{0}\n please re-download the file", pluginsDir+ fileFullName));
                }

            }
            catch (rceException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception ex)
            {

                MessageBox.Show(string.Format("Failed to Deserialize {0}\n", fileFullName), ex.ToString());

            }
            return obj;

        }
    }
}
