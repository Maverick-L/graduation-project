using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
namespace LFrameStudy
{
    public class TaskManager : MonoBehaviour
    {
        private void Start()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(@"E:\Unity\graduation-project\graduation-project\Assets\LFrameStudy\5.任务系统\TaskXML");
            //读取Task节点的所有属性
            XmlNodeList childlist = xml.SelectNodes("//Task");
     foreach(XmlNode xn in childlist)
            {
                //可以用来判断是第几个任务
                if (xn.SelectSingleNode("TaskID").InnerText == "1")
                {
                    Debug.Log(xn.SelectSingleNode("TaskID").InnerText);
                    Debug.Log(xn.SelectSingleNode("任务介绍").InnerText);
                    Debug.Log(xn.SelectSingleNode("任务完成条件").InnerText);

                }
                else
                {
                    Debug.Log("no");
                }
                
              
            }

        }
    }
}
