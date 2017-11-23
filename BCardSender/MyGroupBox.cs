using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCardSender
{
    class MyGroupBox: GroupBox
    {
        Button delete;
        Label label1;
        Label label2;
        PictureBox picBox;
        Contact contactRef;

        public MyGroupBox() // default constractor
        {
           
            this.delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();

            // 
            // MygroupBox
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.delete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox);
            this.Location = new System.Drawing.Point(12, 12);
            this.Name = "MyGroupBox";
            this.Size = new System.Drawing.Size(430, 75);
            this.TabIndex = 0;
            this.TabStop = false;
            //this.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DeleteButton
            // 
            this.delete.BackColor = System.Drawing.Color.Gray;
            this.delete.Location = new System.Drawing.Point(351, 31);
            this.delete.Name = "Delete";
            this.delete.Size = new System.Drawing.Size(75, 27);
            this.delete.TabIndex = 4;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(283, 17);
            this.label2.MinimumSize = new System.Drawing.Size(60, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 50);
            this.label2.TabIndex = 2;
         
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(67, 17);
            this.label1.MinimumSize = new System.Drawing.Size(210, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 50);
            this.label1.TabIndex = 1;
           
            // 
            // pictureBox
            // 
            this.picBox.Location = new System.Drawing.Point(9, 19);
            this.picBox.Name = "pictureBox1";
            this.picBox.Size = new System.Drawing.Size(52, 48);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;

        }

        public MyGroupBox(string name, string bdate) // default constractor
        {

            this.delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();

            // 
            // MygroupBox
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.delete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox);
            this.Location = new System.Drawing.Point(12, 12);
            this.Name = "MyGroupBox";
            this.Size = new System.Drawing.Size(432, 76);
            this.TabIndex = 0;
            this.TabStop = false;
            //this.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DeleteButton
            // 
            this.delete.BackColor = System.Drawing.Color.Gray;
            this.delete.Location = new System.Drawing.Point(351, 31);
            this.delete.Name = "Delete";
            this.delete.Size = new System.Drawing.Size(75, 27);
            this.delete.TabIndex = 4;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(283, 17);
            this.label2.MinimumSize = new System.Drawing.Size(60, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = bdate;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(67, 17);
            this.label1.MinimumSize = new System.Drawing.Size(210, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 50);
            this.label1.TabIndex = 1;
            this.label2.Text = name;
            // 
            // pictureBox
            // 
            this.picBox.Location = new System.Drawing.Point(9, 19);
            this.picBox.Name = "pictureBox1";
            this.picBox.Size = new System.Drawing.Size(52, 48);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;

        }

        public MyGroupBox(Contact newContact)
        {

            this.delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            this.contactRef = newContact; // contact reference
            newContact.GBRef = this;// this groupbox ref for the contact
       
           
            
            // 
            // MygroupBox
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.delete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBox);
            this.Location = new System.Drawing.Point(12, 12);
            this.Name = "MyGroupBox";
            this.Size = new System.Drawing.Size(432, 76);
            this.TabIndex = 0;
            this.TabStop = false;
            //this.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // DeleteButton
            // 
            this.delete.BackColor = System.Drawing.Color.Gray;
            this.delete.Location = new System.Drawing.Point(351, 31);
            this.delete.Name = "Delete";
            this.delete.Size = new System.Drawing.Size(75, 27);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(283, 17);
            this.label2.MinimumSize = new System.Drawing.Size(60, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = newContact.Birthday.ToString() + ' ' + newContact.Birthday.ToString();
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(67, 17);
            this.label1.MinimumSize = new System.Drawing.Size(210, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = newContact.Name +' '+newContact.Surname;

          
            // 
            // pictureBox
            // 
            this.picBox.Location = new System.Drawing.Point(9, 19);
            this.picBox.Name = "pictureBox1";
            this.picBox.Size = new System.Drawing.Size(52, 48);
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            //this.picBox.Image = new Bitmap(newContact.Photo);

        }
    }
}
