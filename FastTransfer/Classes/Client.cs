using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Windows.Forms;


namespace FastTransfer.Classes
{
    internal class Client
    {
        private static TcpClient TClient = new TcpClient();
        private static Stream Stream;
        private static FileInfo File;
        private static string Ip;
        private static int Port;

        internal static bool Connect(string ip, int port)
        {
            Ip = ip;
            Port = port;
            try
            {
                if (!TClient.Connected)
                {
                    TClient.Connect(Ip, Port);
                    return true;
                }
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message, "Erro ao se conectar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return false;
        }
        internal static bool Disconnect()
        {
            if (TClient.Connected)
            {
                TClient.Close();
                TClient = new TcpClient();
                return true;
            }
            return false;
        }


        internal static void SendNameSize(string file)
        {
            File = new FileInfo(file);
            byte[] fileNameSize = Encoding.ASCII.GetBytes(File.Name + "!" + File.Length);
            Stream = TClient.GetStream();
            Stream.Write(fileNameSize, 0, fileNameSize.Length);
        }

        internal static void SendFile()
        {
            byte[] content = System.IO.File.ReadAllBytes(File.FullName);
            Stream = TClient.GetStream();
            Stream.Write(content, 0, content.Length);
        }

    }        
}
