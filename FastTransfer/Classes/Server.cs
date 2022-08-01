using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Windows;

namespace FastTransfer.Classes
{
	public class Server
	{
        static TcpListener server = null;
        static TcpClient client = null;
        static Stream Stream = null;
        static int Size;
        static string Name;
        static string Path;
        static byte[] BufferSize;



        public async static void OpenPort(int port)
        {
            try
            {
                server = new TcpListener(IPAddress.Loopback, port);
                server.Start();
                client = await server.AcceptTcpClientAsync();
                Stream = client.GetStream();
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message, "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public static void NameAndSize(string path)
        {
            Byte[] nameAndSize = new byte[32];
            Stream.Read(nameAndSize, 0, nameAndSize.Length);
            string nameSize = Encoding.UTF8.GetString(nameAndSize).Trim('\0');
            string[] name = nameSize.Split('!');
            File.Create(path + name[0]);

            Path = path;
            Size = Convert.ToInt32(name[1]);
        }

        public static void Content()
        {
            byte[] content = new byte[Size];
            Stream.Read(content, 0, content.Length);
            File.WriteAllBytes(Path + Name[0], content);
        }

        public static void ClosePort()
        {          
            server.Stop();
        }

    }
}