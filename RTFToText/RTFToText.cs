using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTFToTextConverter
{
    public class RTFToText : IRTFToText
    {
        private static RTFToText _rtftoTextLocator;
        private static object _lockThis = new object();

        private RichTextBox rtBox = new RichTextBox();

        private RTFToText()
        {

        }

        public static RTFToText converting()
        {
            lock(_lockThis)
            {
                if (_rtftoTextLocator == null)
                    _rtftoTextLocator = new RTFToText();
            }

            return _rtftoTextLocator;
        }

        public string rtfFromFile(string pathWithFileName)
        {
            string result = null;

            try
            {
                string rtfText = File.ReadAllText(pathWithFileName);
                rtBox.Rtf = rtfText;
                result = rtBox.Text;
            }
            catch(Exception ex)
            {
                throw new FileNotFoundException("[" + pathWithFileName + "]", ex);
            }

            return result;
        }

        public string rtfFromString(string rtfString)
        {
            string result = null;

            try
            {
                rtBox.Rtf = rtfString;
                result = rtBox.Text;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }
    }
}
