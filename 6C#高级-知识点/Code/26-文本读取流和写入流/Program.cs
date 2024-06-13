using System;
using System.IO;

namespace _26_文本读取流和写入流
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string sourceFile = @"E:\VS Workspace\第四季-高级篇\26-文本读取流和写入流\TextFile1.txt";
            //StreamReader reader = new StreamReader(sourceFile);

            ////FileStream fs = new FileStream(sourceFile,FileMode.Open);
            ////StreamReader reader = new StreamReader(fs);

            ////FileInfo myFile = new FileInfo(sourceFile);
            ////myFile.OpenText();
            ////string line = reader.ReadLine();
            ////Console.WriteLine(line);

            ////string line = null;

            ////while( (line = reader.ReadLine())!=null)
            ////{
            ////    Console.WriteLine(line);
            ////}

            ////reader.ReadToEnd();

            //reader.Read();
            //char[] buffer = new char[1024];
            //reader.Read(buffer, 0, 1024);

            //reader.Close();

            //Stream

            string sourceFile = @"E:\VS Workspace\第四季-高级篇\26-文本读取流和写入流\TextFile1.txt";
            string destinationFile = @"E:\VS Workspace\第四季-高级篇\26-文本读取流和写入流\TextFileCopy.txt";
            StreamReader reader = new StreamReader(sourceFile);
            StreamWriter writer = new StreamWriter(destinationFile,true);

            string line = null;
            while( (line = reader.ReadLine())!=null)
            {
                writer.WriteLine(line);
            }
            writer.Close();
            reader.Close();

        }
    }
}
