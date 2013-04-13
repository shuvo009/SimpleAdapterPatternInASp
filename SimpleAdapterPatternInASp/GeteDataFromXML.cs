using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
namespace SimpleAdapterPatternInASp
{
    public class GeteDataFromXML
    {
        public string DataFromXaml(string filePath)
        {
            var outPut = new StringBuilder();
            try
            {
                using (var reader = new XmlTextReader(filePath))
                {
                    while (reader.Read())
                    {
                        switch (reader.NodeType)
                        {
                            case XmlNodeType.Element: 
                                outPut.Append(reader.Name + "\t");
                                break;
                            case XmlNodeType.Text: 
                                outPut.Append(reader.Value + "\n");
                                break;
                        }
                    }
                }
            }
            catch (Exception)
            {
                outPut.Clear();
                outPut.Append("Error !!!! While Reading XML File");
            }
            return outPut.ToString();
        }
    }
}