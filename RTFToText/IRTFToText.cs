using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTFToTextConverter
{
    public interface IRTFToText
    {
        string rtfFromString(string rtfString);
        string rtfFromFile(string pathWithFileName);
    }
}
