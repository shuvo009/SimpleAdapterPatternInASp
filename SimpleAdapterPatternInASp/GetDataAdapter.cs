using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleAdapterPatternInASp
{
    public class GetDataAdapter
    {
        public string GetMyDataUsingAdapter(GetMyData getMyData,string filePath)
        {
            return getMyData.GetDataInString(filePath);
        }
    }
}