using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Windows.Forms;

namespace RocketConfigEditor
{
    class FileHandler
    {
           private static readonly string Dir = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)).FullName.ToString() + "\\RocketApp";

        public static bool scanFileDirectory()
        {
            if (Directory.Exists(Dir))
            {
                string[] subFiles = Directory.GetDirectories(Dir);
                if (subFiles.Length < 2)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
            
        }
        public static XmlDocument getConfigDocument(string Doc)
        {
            XmlDocument localDoc = new XmlDocument();

            try
            {
                if (File.Exists(Dir + "\\" + Doc))
                {
                    localDoc.Load(Dir + "\\" + Doc);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("File is empty please delete the file and re-download it.\n File Path :"+Dir+"\\"+Doc);
            }
            
            
            return localDoc;
        }
        public static bool returnConfigDocument(XmlDocument doc,string doc2)
        {
            FileStream stream = new FileStream(Dir+"\\"+doc2,FileMode.Create,FileAccess.Write);
            try
            {
                doc.Save(stream);
                stream.Flush();
                stream.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                return false;
            }
            
            return true;
        }
       
    }
}
