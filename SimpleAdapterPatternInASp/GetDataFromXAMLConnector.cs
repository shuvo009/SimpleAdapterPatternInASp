using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleAdapterPatternInASp
{
    public class GetDataFromXAMLConnector :GetMyData
    {
        public override string GetDataInString(string filePath)
        {
            var data = new GeteDataFromXML();
            return data.DataFromXaml(filePath);
        }
    }
}