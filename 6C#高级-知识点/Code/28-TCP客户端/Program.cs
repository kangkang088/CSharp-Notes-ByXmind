using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace _28_TCP客户端
{
    class Program
    {
        static void Main(string[] args)
        {

            Socket tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPAddress ipAddress = new IPAddress(new byte[] { 192, 168, 31, 17 });
            // IP + Port
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 7788);

            tcpClient.Connect(ipEndPoint);
            Console.WriteLine("链接上服务器端了");

            string message = "我上线了";
            tcpClient.Send(Encoding.UTF8.GetBytes(message));

            byte[] data = new byte[1024];
            int length = tcpClient.Receive(data);



            Console.WriteLine("收到服务器端的消息："+Encoding.UTF8.GetString(data, 0, length));

            tcpClient.Close();
        }
    }
}
