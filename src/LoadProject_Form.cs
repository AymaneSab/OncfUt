#region Copyright
/***************************************************************************************
 ******Copyright (C) 2016 Pritam Zope*****
 
  <copyright file="New_JavaApplicationProject_Form.cs" company="">
  
 {-  Program Name = Silver-J
      An Integrated Development Environment(IDE) for Java Programming
      Language written In C#   -}  
 
   This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
  
   Please credit me if you reuse, don't sell it under your own name, don't pretend you're me
  </copyright>
  * ****************************************************************************************/
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Diagnostics;
namespace Silver_J
{

    public partial class LoadProject_Form : Form
    {
        public Form frm;
        public TreeView treeview;
        public MyTabControl mytabcontrol;

        public LoadProject_Form(Form F)
        {
            InitializeComponent();
            frm = F;

        }


        static Boolean isSaved = false;
        String projectfilename = "";
        String createdfilename = "";
        public Boolean isfinished = false;

        public static Boolean isinvalidcharcontain = false;
        public String invalidchar = "";
        public static Boolean islocinvalidcharcontain = false;
        public String locinvalidchar = "";
        public static Boolean isclassinvalidcharcontain = false;
        public String classinvalidchar = "";
        String defaultprojfilepath = Application.StartupPath + "\\files\\defaultprojloc.slvjfile";

        public StreamReader strreader;
        public StreamWriter strwriter;


        public String getCreatedFileName()
        {
            if (createdfilename == "")
            {
                createdfilename = "";
            }
            return createdfilename;
        }

        public Boolean IsFinished()
        {
            return isfinished;
        }

        /*
        public String projloc;
        public String projfolder;
        public String projectname;
        public String projectfile;
        public void LoadDirectory(string Dir)
        {
            DirectoryInfo di = new DirectoryInfo(Dir);
            //Setting ProgressBar Maximum Value  
            LoadFiles(Dir);
        }

        private void LoadFiles(string dir)
        {
            string[] Files = Directory.GetFiles(dir);

             projloc = ProjectLocationTextBox.Text;
             projfolder = projectfolderlabel.Text;
             projectname = ProjectNameTextBox.Text;

             projectfile = projectname + ".slvjproj";

            if (Directory.Exists(projloc + "\\" + projfolder))
            {
                MessageBox.Show("Entered project name folder is already exists in current location", "Error............");
            }

            String sourcePath = dir;
            String srccclasses = projloc + "\\" + projfolder + "\\srcclasses" ;

            //create project directory & project file
            Directory.CreateDirectory(projloc + "\\" + projfolder);
            //create srcclasses directory
            Directory.CreateDirectory(srccclasses);
            //create classes directory
            Directory.CreateDirectory(projloc + "\\" + projfolder + "\\classes");

            //creating & writing slvjproj file 
            using (XmlWriter xmlwriter = XmlWriter.Create(projloc + "\\" + projfolder + "\\" + projectfile))
            {
                xmlwriter.WriteStartDocument();
                xmlwriter.WriteStartElement("SilverJProject");
                xmlwriter.WriteString("\n");
                xmlwriter.WriteComment("Silver-J (1.0) Java Application Project");
                xmlwriter.WriteString("\n");
                xmlwriter.WriteElementString("ProjectName", projectname);
                xmlwriter.WriteString("\n");
                xmlwriter.WriteElementString("ProjectLocationFolder", projloc + "\\" + projfolder);
                xmlwriter.WriteString("\n");
                xmlwriter.WriteElementString("ProjectLocationFile", projloc + "\\" + projfolder + "\\" + projectfile);
                xmlwriter.WriteString("\n");
                xmlwriter.WriteElementString("ProjectType", "ApplicationType");

                foreach (String file in Files)
                {
                    FileInfo fi = new FileInfo(file);

                    String classname = fi.Name;

                    String javafilename = classname;

                    // Adding Files To srcClasses Directory .

                   
                        // Copy the files and overwrite destination files if they already exist.
                      
                            // Use static Path methods to extract only the file name from the path.

                         String fileName = System.IO.Path.GetFileName(fi.Name);
                         String    destFile = System.IO.Path.Combine(srccclasses, fileName);
                         System.IO.File.Copy(file, destFile, true);
                   


                    String fname = projloc + "\\" + projfolder + "\\srcclasses\\" + javafilename;

                    createdfilename = fname;
                    String filename = fname.Substring(fname.LastIndexOf("\\") + 1);

                    xmlwriter.WriteString("\n");
                    xmlwriter.WriteElementString("JavaClassFile", fname);
                    xmlwriter.WriteString("\n");
                    xmlwriter.WriteElementString("VisualFile", fname);
                   
                }
                xmlwriter.WriteEndElement();
                xmlwriter.WriteEndDocument();
                xmlwriter.Close();

                isSaved = true;

                String defaultprojfilepath = Application.StartupPath + "\\files\\defaultprojloc.slvjfile";


                projectfilename = projloc + "\\" + projfolder + "\\" + projectfile;

                XmlDocument doc = new XmlDocument();
                doc.Load(defaultprojfilepath);
                doc.SelectSingleNode("SilverJ/DefaultProjectLocation").InnerText = ProjectLocationTextBox.Text;
                doc.SelectSingleNode("SilverJ/CurrentProjectName").InnerText = ProjectNameTextBox.Text;
                doc.SelectSingleNode("SilverJ/CurrentProjectFileName").InnerText = projectfilename;
                doc.SelectSingleNode("SilverJ/CurrentProjectType").InnerText = "ApplicationType";
                doc.Save(defaultprojfilepath);


                this.Close();
                isfinished = true;


            }
        }

        public void CreateJavaProject()
        {
             projloc = ProjectLocationTextBox.Text;
             projfolder = projectfolderlabel.Text;
             projectname = ProjectNameTextBox.Text;

            LoadDirectory(projloc);
        }*/


        public String projloc;
        public String projfolder;
        public String projectname;
        public String projectfile;

        /*
        public void   LoadDirectory(string Dir)
        {

            projloc = ProjectLocationTextBox.Text;
            projfolder = projectfolderlabel.Text;
            projectname = ProjectNameTextBox.Text;
            projectfile = projectname + ".slvjproj";


            String srccclasses = projloc + "\\" + projfolder + "\\srcclasses";

            //create project directory & project file
            Directory.CreateDirectory(projloc + "\\" + projfolder);
            //create srcclasses directory
            Directory.CreateDirectory(srccclasses);
            //create classes directory
            Directory.CreateDirectory(projloc + "\\" + projfolder + "\\classes");

            using (XmlWriter xmlwriter = XmlWriter.Create(projloc + "\\" + projfolder + "\\" + projectfile))
            {

                xmlwriter.WriteStartDocument();
                xmlwriter.WriteStartElement("SilverJProject");
                xmlwriter.WriteString("\n");
                xmlwriter.WriteComment("Silver-J (1.0) Java Application Project");
                xmlwriter.WriteString("\n");
                xmlwriter.WriteElementString("ProjectName", projectname);
                xmlwriter.WriteString("\n");
                xmlwriter.WriteElementString("ProjectLocationFolder", projloc + "\\" + projfolder);
                xmlwriter.WriteString("\n");
                xmlwriter.WriteElementString("ProjectLocationFile", projloc + "\\" + projfolder + "\\" + projectfile);
                xmlwriter.WriteString("\n");
                xmlwriter.WriteElementString("ProjectType", "ApplicationType");
                xmlwriter.WriteEndElement();
                xmlwriter.WriteEndDocument();
                xmlwriter.Close();

                isSaved = true;

                String defaultprojfilepath = Application.StartupPath + "\\files\\defaultprojloc.slvjfile";
                projectfilename = projloc + "\\" + projfolder + "\\" + projectfile;

                XmlDocument doc = new XmlDocument();
                doc.Load(defaultprojfilepath);
                doc.SelectSingleNode("SilverJ/DefaultProjectLocation").InnerText = ProjectLocationTextBox.Text;
                doc.SelectSingleNode("SilverJ/CurrentProjectName").InnerText = ProjectNameTextBox.Text;
                doc.SelectSingleNode("SilverJ/CurrentProjectFileName").InnerText = projectfilename;
                doc.SelectSingleNode("SilverJ/CurrentProjectType").InnerText = "ApplicationType";
                doc.Save(defaultprojfilepath);


                this.Close();
                isfinished = true;

            }

            DirectoryInfo di = new DirectoryInfo(Dir);
            //Setting ProgressBar Maximum Value
            //
            LoadSubDirectories(projloc);
            LoadFiles(projloc);

        }

        private void  LoadSubDirectories(string dir)
        {

            DirectoryInfo d1 = new DirectoryInfo(dir);
            // Get all subdirectories  
            string[] subdirectoryEntries = Directory.GetDirectories(dir);
            // Loop through them to see if they have any other subdirectories  

            foreach (string subdirectory in subdirectoryEntries)
            {
                DirectoryInfo d = new DirectoryInfo(subdirectory);

                if (d.Name != projectname)
                {
                    //String packagefolderpath = projloc + "\\" + projfolder + "\\srcclasses\\"  + d.Name;


                    String packagefolderpath = projloc + "\\" + projfolder + "\\srcclasses\\" + d.Parent + "\\" + d.Name;

                    if (projectfilename != "")
                    {
                        XmlDocument xmldoc = new XmlDocument();
                        xmldoc.Load(projectfilename);
                        XmlNode packnamenode = xmldoc.CreateNode(XmlNodeType.Element, "PackageName", null);
                        packnamenode.InnerText = d.Name;
                        xmldoc.DocumentElement.AppendChild(packnamenode);
                        xmldoc.Save(projectfilename);
                    }

                    if (projectfilename != "")
                    {

                        XmlDocument xmldoc = new XmlDocument();
                        xmldoc.Load(projectfilename);
                        XmlNode packfolderpathnode = xmldoc.CreateNode(XmlNodeType.Element, "PackageFolderName", null);
                        packfolderpathnode.InnerText = packagefolderpath;
                        xmldoc.DocumentElement.AppendChild(packfolderpathnode);
                        xmldoc.Save(projectfilename);
                       

                        Directory.CreateDirectory(packagefolderpath);

                    }


                    DirectoryInfo di = new DirectoryInfo(subdirectory);
                    LoadSubDirectories(subdirectory);
                    LoadFiles(subdirectory);

                }

            }

           /* foreach (string subdirectory in subdirectoryEntries)
            {

                DirectoryInfo di = new DirectoryInfo(subdirectory);

                dirName = di.Name;
                dirPath = projloc + "\\" + projfolder + "\\srcclasses\\" + dirName;



                if (di.Name != projectname)
                {

                    Directory.CreateDirectory(dirPath);

                    // LoadSubDirectories(subdirectory);

                    xmlwriter.WriteString("\n");
                    xmlwriter.WriteElementString("PackageName", dirName);
                    xmlwriter.WriteString("\n");
                    xmlwriter.WriteElementString("PackageFolderName", dirPath);


                    string[] Files = Directory.GetFiles(subdirectory);

                    foreach (String file in Files)
                    {
                        FileInfo fi = new FileInfo(file);
                        String classname = fi.Name;
                        String javafilename = classname;


                        // Copy the files and overwrite destination files if they already exist.
                        String fname = projloc + "\\" + projfolder + "\\srcclasses\\" + dirName + "\\" + javafilename;

                        createdfilename = fname;
                        String filename = fname.Substring(fname.LastIndexOf("\\") + 1);

                        xmlwriter.WriteString("\n");
                        xmlwriter.WriteElementString("JavaClassFile", fname);
                        xmlwriter.WriteString("\n");
                        xmlwriter.WriteElementString("VisualFile", fname);

                        // Adding Files To srcClasses Directory .
                        String fileName = System.IO.Path.GetFileName(fi.Name);
                        String destFile = System.IO.Path.Combine(dirPath, file);

                        System.IO.File.Copy(file, destFile, true);

                    }
                }
        }
            }


        public void   LoadFiles(String dir)
        {
            DirectoryInfo d1 = new DirectoryInfo(dir);

            string[] Files = Directory.GetFiles(dir);

            String Parent = projloc.Substring(projloc.LastIndexOf("\\") + 1);

            // Loop through them to see files  
            foreach (string file in Files)
            {
                FileInfo fi = new FileInfo(file);
                String classname = fi.Name;
                String javafilename = classname;


                // Copy the files and overwrite destination files if they already exist.
                // String fname = projloc + "\\" + projfolder + "\\srcclasses\\"  +  d1.Parent  + "\\" + d1.Name + "\\" + javafilename;

                // String fname = projloc + "\\" + projfolder + "\\srcclasses\\"   + d1.Name + "\\" + javafilename;

                String fname = projloc + "\\" + projfolder + "\\srcclasses\\" + d1.Parent + "\\" +  d1.Name + "\\" + javafilename;

                String src = projloc + "\\" + projfolder + "\\" + d1.Parent + "\\" + d1.Name + "\\" + javafilename;

                // String fname = fi.FullName;


                    XmlDocument xmldoc = new XmlDocument();
                    xmldoc.Load(projectfilename);
                    XmlNode packnamenode = xmldoc.CreateNode(XmlNodeType.Element, "VisualFile", null);
                    packnamenode.InnerText = fname;
                    xmldoc.DocumentElement.AppendChild(packnamenode);
                    xmldoc.Save(projectfilename);

                    string fileName = classname;

                   // string sourcePath = d1.FullName  + "\\" + fileName;
                string sourcePath = src;

                string targetPath = fname;

                // Use Path class to manipulate file and directory paths.

                if (!File.Exists(targetPath))
                {
                    System.IO.File.Copy(sourcePath, targetPath);

                }

                // MessageBox.Show(sourcePath, "Inforamtion ");
                // MessageBox.Show(targetPath, "Inforamtion ");              

            }

        }
        */

        public void LoadDirectory()
        {

            projloc = ProjectLocationTextBox.Text;
            projfolder = projectfolderlabel.Text;
            projectname = ProjectNameTextBox.Text;
            projectfile = projectname + ".slvjproj";


            String srccclasses = projloc + "\\" + projfolder + "\\srcclasses\\";

            //create project directory & project file
            Directory.CreateDirectory(projloc + "\\" + projfolder);
            //create srcclasses directory
            Directory.CreateDirectory(srccclasses);
            //create classes directory
            Directory.CreateDirectory(projloc + "\\" + projfolder + "\\classes");

            using (XmlWriter xmlwriter = XmlWriter.Create(projloc + "\\" + projfolder + "\\" + projectfile))
            {

                xmlwriter.WriteStartDocument();
                xmlwriter.WriteStartElement("SilverJProject");
                xmlwriter.WriteString("\n");
                xmlwriter.WriteComment("Silver-J (1.0) Java Application Project");
                xmlwriter.WriteString("\n");
                xmlwriter.WriteElementString("ProjectName", projectname);
                xmlwriter.WriteString("\n");
                xmlwriter.WriteElementString("ProjectLocationFolder", projloc + "\\" + projfolder);
                xmlwriter.WriteString("\n");
                xmlwriter.WriteElementString("ProjectLocationFile", projloc + "\\" + projfolder + "\\" + projectfile);
                xmlwriter.WriteString("\n");
                xmlwriter.WriteElementString("ProjectType", "ApplicationType");
                xmlwriter.WriteEndElement();
                xmlwriter.WriteEndDocument();
                xmlwriter.Close();

                isSaved = true;

                String defaultprojfilepath = Application.StartupPath + "\\files\\defaultprojloc.slvjfile";
                projectfilename = projloc + "\\" + projfolder + "\\" + projectfile;

                XmlDocument doc = new XmlDocument();
                doc.Load(defaultprojfilepath);
                doc.SelectSingleNode("SilverJ/DefaultProjectLocation").InnerText = ProjectLocationTextBox.Text;
                doc.SelectSingleNode("SilverJ/CurrentProjectName").InnerText = ProjectNameTextBox.Text;
                doc.SelectSingleNode("SilverJ/CurrentProjectFileName").InnerText = projectfilename;
                doc.SelectSingleNode("SilverJ/CurrentProjectType").InnerText = "ApplicationType";
                doc.Save(defaultprojfilepath);


                this.Close();
                isfinished = true;

            }

            String source = projloc;

            String dest = srccclasses ;

            DirectoryCopy(source, dest,  true);
        }

        void DirectoryCopy(string source, string dest, bool copySubDirs = true)
        {
            var dir = new DirectoryInfo(source);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    $"Source directory does not exist or could not be found: {source}");
            }

            DirectoryInfo[] dirs = dir.GetDirectories();

            foreach(DirectoryInfo directory in dirs)
            {
                if(directory.Name != projectname)
                {
                    // String packagefolderpath = dest + directory.Parent + "\\" + directory.Name;

                    string packagefolderpath = Path.Combine(dest, directory.Name);


                    if (projectfilename != "")
                    {
                        XmlDocument xmldoc = new XmlDocument();
                        xmldoc.Load(projectfilename);
                        XmlNode packnamenode = xmldoc.CreateNode(XmlNodeType.Element, "FolderName", null);
                        packnamenode.InnerText = directory.Name;
                        xmldoc.DocumentElement.AppendChild(packnamenode);
                        xmldoc.Save(projectfilename);
                    }

                    if (projectfilename != "")
                    {

                        XmlDocument xmldoc = new XmlDocument();
                        xmldoc.Load(projectfilename);
                        XmlNode packfolderpathnode = xmldoc.CreateNode(XmlNodeType.Element, "FolderNameLocation", null);
                        packfolderpathnode.InnerText = packagefolderpath;
                        xmldoc.DocumentElement.AppendChild(packfolderpathnode);
                        xmldoc.Save(projectfilename);
                    }
                }
               
            }

            if (!Directory.Exists(dest))
            {
                Directory.CreateDirectory(dest);
            }

            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo file in files)
            {
               // String filePath = projloc + "\\" + projfolder + "\\srcclasses\\" + dir.Name + "\\" + file.Name;

                string tempPath = Path.Combine(dest, file.Name);
                file.CopyTo(tempPath, false);

                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(projectfilename);
                XmlNode packnamenode = xmldoc.CreateNode(XmlNodeType.Element, "JavaClassFile", null);
                packnamenode.InnerText = tempPath;
                xmldoc.DocumentElement.AppendChild(packnamenode);
                xmldoc.Save(projectfilename);

            }

            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    if(subdir.Name != projectname)
                    {
                        string tempPath = Path.Combine(dest, subdir.Name);
                        DirectoryCopy(subdir.FullName, tempPath, copySubDirs);
                    }
                   
                }
            }
        }

        public void  CreateJavaProject()
        {
            LoadDirectory();
        }


        //*****************************************************************************************
        //        New Java Application Project Form Load
        //*****************************************************************************************
        private void New_JavaApplicationProject_Form_Load(object sender, EventArgs e)
        {
            String projectfolder = "";
            using (XmlReader reader = XmlReader.Create(defaultprojfilepath))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        switch (reader.Name.ToString())
                        {
                            case "DefaultProjectLocation":
                                projectfolder = reader.ReadString();
                                break;
                        }
                    }
                }
            }
            if (projectfolder != "")
            {
                ProjectLocationTextBox.Text = projectfolder;
                projectfolderlabel.Text = "";
            }
            else
            {
                ProjectLocationTextBox.Text = "";
                projectfolderlabel.Text = "No Project";
            }
        }


        //*****************************************************************************************
        //        Project Name TextBox Text Changed
        //*****************************************************************************************
        private void ProjectNameTextBox_TextChanged(object sender, EventArgs e)
        {
            String[] invalidchars = { " ", "~", "`", "!", "@", "#", "%", "^", "&", "*", "(", ")", "-", "+", "=", "[", "]", "{", "}", ":", ";", "\"", "'", "|", "\\", "<", ">", ",", ".", "?", "/" };

            if (ProjectNameTextBox.Text == "")
            {
                projectfolderlabel.Text = "No Project";
                Finishbutton.Enabled = false;
            }
            else
            {
                projectfolderlabel.Text = ProjectNameTextBox.Text;
                Finishbutton.Enabled = true;
            }

            for (int i = 0; i < invalidchars.Length; i++)
            {
                if (ProjectNameTextBox.Text.Contains(invalidchars[i]))
                {
                    isinvalidcharcontain = true;
                    invalidchar = invalidchars[i];
                    Finishbutton.Enabled = false;
                }
            }

            if (invalidchar != "")
            {
                if (isinvalidcharcontain == true)
                {
                    if (invalidchar == " ")
                    {
                        isinvalidcharcontain = false;
                        Finishbutton.Enabled = false;
                    }
                    else
                    {
                        isinvalidcharcontain = false;
                        Finishbutton.Enabled = false;
                    }
                }
                else
                {
                    projectfolderlabel.Text = ProjectNameTextBox.Text;
                    isinvalidcharcontain = false;
                    Finishbutton.Enabled = true;
                }
            }
        }

        //*****************************************************************************************
        //        Project Location TextBox Text Changed
        //*****************************************************************************************
        private void ProjectLocationTextBox_TextChanged(object sender, EventArgs e)
        {
            String[] invalidchars = { "*", " : ", "\"", "|", " \\", "<", ">", ".", "?" };

            if (ProjectLocationTextBox.Text == "")
            {
            }

            for (int i = 0; i < invalidchars.Length; i++)
            {
                if (ProjectLocationTextBox.Text.Contains(invalidchars[i]))
                {
                    islocinvalidcharcontain = true;
                    locinvalidchar = invalidchars[i];
                }
            }

            if (locinvalidchar != "")
            {
                if (islocinvalidcharcontain == true)
                {
                    islocinvalidcharcontain = false;
                }
                else
                {
                    islocinvalidcharcontain = false;
                }
            }
        }

        //*****************************************************************************************
        //        Finish Button Click
        //*****************************************************************************************
        private void Finishbutton_Click(object sender, EventArgs e)
        {

            if (ProjectNameTextBox.Text == "")
            {
                Finishbutton.Enabled = false;
            }
            else
            {
                Finishbutton.Enabled = true;
            }
            if (ProjectLocationTextBox.Text == "")
            {
                Finishbutton.Enabled = false;
            }
            else
            {
                Finishbutton.Enabled = true;
            }

            if (ProjectNameTextBox.Text != "" && ProjectLocationTextBox.Text != "")
            {
                CreateJavaProject();
                this.Close();
            }


        }


        //*****************************************************************************************
        //        Cancel Button Click
        //*****************************************************************************************
        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //*****************************************************************************************
        //        Help Button Click
        //*****************************************************************************************
        private void Helpbutton_Click(object sender, EventArgs e)
        {
            String file = Application.StartupPath + "\\Help\\silverjhelp.chm";
            if (File.Exists(file))
            {
                Process.Start(file);
            }
        }


        //*****************************************************************************************
        //        Browse Button Click
        //*****************************************************************************************
        private void Browsebutton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                ProjectLocationTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        //*****************************************************************************************
        //         ProjectNameTextBox Key Down
        //*****************************************************************************************
        private void ProjectNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Finishbutton_Click(sender, e);
            }
        }



    }
}
