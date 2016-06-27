using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RTFToTextConverter;
using System.Windows.Forms;

namespace RTFTestTool
{
    class Program
    {
        static void Main(string[] args)
        {
            RichTextBox rtBox = new RichTextBox();
            rtBox.Text = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr";

            string str = RTFToText.converting().rtfFromString(rtBox.Rtf);
            Console.WriteLine(str);
            Console.ReadLine();


            string str1 = RTFToText.converting().rtfFromFile(@"C:\Custom Library\test.rtf");
            Console.WriteLine(str1);
            Console.ReadLine();
        }
    }
}
