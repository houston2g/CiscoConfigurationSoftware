namespace GUI
{
    partial class Switch
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
            this.Lbl_IPAddress = new System.Windows.Forms.Label();
            this.Txt_IPAddress = new System.Windows.Forms.TextBox();
            this.Lbl_hostname = new System.Windows.Forms.Label();
            this.Txt_hostname = new System.Windows.Forms.TextBox();
            this.Btn_Next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.AccessibleName = "Btn_Exit";
            this.Btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exit.Location = new System.Drawing.Point(84, 137);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(90, 25);
            this.Btn_Exit.TabIndex = 32;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Lbl_PhyAddr
            // 
            this.Lbl_PhyAddr.AccessibleName = "Lbl_PhyAddr";
            this.Lbl_PhyAddr.AutoSize = true;
            this.Lbl_PhyAddr.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PhyAddr.Location = new System.Drawing.Point(17, 95);
            this.Lbl_PhyAddr.Name = "Lbl_PhyAddr";
            this.Lbl_PhyAddr.Size = new System.Drawing.Size(142, 20);
            this.Lbl_PhyAddr.TabIndex = 29;
            this.Lbl_PhyAddr.Text = "Physical Address";
            // 
            // Txt_PhysAddr
            // 
            this.Txt_PhysAddr.AccessibleName = "Txt_PhysAddr";
            this.Txt_PhysAddr.Location = new System.Drawing.Point(175, 95);
            this.Txt_PhysAddr.Name = "Txt_PhysAddr";
            this.Txt_PhysAddr.Size = new System.Drawing.Size(199, 20);
            this.Txt_PhysAddr.TabIndex = 28;
            // 
            // Lbl_IPAddress
            // 
            this.Lbl_IPAddress.AccessibleName = "Lbl_IPAddress";
            this.Lbl_IPAddress.AutoSize = true;
            this.Lbl_IPAddress.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_IPAddress.Location = new System.Drawing.Point(70, 62);
            this.Lbl_IPAddress.Name = "Lbl_IPAddress";
            this.Lbl_IPAddress.Size = new System.Drawing.Size(92, 20);
            this.Lbl_IPAddress.TabIndex = 27;
            this.Lbl_IPAddress.Text = "IP Address";
            // 
            // Txt_IPAddress
            // 
            this.Txt_IPAddress.AccessibleName = "Txt_IPAddress";
            this.Txt_IPAddress.Location = new System.Drawing.Point(175, 62);
            this.Txt_IPAddress.Name = "Txt_IPAddress";
            this.Txt_IPAddress.Size = new System.Drawing.Size(199, 20);
            this.Txt_IPAddress.TabIndex = 26;
            // 
            // Lbl_hostname
            // 
            this.Lbl_hostname.AccessibleName = "Lbl_hostname";
            this.Lbl_hostname.AutoSize = true;
            this.Lbl_hostname.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_hostname.Location = new System.Drawing.Point(70, 28);
            this.Lbl_hostname.Name = "Lbl_hostname";
            this.Lbl_hostname.Size = new System.Drawing.Size(89, 20);
            this.Lbl_hostname.TabIndex = 25;
            this.Lbl_hostname.Text = "Hostname";
            // 
            // Txt_hostname
            // 
            this.Txt_hostname.AccessibleName = "Txt_hostname";
            this.Txt_hostname.Location = new System.Drawing.Point(175, 28);
            this.Txt_hostname.Name = "Txt_hostname";
            this.Txt_hostname.Size = new System.Drawing.Size(199, 20);
            this.Txt_hostname.TabIndex = 24;
            // 
            // Btn_Next
            // 
            this.Btn_Next.AccessibleName = "Btn_Next";
            this.Btn_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Next.Location = new System.Drawing.Point(203, 137);
            this.Btn_Next.Name = "Btn_Next";
            this.Btn_Next.Size = new System.Drawing.Size(90, 25);
            this.Btn_Next.TabIndex = 23;
            this.Btn_Next.Text = "Next";
            this.Btn_Next.UseVisualStyleBackColor = true;
            // 
            // Switch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 198);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Lbl_PhyAddr);
            this.Controls.Add(this.Txt_PhysAddr);
            this.Controls.Add(this.Lbl_IPAddress);
            this.Controls.Add(this.Txt_IPAddress);
            this.Controls.Add(this.Lbl_hostname);
            this.Controls.Add(this.Txt_hostname);
            this.Controls.Add(this.Btn_Next);
            this.Name = "Switch";
            this.Text = "Switch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Switch_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Label Lbl_PhyAddr;
        private System.Windows.Forms.TextBox Txt_PhysAddr;
        private System.Windows.Forms.Label Lbl_IPAddress;
        private System.Windows.Forms.TextBox Txt_IPAddress;
        private System.Windows.Forms.Label Lbl_hostname;
        private System.Windows.Forms.TextBox Txt_hostname;
        private System.Windows.Forms.Button Btn_Next;
    }
}