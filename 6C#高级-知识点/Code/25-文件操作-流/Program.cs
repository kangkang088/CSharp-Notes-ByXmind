using System;
using System.IO;

namespace _25_文件操作_流
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime before = DateTime.Now;
            FileStream readFileStream = new FileStream(@"E:\VS Workspace\file.zip",FileMode.Open,FileAccess.Read);

            //readFileStream.ReadByte();

            FileStream writeFileStream = new FileStream(@"E:\VS Workspace\fileCopy.zip",FileMode.Create,FileAccess.Write);

            //writeFileStream.WriteByte();
            //int nextByte = -1;
            //while( (nextByte=readFileStream.ReadByte()) != -1)
            //{
            //    writeFileStream.WriteByte((byte)nextByte);
            //}

            int length = 1024;

            byte[] buffer = new byte[length];
            int count = -1;
            //int count = readFileStream.Read(buffer, 0, 1024);

            //writeFileStream.Write(buffer, 0, count);
            while( (count = readFileStream.Read(buffer, 0, length))!=0)
            {
                writeFileStream.Write(buffer, 0, count);
            }


            writeFileStream.Close();
            readFileStream.Close();
            DateTime after = DateTime.Now;

            TimeSpan ts = after.Subtract(before);
            Console.WriteLine(ts.TotalMilliseconds);
        }
    }
}
