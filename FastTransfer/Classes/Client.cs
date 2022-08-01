using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using System.Net;


namespace FastTransfer.Classes
{
    internal class Client
    {
        static TcpClient client = new TcpClient();
        static Stream Stream = null;
        static string Ip;
        static int Port;

        internal static void Connect(string ip, int port)
        {
            Ip = ip;
            Port = port;
            client.Connect(Ip, Port);
        }

        internal static void SendNameSize(string file)
        {
            FileInfo fi = new FileInfo(file);
            byte[] fileNameSize = Encoding.ASCII.GetBytes(fi.Name + "!" + fi.Length);
            Stream = client.GetStream();
            Stream.Write(fileNameSize, 0, fileNameSize.Length);
            Stream.Close();
        }

        internal static void SendFile(string file)
        {
            FileInfo fi = new FileInfo(file);
            byte[] content = File.ReadAllBytes(fi.FullName);
            Stream = client.GetStream();
            Stream.Write(content, 0, content.Length);
            Stream.Close();
        }

    }        
}
