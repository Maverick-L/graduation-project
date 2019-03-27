using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;

namespace LFrameStudy
{
    public class XML : MonoBehaviour
    {
        private void Start()
        {
            XmlDocument Xml = new XmlDocument();
            try
            {
                Xml.Load(@"E:\Unity\graduation-project\graduation-project\Assets\LFrameStudy\5.任务系统\TaskXML");
            }
            catch
            {

                CreateXML();

            }


        }

        public void CreateXML()
        {
            XmlDocument Taskxml = new XmlDocument();
            XmlDeclaration decl = Taskxml.CreateXmlDeclaration("1.0", "utf-8", null);
            Taskxml.AppendChild(decl);

            XmlElement root = Taskxml.CreateElement("任务列表");
            Taskxml.AppendChild(root);

            //创建第一个任务
            XmlElement rootEle = Taskxml.CreateElement("Task");
            root.AppendChild(rootEle);

            XmlElement childEle = Taskxml.CreateElement("TaskID");
            childEle.InnerText = "1";
            rootEle.AppendChild(childEle);

            XmlElement c2Ele = Taskxml.CreateElement("任务介绍");
            c2Ele.InnerText = "杀敌数超过80";
            childEle.AppendChild(c2Ele);

            XmlElement c3Ele = Taskxml.CreateElement("任务完成条件");
            c3Ele.InnerText = "80";
            rootEle.AppendChild(c3Ele);

            //创建第二个任务

            rootEle = Taskxml.CreateElement("Task");
            root.AppendChild(rootEle);

            childEle = Taskxml.CreateElement("TaskID");
            childEle.InnerText = "2";
            rootEle.AppendChild(childEle);

            c2Ele = Taskxml.CreateElement("任务介绍");
            c2Ele.InnerText = "时间不超过90s";
            rootEle.AppendChild(c2Ele);

            c3Ele = Taskxml.CreateElement("任务完成条件");
            c3Ele.InnerText = "90";
            rootEle.AppendChild(c3Ele);

            //保存任务
            Taskxml.Save(@"E:\Unity\graduation-project\graduation-project\Assets\LFrameStudy\5.任务系统\TaskXML");
            print("ok");
        }
    }
}
