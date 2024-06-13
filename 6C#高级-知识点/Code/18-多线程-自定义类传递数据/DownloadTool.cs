using System;
using System.Collections.Generic;
using System.Text;

namespace _18_多线程_自定义类传递数据
{
    internal class DownloadTool
    {
        public string URL { get;private set; }
        public string Message { get;private set; }

        public DownloadTool(string uRL, string message)
        {
            URL = uRL;
            Message = message;
        }
        public void Download()
        {
            Console.WriteLine("从"+URL+"下载中 ...");
        }
    }
}
