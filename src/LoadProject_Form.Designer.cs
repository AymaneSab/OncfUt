#region Copyright
/***************************************************************************************
 ******Copyright (C) 2016 Pritam Zope*****
 
  <copyright file="New_JavaApplicationProject_Form.Designer.cs" company="">
  
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

namespace Silver_J
{
    partial class LoadProject_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadProject_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProjectNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProjectLocationTextBox = new System.Windows.Forms.TextBox();
            this.Browsebutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.projectfolderlabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Finishbutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.Helpbutton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(211, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Preparing New CSharp Project ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Project Name : ";
            // 
            // ProjectNameTextBox
            // 
            this.ProjectNameTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectNameTextBox.Location = new System.Drawing.Point(123, 61);
            this.ProjectNameTextBox.Name = "ProjectNameTextBox";
            this.ProjectNameTextBox.Size = new System.Drawing.Size(435, 23);
            this.ProjectNameTextBox.TabIndex = 4;
            this.toolTip1.SetToolTip(this.ProjectNameTextBox, "Enter Project Name");
            this.ProjectNameTextBox.TextChanged += new System.EventHandler(this.ProjectNameTextBox_TextChanged);
            this.ProjectNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProjectNameTextBox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Project Location : ";
            // 
            // ProjectLocationTextBox
            // 
            this.ProjectLocationTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectLocationTextBox.Location = new System.Drawing.Point(123, 109);
            this.ProjectLocationTextBox.Name = "ProjectLocationTextBox";
            this.ProjectLocationTextBox.Size = new System.Drawing.Size(435, 23);
            this.ProjectLocationTextBox.TabIndex = 8;
            this.toolTip1.SetToolTip(this.ProjectLocationTextBox, "Enter Project Location Folder");
            this.ProjectLocationTextBox.TextChanged += new System.EventHandler(this.ProjectLocationTextBox_TextChanged);
            // 
            // Browsebutton
            // 
            this.Browsebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browsebutton.Location = new System.Drawing.Point(564, 151);
            this.Browsebutton.Name = "Browsebutton";
            this.Browsebutton.Size = new System.Drawing.Size(86, 24);
            this.Browsebutton.TabIndex = 9;
            this.Browsebutton.Text = "Browse";
            this.toolTip1.SetToolTip(this.Browsebutton, "Select Folder");
            this.Browsebutton.UseVisualStyleBackColor = true;
            this.Browsebutton.Click += new System.EventHandler(this.Browsebutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Project Folder : ";
            // 
            // projectfolderlabel
            // 
            this.projectfolderlabel.AutoSize = true;
            this.projectfolderlabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectfolderlabel.Location = new System.Drawing.Point(155, 151);
            this.projectfolderlabel.Name = "projectfolderlabel";
            this.projectfolderlabel.Size = new System.Drawing.Size(70, 17);
            this.projectfolderlabel.TabIndex = 11;
            this.projectfolderlabel.Text = "No Project";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(0, 190);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 10);
            this.panel1.TabIndex = 14;
            // 
            // Finishbutton
            // 
            this.Finishbutton.Enabled = false;
            this.Finishbutton.Location = new System.Drawing.Point(413, 217);
            this.Finishbutton.Name = "Finishbutton";
            this.Finishbutton.Size = new System.Drawing.Size(75, 25);
            this.Finishbutton.TabIndex = 15;
            this.Finishbutton.Text = "Finish";
            this.toolTip1.SetToolTip(this.Finishbutton, "Finish");
            this.Finishbutton.UseVisualStyleBackColor = true;
            this.Finishbutton.Click += new System.EventHandler(this.Finishbutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(494, 217);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 25);
            this.Cancelbutton.TabIndex = 16;
            this.Cancelbutton.Text = "Cancel";
            this.toolTip1.SetToolTip(this.Cancelbutton, "Cancel");
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // Helpbutton
            // 
            this.Helpbutton.Location = new System.Drawing.Point(575, 217);
            this.Helpbutton.Name = "Helpbutton";
            this.Helpbutton.Size = new System.Drawing.Size(75, 25);
            this.Helpbutton.TabIndex = 17;
            this.Helpbutton.Text = "Help";
            this.toolTip1.SetToolTip(this.Helpbutton, "Help");
            this.Helpbutton.UseVisualStyleBackColor = true;
            this.Helpbutton.Click += new System.EventHandler(this.Helpbutton_Click);
            // 
            // LoadProject_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(662, 254);
            this.Controls.Add(this.Helpbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Finishbutton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.projectfolderlabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Browsebutton);
            this.Controls.Add(this.ProjectLocationTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProjectNameTextBox);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadProject_Form";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load New CSharp Project ";
            this.Load += new System.EventHandler(this.New_JavaApplicationProject_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabelZ labelZ1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProjectNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProjectLocationTextBox;
        private System.Windows.Forms.Button Browsebutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label projectfolderlabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Finishbutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button Helpbutton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}