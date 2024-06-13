using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TCP服务器端TcpServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //1234
            // IP  192.168.1.145  Port端口号  内网=局域网 外网
            //网络地址 
            //城市 路 小区 单元 xx    小明收
            //城市 路 小区 单元 xx 
            // xx楼 x单元 xx
            Socket tcpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPAddress ipAddress = new IPAddress(new byte[] { 192,168,31,17 });
            // IP + Port
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 7788);

            tcpServer.Bind(ipEndPoint);

            tcpServer.Listen(100);

            Console.WriteLine("开始接客了 ...");
            Socket client = tcpServer.Accept();
            Console.WriteLine("一个客户端链接过来了");
            byte[] data = new byte[1024];
            int length = client.Receive(data);
            string message = Encoding.UTF8.GetString(data, 0, length);
            Console.WriteLine("接收到了客户端的消息：" + message);

            client.Send(Encoding.UTF8.GetBytes("来了，随便座"));


            client.Close();

            tcpServer.Close();
        }
    }
}
