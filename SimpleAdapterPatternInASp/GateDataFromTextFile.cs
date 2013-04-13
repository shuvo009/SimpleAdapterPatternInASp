using System;
using System.Web;
using System.IO;
namespace SimpleAdapterPatternInASp
{
    public class GateDataFromTextFile
    {
        public string DataFromText(string filePath )
        {
            string output;
            try
            {
                using (var sr = new StreamReader(filePath))
                {
                    output = sr.ReadToEnd();
                }
            }
            catch (Exception)
            {
                output = "Error !!!! while reading text File";
            }
            return output;
        }
    }
}