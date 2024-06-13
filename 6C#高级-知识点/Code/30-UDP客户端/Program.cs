using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace _30_UDP客户端
{
    class Program
    {
        static void Main(string[] args)
        {

            Socket udpClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            byte[] data = Encoding.UTF8.GetBytes("你好，udp客户端上线了");

            IPAddress ipAddress = new IPAddress(new byte[] { 192, 168, 31, 17 });
            // IP + Port
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 7788);

            udpClient.SendTo(data, ipEndPoint);


            udpClient.Close();
        }
    }
}
