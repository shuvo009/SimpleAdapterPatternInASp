using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleAdapterPatternInASp
{
    public abstract class GetMyData
    {
        public abstract string GetDataInString(string filePath);
    }
}