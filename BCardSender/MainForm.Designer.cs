namespace BCardSender
{
    partial class MainForm
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
        /// 

        



        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.VK = new System.Windows.Forms.Button();
            this.FB = new System.Windows.Forms.Button();
            this.new_c = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // VK
            // 
            this.VK.BackColor = System.Drawing.SystemColors.ControlLight;
            this.VK.BackgroundImage = global::BCardSender.Properties.Resources.vk;
            this.VK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VK.Location = new System.Drawing.Point(465, 69);
            this.VK.Name = "VK";
            this.VK.Size = new System.Drawing.Size(59, 57);
            this.VK.TabIndex = 0;
            this.VK.UseVisualStyleBackColor = false;
            this.VK.Click += new System.EventHandler(this.VK_Click);
            // 
            // FB
            // 
            this.FB.BackgroundImage = global::BCardSender.Properties.Resources.FB;
            this.FB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FB.Location = new System.Drawing.Point(465, 163);
            this.FB.Name = "FB";
            this.FB.Size = new System.Drawing.Size(59, 59);
            this.FB.TabIndex = 1;
            this.FB.UseVisualStyleBackColor = true;
            this.FB.Click += new System.EventHandler(this.FB_Click);
            // 
            // new_c
            // 
            this.new_c.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.new_c.Location = new System.Drawing.Point(465, 258);
            this.new_c.Name = "new_c";
            this.new_c.Size = new System.Drawing.Size(59, 59);
            this.new_c.TabIndex = 2;
            this.new_c.Text = "New contact";
            this.new_c.UseVisualStyleBackColor = false;
            this.new_c.Click += new System.EventHandler(this.new_c_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 14);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(447, 394);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(536, 417);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.new_c);
            this.Controls.Add(this.FB);
            this.Controls.Add(this.VK);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button VK;
        private System.Windows.Forms.Button FB;
        private System.Windows.Forms.Button new_c;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

