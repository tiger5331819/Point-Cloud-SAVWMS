using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAVWMS
{
    public class UserData : TypeData
    {
        public NetIP ip;
        public string IP;
        public string DeviceID;
        public bool Live = false;

        public UserData()
        {
            DeviceID = null;
            ip = new NetIP();
        }
        public bool newdatachange()
        {
            if (flag)
                return true;
            else return false;
        }
    }
    public class UserNet : NetData
    {
        UserData Data;
        IPAddress ip;
        IPEndPoint point;
        Manager manager;
        bool connectflag = true;

        public UserNet(ref UserData data, ref Manager m)
        {
            typenet = TypeNet.CenterSever;
            ip = IPAddress.Parse(data.ip.IP);
            point = new IPEndPoint(ip, data.ip.Point);
            manager = m;
            Data = data;

            Thread connect = new Thread(userconnect);
            connect.IsBackground = true;
            connect.Start();
        }

        /// <summary>
        /// 创建一个服务器socket对象，走到监听端口这一步，新建线程，并将服务器socket对象传递过去，
        /// 用于实时创建连接的客户端socket
        /// </summary>
        /// <returns></returns>
        public void userconnect()
        {
            while (true)
            {
                if (connectflag)
                {
                    try
                    {
                        socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        socket.Connect(point);
                        Thread.Sleep(1000);
                        MessageBox.Show("发送第一次");

                        Send(UserDataToPackage(Data, Messagetype.codeus));


                        MessageBox.Show("发送成功");
                        Thread waitcommand = new Thread(ReceiveMsg);
                        waitcommand.IsBackground = true;
                        waitcommand.Start(socket);
                        //MessageBox.Show("Link server");
                        connectflag = false;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else Thread.Sleep(5000);
            }
        }

        void ReceiveMsg(object o)
        {
            Socket client = o as Socket;

            void ipinfo()
            {
                byte[] buf = new byte[1024 * 1024];

                client.Receive(buf);
                Package package = BytesToPackage(buf);
                if (package.message == Messagetype.codeus)
                    ReceiveIPList(package);

            }
            ipinfo();

            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024 * 1024];
                    int n = client.Receive(buffer);
                    Package package = BytesToPackage(buffer);
                    switch (package.message)
                    {
                        case Messagetype.package:
                            PackageToUserData packageToData = new PackageToUserData(NewUserData);
                            packageToData(package); break;
                        
                        case Messagetype.codeus: ReceiveIPList(package); break;
                    }
                }
                catch (Exception ex)
                {
                    
                    connectflag = true;
                    break;
                }
            }
        }


        public void ReceiveIPList(Package package)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(package.data, 0, package.data.Length);
                ms.Flush();
                ms.Position = 0;
                BinaryFormatter bf = new BinaryFormatter();
                manager.iplist = (IPList[])bf.Deserialize(ms);
            }
        }

        public Package UpdateIPList()
        {
            Package package = new Package();
            package.message = Messagetype.codeus;
            package.data = Encoding.UTF8.GetBytes("-1");
            return package;
        }

        public Package CreatCodeToPackage(Codemode codemode)
        {
            Package package = new Package();
            package.message = Messagetype.order;
            switch (codemode)
            {
                case Codemode.stop: package.data = Encoding.UTF8.GetBytes("0"); break;
                case Codemode.play: package.data = Encoding.UTF8.GetBytes("1"); break;
                case Codemode.monitor: package.data = Encoding.UTF8.GetBytes("2"); break;
                case Codemode.sendvolume: package.data = Encoding.UTF8.GetBytes("3"); break;
                case Codemode.stopsendvolume: package.data = Encoding.UTF8.GetBytes("4"); break;
                case Codemode.release: package.data = Encoding.UTF8.GetBytes("-1"); break;
            }
            return package;
        }
        /// <summary>
        /// example
        /// </summary>
        /// <param name="package"></param>
        void NewUserData(Package package)
        {
            UserData data = new UserData();
            data.datatype = Datatype.User;
            using (MemoryStream ms = new MemoryStream())
            {
                ms.Write(package.data, 0, package.data.Length);
                ms.Flush();
                ms.Position = 0;
                BinaryFormatter bf = new BinaryFormatter();
                Data = (UserData)bf.Deserialize(ms);

                //Data.messagetype = package.message;
                //Data.flag = true;              
            }
        }
        
    }


}

