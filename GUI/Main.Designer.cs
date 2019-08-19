namespace GUI
{
    partial class Main
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
            this.Cbox_Rtr_Switch = new System.Windows.Forms.ComboBox();
            this.Lbl_Rtr_Swtch = new System.Windows.Forms.Label();
            this.Btn_Next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.AccessibleName = "Btn_Exit";
            this.Btn_Exit.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exit.Location = new System.Drawing.Point(77, 113);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(90, 25);
            this.Btn_Exit.TabIndex = 15;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Cbox_Rtr_Switch
            // 
            this.Cbox_Rtr_Switch.AccessibleName = "Cbox_Rtr_Switch";
            this.Cbox_Rtr_Switch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbox_Rtr_Switch.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbox_Rtr_Switch.FormattingEnabled = true;
            this.Cbox_Rtr_Switch.Items.AddRange(new object[] {
            "Router",
            "Switch"});
            this.Cbox_Rtr_Switch.Location = new System.Drawing.Point(211, 39);
            this.Cbox_Rtr_Switch.Name = "Cbox_Rtr_Switch";
            this.Cbox_Rtr_Switch.Size = new System.Drawing.Size(121, 26);
            this.Cbox_Rtr_Switch.TabIndex = 14;
            this.Cbox_Rtr_Switch.SelectedIndexChanged += new System.EventHandler(this.Cbox_Rtr_Switch_SelectedIndexChanged);
            // 
            // Lbl_Rtr_Swtch
            // 
            this.Lbl_Rtr_Swtch.AccessibleName = "Lbl_Rtr_Swtch";
            this.Lbl_Rtr_Swtch.AutoSize = true;
            this.Lbl_Rtr_Swtch.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Rtr_Swtch.Location = new System.Drawing.Point(37, 37);
            this.Lbl_Rtr_Swtch.Name = "Lbl_Rtr_Swtch";
            this.Lbl_Rtr_Swtch.Size = new System.Drawing.Size(151, 20);
            this.Lbl_Rtr_Swtch.TabIndex = 13;
            this.Lbl_Rtr_Swtch.Text = "Router or Switch?";
            // 
            // Btn_Next
            // 
            this.Btn_Next.AccessibleName = "Btn_Next";
            this.Btn_Next.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Next.Location = new System.Drawing.Point(196, 113);
            this.Btn_Next.Name = "Btn_Next";
            this.Btn_Next.Size = new System.Drawing.Size(90, 25);
            this.Btn_Next.TabIndex = 12;
            this.Btn_Next.Text = "Next";
            this.Btn_Next.UseVisualStyleBackColor = true;
            this.Btn_Next.Click += new System.EventHandler(this.Btn_Next_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 177);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Cbox_Rtr_Switch);
            this.Controls.Add(this.Lbl_Rtr_Swtch);
            this.Controls.Add(this.Btn_Next);
            this.Name = "Main";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.ComboBox Cbox_Rtr_Switch;
        private System.Windows.Forms.Label Lbl_Rtr_Swtch;
        private System.Windows.Forms.Button Btn_Next;
    }
}