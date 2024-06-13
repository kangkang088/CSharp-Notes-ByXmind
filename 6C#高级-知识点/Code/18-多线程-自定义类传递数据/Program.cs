using System;
using System.Threading;

namespace _18_多线程_自定义类传递数据
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DownloadTool downloadTool = new DownloadTool("httpwx.xxxx/xx/xx","sdfsfd");
            Thread t = new Thread(downloadTool.Download);
            t.Start();
        }
    }
}
