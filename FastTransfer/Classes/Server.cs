using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Windows;
using FastTransfer.Classes;

namespace FastTransfer.Classes
{
	public class Server
	{
        private static TcpListener Listener = null;
        private static TcpClient Client = new TcpClient();
        private static Stream Stream = null;
        private static int BufferSize;
        private static string[] NameSize;
        private static string Path;

        public static void OpenPort(int port)
        {
            try
            {
                Listener = new TcpListener(IPAddress.Loopback, port);
                Listener.Start();
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message, "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public static void ClosePort()
        {
            Listener.Stop();
        }

        public static async void NameAndSize(string path)
        {
            Client = await Listener.AcceptTcpClientAsync();
            Stream = Client.GetStream();
            byte[] namesize = new byte[256];
            await Stream.ReadAsync(namesize, 0, namesize.Length);

            NameSize = Encoding.UTF8.GetString(namesize).Split('!', '\0');
            Path = path + NameSize[0];
            File.Create(Path).Close();

            BufferSize = Convert.ToInt32(NameSize[1]);
            Classes.Client.SendFile();
            Content();
        }

        public static void Content()
        {
            byte[] content = new byte[BufferSize];
            Stream = Client.GetStream();
            Stream.Read(content, 0, content.Length);
            File.WriteAllBytes(Path, content);
        }


    }
}