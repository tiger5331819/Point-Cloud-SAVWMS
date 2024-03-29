﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SAVWMS
{

    [Serializable]
    public struct IPList
    {
        public string ID;
        public string IP;
    }

    public class Manager
    {
        public UserData Data;
        public IPList[] iplist = new IPList[20];
        public IPList[] getiplist
        {
            get { return iplist; }
        }
        string EVCSversion;
        string Volumeversion;
        public string EVCSv
        {
            get { return EVCSversion; }
            set { EVCSversion = value; }
        }
        public string Volumev
        {
            get { return Volumeversion; }
            set { Volumeversion = value; }
        }
        
        //public DataChangeTODO changeTODO;
        public UserNet cloudnet;


        
        public Manager()
        {
            manager = this;
            this.Data = new UserData();
            loadxml();
            for (int i = 0; i < 20; i++)
            {
                iplist[i].ID = null;
                iplist[i].IP = null;
            }
           
            cloudnet = new UserNet(ref Data, ref manager);
            //this.changeTODO = new DataChangeTODO(ref Data, ref cloud);

        }
        public Manager manager;

        public void loadxml()
        {
            //将XML文件加载进来
            XDocument document = XDocument.Load("config.xml");
            //获取到XML的根元素进行操作
            XElement root = document.Root;

            XElement Device = root.Element("Device");
            XElement ID = Device.Element("ID");
            Data.ID = ID.Value;

            XElement version = Device.Element("EVCSversion");
            EVCSversion = version.Value;
            version = Device.Element("Volumeversion");
            Volumeversion = version.Value;


            XElement NetLink = root.Element("NetLink");
            XElement IP = NetLink.Element("IP");
            XElement server = IP.Element("server");

            Data.ip.IP = server.Value;
            XElement Point = IP.Element("serverpoint");
            Data.ip.Point = int.Parse(Point.Value);



            //获取根元素下的所有子元素
            IEnumerable<XElement> ele = root.Elements("time");
            IEnumerable<XElement> enumerable = ele.Elements();
            int i = 0;
            foreach (XElement item in enumerable)
            {
                Data.configtime[i].time = item.Name.ToString();
                XElement timefind = item.Element("beginhour");
                Data.configtime[i].beginhour = timefind.Value;
                timefind = item.Element("beginminute");
                Data.configtime[i].beginminute = timefind.Value;
                timefind = item.Element("endhour");
                Data.configtime[i].endhour = timefind.Value;
                timefind = item.Element("endminute");
                Data.configtime[i].endminute = timefind.Value;
                i++;
            }
        }

        public void writexml()
        {
            //获取根节点对象
            XDocument document = new XDocument();
            XElement root = new XElement("EVCS");

            XElement Device = new XElement("Device");
            XElement ID = new XElement("ID");
            ID.Value = Data.ID;

            XElement EVCSv = new XElement("EVCSversion");
            EVCSv.Value = EVCSversion;
            Device.Add(EVCSv);
            XElement version = new XElement("Volumeversion");
            version.Value = Volumeversion;
            Device.Add(version);

            root.Add(Device);

            XElement NetLink = new XElement("NetLink");
            XElement IP = new XElement("IP");
            IP.SetElementValue("server", Data.ip.IP);
            IP.SetElementValue("serverpoint", Data.ip.Point);
            NetLink.Add(IP);
            root.Add(NetLink);

            XElement time = new XElement("time");

            foreach (configtimexml x in Data.configtime)
            {
                XElement addtime = new XElement(x.time);
                addtime.SetElementValue("beginhour", x.beginhour);
                addtime.SetElementValue("beginminute", x.beginminute);
                addtime.SetElementValue("endhour", x.endhour);
                addtime.SetElementValue("endminute", x.endminute);
                time.Add(addtime);
            }

            root.Add(time);
            root.Save("config.xml");
        }
    }
}
