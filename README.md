# RTFToTextConverter

####RTF from string

```
RichTextBox rtBox = new RichTextBox();
rtBox.Text = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr";

string str = RTFToText.converting().rtfFromString(rtBox.Rtf);
Console.WriteLine(str);
Console.ReadLine();
```

####RTF from file

```
string str = RTFToText.converting().rtfFromFile(@"C:\Custom Library\test.rtf");
Console.WriteLine(str);
Console.ReadLine();
```
