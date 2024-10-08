using System;
using System.IO;

public class PathSnippets
{
	public void GetRelativePath()
	{
        // <Snippet1>
		// "C:/Program Files/Microsoft" relative to "C:/Program Files/Common Files" is "../Microsoft"
		Console.WriteLine(Path.GetRelativePath("C:/Program Files/Common Files", "C:/Program Files/Microsoft"));
		// "C:/Program Files/Microsoft" relative to "C:/Program Files/" is "Microsoft"
		Console.WriteLine(Path.GetRelativePath("C:/Program Files/", "C:/Program Files/Microsoft"));

        // This code produces output similar to the following:
        //
        // ../Microsoft
        // Microsoft
        // </Snippet1>
	}
}
