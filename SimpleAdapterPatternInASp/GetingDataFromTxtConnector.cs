using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleAdapterPatternInASp
{
    public class GetingDataFromTxtConnector : GetMyData
    {
        public override string GetDataInString(string filePath)
        {
            var textData = new GateDataFromTextFile();
            return textData.DataFromText(filePath);
        }
    }
}