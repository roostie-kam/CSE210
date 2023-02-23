using System;

class Program
{
    static void Main(string[] args)
    {
        TextRemover remover = new TextRemover();
        string originalText = Scripture Test 1,2,3,34343,asdasdasd
        remover.SetOriginalText(originalText);
        string modifiedText = remover.GetModifiedText();
        Console.WriteLine("Original text:" + originalText);
        Console.WriteLine("Modified text:" + modifiedText);
    }
}