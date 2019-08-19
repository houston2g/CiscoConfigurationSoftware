namespace GUI
{
    partial class Router
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
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Lbl_PhyAddr = new System.Windows.Forms.Label();
            this.Txt_PhysAddr = new System.Windows.Forms.TextBox();
            this.Lbl_LoopAddr = new System.Windows.Forms.Label();
            this.Txt_LoopAddr = new System.Windows.Forms.TextBox();
            this.Lbl_hostname = new System.Windows.Forms.Label();
            this.Txt_hostname = new System.Windows.Forms.TextBox();
            this.Btn_Next = new System.Windows.Forms.Button();
            this.Lbl_SiteName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.AccessibleName = "Btn_Exit";
            this.Btn_Exit.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exit.Location = new System.Drawing.Point(12, 199);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(90, 25);
            this.Btn_Exit.TabIndex = 22;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Lbl_PhyAddr
            // 
            this.Lbl_PhyAddr.AccessibleName = "Lbl_PhyAddr";
            this.Lbl_PhyAddr.AutoSize = true;
            this.Lbl_PhyAddr.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PhyAddr.Location = new System.Drawing.Point(11, 151);
            this.Lbl_PhyAddr.Name = "Lbl_PhyAddr";
            this.Lbl_PhyAddr.Size = new System.Drawing.Size(142, 20);
            this.Lbl_PhyAddr.TabIndex = 19;
            this.Lbl_PhyAddr.Text = "Physical Address";
            // 
            // Txt_PhysAddr
            // 
            this.Txt_PhysAddr.AccessibleName = "Txt_PhysAddr";
            this.Txt_PhysAddr.Location = new System.Drawing.Point(166, 151);
            this.Txt_PhysAddr.Name = "Txt_PhysAddr";
            this.Txt_PhysAddr.Size = new System.Drawing.Size(199, 20);
            this.Txt_PhysAddr.TabIndex = 18;
            // 
            // Lbl_LoopAddr
            // 
            this.Lbl_LoopAddr.AccessibleName = "Lbl_LoopAddr";
            this.Lbl_LoopAddr.AutoSize = true;
            this.Lbl_LoopAddr.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_LoopAddr.Location = new System.Drawing.Point(1, 72);
            this.Lbl_LoopAddr.Name = "Lbl_LoopAddr";
            this.Lbl_LoopAddr.Size = new System.Drawing.Size(152, 20);
            this.Lbl_LoopAddr.TabIndex = 17;
            this.Lbl_LoopAddr.Text = "Loopback Address";
            // 
            // Txt_LoopAddr
            // 
            this.Txt_LoopAddr.AccessibleName = "Txt_LoopAddr";
            this.Txt_LoopAddr.Location = new System.Drawing.Point(166, 72);
            this.Txt_LoopAddr.Name = "Txt_LoopAddr";
            this.Txt_LoopAddr.Size = new System.Drawing.Size(199, 20);
            this.Txt_LoopAddr.TabIndex = 16;
            // 
            // Lbl_hostname
            // 
            this.Lbl_hostname.AccessibleName = "Lbl_hostname";
            this.Lbl_hostname.AutoSize = true;
            this.Lbl_hostname.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_hostname.Location = new System.Drawing.Point(64, 38);
            this.Lbl_hostname.Name = "Lbl_hostname";
            this.Lbl_hostname.Size = new System.Drawing.Size(89, 20);
            this.Lbl_hostname.TabIndex = 15;
            this.Lbl_hostname.Text = "Hostname";
            // 
            // Txt_hostname
            // 
            this.Txt_hostname.AccessibleName = "Txt_hostname";
            this.Txt_hostname.Location = new System.Drawing.Point(166, 38);
            this.Txt_hostname.Name = "Txt_hostname";
            this.Txt_hostname.Size = new System.Drawing.Size(199, 20);
            this.Txt_hostname.TabIndex = 14;
            // 
            // Btn_Next
            // 
            this.Btn_Next.AccessibleName = "Btn_Next";
            this.Btn_Next.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Next.Location = new System.Drawing.Point(275, 199);
            this.Btn_Next.Name = "Btn_Next";
            this.Btn_Next.Size = new System.Drawing.Size(90, 25);
            this.Btn_Next.TabIndex = 13;
            this.Btn_Next.Text = "Next";
            this.Btn_Next.UseVisualStyleBackColor = true;
            this.Btn_Next.Click += new System.EventHandler(this.Btn_Next_Click);
            // 
            // Lbl_SiteName
            // 
            this.Lbl_SiteName.AccessibleName = "Lbl_SiteName";
            this.Lbl_SiteName.AutoSize = true;
            this.Lbl_SiteName.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SiteName.Location = new System.Drawing.Point(60, 109);
            this.Lbl_SiteName.Name = "Lbl_SiteName";
            this.Lbl_SiteName.Size = new System.Drawing.Size(90, 20);
            this.Lbl_SiteName.TabIndex = 24;
            this.Lbl_SiteName.Text = "Site Name";
            this.Lbl_SiteName.Click += new System.EventHandler(this.Label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "Txt_PhysAddr";
            this.textBox1.Location = new System.Drawing.Point(166, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 23;
            // 
            // Btn_back
            // 
            this.Btn_back.AccessibleName = "Btn_back";
            this.Btn_back.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_back.Location = new System.Drawing.Point(142, 199);
            this.Btn_back.Name = "Btn_back";
            this.Btn_back.Size = new System.Drawing.Size(90, 25);
            this.Btn_back.TabIndex = 25;
            this.Btn_back.Text = "Back";
            this.Btn_back.UseVisualStyleBackColor = true;
            this.Btn_back.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Router
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 254);
            this.Controls.Add(this.Btn_back);
            this.Controls.Add(this.Lbl_SiteName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Lbl_PhyAddr);
            this.Controls.Add(this.Txt_PhysAddr);
            this.Controls.Add(this.Lbl_LoopAddr);
            this.Controls.Add(this.Txt_LoopAddr);
            this.Controls.Add(this.Lbl_hostname);
            this.Controls.Add(this.Txt_hostname);
            this.Controls.Add(this.Btn_Next);
            this.Name = "Router";
            this.Text = "Router";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Router_FormClosing);
            this.Load += new System.EventHandler(this.Router_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Label Lbl_PhyAddr;
        private System.Windows.Forms.TextBox Txt_PhysAddr;
        private System.Windows.Forms.Label Lbl_LoopAddr;
        private System.Windows.Forms.TextBox Txt_LoopAddr;
        private System.Windows.Forms.Label Lbl_hostname;
        private System.Windows.Forms.TextBox Txt_hostname;
        private System.Windows.Forms.Button Btn_Next;
        private System.Windows.Forms.Label Lbl_SiteName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Btn_back;
    }
}