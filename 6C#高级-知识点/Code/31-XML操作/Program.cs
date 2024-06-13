using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace _31_XML操作
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Skill> list = new List<Skill>();
            XmlDocument xmlDoc = new XmlDocument();

            //xmlDoc.Load("Skills.xml");
            xmlDoc.LoadXml(File.ReadAllText("Skills.xml"));
            

            XmlNode root = xmlDoc.ChildNodes[1];
            XmlNodeList skillList = root.ChildNodes;
            foreach(XmlNode skill in skillList)
            {
                Skill skillObj = new Skill();
                //foreach(XmlNode node in skill.ChildNodes)
                //{
                //    //Console.WriteLine(node.Name + ":" + node.InnerText);
                //    if (node.Name == "id")
                //    {
                //        ;
                //    }else if (node.Name == "name")
                //    {
                //        skillObj.Name = node.InnerText;
                //        skillObj.Lang = node.Attributes[0].Value;
                //    }else
                //    {
                //        skillObj.Damage = Int32.Parse(node.InnerText);
                //    }
                //}

                XmlElement idEle = skill["id"];
                skillObj.ID = Int32.Parse(idEle.InnerText);

                XmlElement nameEle = skill["name"];
                skillObj.Name = nameEle.InnerText;

                XmlAttributeCollection attriCol = nameEle.Attributes;
                XmlAttribute attri = attriCol["lang"];
                skillObj.Lang = attri.Value;

                XmlElement damageEle = skill["damage"];
                skillObj.Damage = Int32.Parse(damageEle.InnerText);

                list.Add(skillObj);
            }

            foreach(Skill s in list)
            {
                Console.WriteLine(s.ID + "," + s.Name + "," + s.Lang + "," + s.Damage);
            }
        }
    }
}
