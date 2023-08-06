#region Copyright

#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Silver_J
{
    public partial class RemoveAddedFilesToProject_Form : Form
    {
        public RemoveAddedFilesToProject_Form()
        {
            InitializeComponent();
        }

        String defaultprojfilepath = Application.StartupPath + "\\files\\defaultprojloc.slvjfile";

        public String ReadCurrentProjectFileName()
        {
            String s = "";

            using (XmlReader reader = XmlReader.Create(defaultprojfilepath))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name.ToString())
                        {
                            case "CurrentProjectFileName":
                                s = reader.ReadString();
                                break;
                        }
                    }
                }
            }
            return s;
        }



        // Return the project location folder : 

        public String getCurrentProjectLocationFolder()
        {
            // Get The name from the first function : ReadCurrentProjectFileName()

            String projectfile = ReadCurrentProjectFileName();

            String projectlocationfolder = "";

            if (File.Exists(projectfile))
            {
                using (XmlReader reader = XmlReader.Create(projectfile))
                {
                    while (reader.Read())
                    {
                        if (reader.IsStartElement())
                        {
                            switch (reader.Name.ToString())
                            {
                                case "ProjectLocationFolder":
                                    projectlocationfolder = reader.ReadString();
                                    break;
                            }
                        }
                    }
                }
            }
            return projectlocationfolder;
        }


        // If there is an existing files with same name the systeme will show a notification of overloading 

        private void RemoveAddedFilesToProject_Form_Load(object sender, EventArgs e)
        {
            String projectfile = ReadCurrentProjectFileName();

            if (File.Exists(projectfile))
            {
                using (XmlReader reader = XmlReader.Create(projectfile))
                {
                    while (reader.Read())
                    {
                        if (reader.IsStartElement())
                        {
                            switch (reader.Name.ToString())
                            {
                                case "OtherFile":
                                    listBox1.Items.Add(reader.ReadString());
                                    break;
                            }
                        }
                    }
                }
            }
        }



        private void RemoveButton_Click(object sender, EventArgs e)
        {
            String projectfile = ReadCurrentProjectFileName();

            if (listBox1.SelectedIndex > 0)
            {
                ListBox.SelectedObjectCollection items = listBox1.SelectedItems;
                
                foreach(Object item in items)
                {
                    if(File.Exists(item.ToString()))
                    {
                        File.Delete(item.ToString());

                        XmlDocument doc = new XmlDocument();
                        doc.Load(projectfile);
                        XmlNodeList nodes = doc.GetElementsByTagName("OtherFile");
                        for (int i = 0; i < nodes.Count; i++)
                        {
                            XmlNode node = nodes[i];
                            if (node.InnerText == item.ToString())
                            {
                                node.ParentNode.RemoveChild(node);
                            }
                        }
                        doc.Save(projectfile);
                    }
                }
            }

            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
