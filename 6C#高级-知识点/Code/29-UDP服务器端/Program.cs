using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace _29_UDP服务器端
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Socket udpServer = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            IPAddress ipAddress = new IPAddress(new byte[] { 192, 168, 31, 17 });
            // IP + Port
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 7788);

            udpServer.Bind(ipEndPoint);

            IPEndPoint ipep = new IPEndPoint( IPAddress.Any, 0);
            EndPoint ep = (EndPoint)ipep; 
            byte[] data = new byte[1024];
            int length = udpServer.ReceiveFrom(data, ref ep);
            
            Console.WriteLine("接收到数据：" + Encoding.UTF8.GetString(data, 0, length));

            udpServer.Close();
        }
    }
}
