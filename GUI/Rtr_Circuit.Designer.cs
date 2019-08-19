namespace GUI
{
    partial class Rtr_Circuit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rtr_Circuit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pBox_rtr = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tab_Circuits = new System.Windows.Forms.TabControl();
            this.tab_Circuit = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Btn_back = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Btn_Next = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Lbl_QCircuit = new System.Windows.Forms.Label();
            this.chckbox_Circuit = new System.Windows.Forms.CheckedListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Lbl_RtrType = new System.Windows.Forms.Label();
            this.chkBox_RtrType = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_rtr)).BeginInit();
            this.panel2.SuspendLayout();
            this.tab_Circuits.SuspendLayout();
            this.tab_Circuit.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 29;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pBox_rtr);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // pBox_rtr
            // 
            this.pBox_rtr.BackColor = System.Drawing.Color.White;
            this.pBox_rtr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBox_rtr.Image = ((System.Drawing.Image)(resources.GetObject("pBox_rtr.Image")));
            this.pBox_rtr.Location = new System.Drawing.Point(0, 0);
            this.pBox_rtr.Name = "pBox_rtr";
            this.pBox_rtr.Size = new System.Drawing.Size(266, 450);
            this.pBox_rtr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pBox_rtr.TabIndex = 0;
            this.pBox_rtr.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tab_Circuits);
            this.panel2.Controls.Add(this.Btn_back);
            this.panel2.Controls.Add(this.Btn_Exit);
            this.panel2.Controls.Add(this.Btn_Next);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 450);
            this.panel2.TabIndex = 35;
            // 
            // tab_Circuits
            // 
            this.tab_Circuits.Controls.Add(this.tab_Circuit);
            this.tab_Circuits.Controls.Add(this.tabPage2);
            this.tab_Circuits.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_Circuits.Location = new System.Drawing.Point(20, 12);
            this.tab_Circuits.Name = "tab_Circuits";
            this.tab_Circuits.SelectedIndex = 0;
            this.tab_Circuits.Size = new System.Drawing.Size(498, 395);
            this.tab_Circuits.TabIndex = 38;
            // 
            // tab_Circuit
            // 
            this.tab_Circuit.Controls.Add(this.tableLayoutPanel1);
            this.tab_Circuit.Location = new System.Drawing.Point(4, 24);
            this.tab_Circuit.Name = "tab_Circuit";
            this.tab_Circuit.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Circuit.Size = new System.Drawing.Size(490, 367);
            this.tab_Circuit.TabIndex = 0;
            this.tab_Circuit.Text = "Circuits";
            this.tab_Circuit.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(490, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Btn_back
            // 
            this.Btn_back.AccessibleName = "Btn_back";
            this.Btn_back.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_back.Location = new System.Drawing.Point(212, 415);
            this.Btn_back.Name = "Btn_back";
            this.Btn_back.Size = new System.Drawing.Size(90, 25);
            this.Btn_back.TabIndex = 37;
            this.Btn_back.Text = "Back";
            this.Btn_back.UseVisualStyleBackColor = true;
            this.Btn_back.Click += new System.EventHandler(this.Btn_back_Click_1);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.AccessibleName = "Btn_Exit";
            this.Btn_Exit.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Exit.Location = new System.Drawing.Point(86, 415);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(90, 25);
            this.Btn_Exit.TabIndex = 36;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click_1);
            // 
            // Btn_Next
            // 
            this.Btn_Next.AccessibleName = "Btn_Next";
            this.Btn_Next.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Next.Location = new System.Drawing.Point(349, 415);
            this.Btn_Next.Name = "Btn_Next";
            this.Btn_Next.Size = new System.Drawing.Size(90, 25);
            this.Btn_Next.TabIndex = 35;
            this.Btn_Next.Text = "Next";
            this.Btn_Next.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chckbox_Circuit);
            this.panel4.Controls.Add(this.Lbl_QCircuit);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(246, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(238, 358);
            this.panel4.TabIndex = 1;
            // 
            // Lbl_QCircuit
            // 
            this.Lbl_QCircuit.AutoSize = true;
            this.Lbl_QCircuit.Location = new System.Drawing.Point(26, 13);
            this.Lbl_QCircuit.Name = "Lbl_QCircuit";
            this.Lbl_QCircuit.Size = new System.Drawing.Size(190, 15);
            this.Lbl_QCircuit.TabIndex = 0;
            this.Lbl_QCircuit.Text = "What circuits are on this router?";
            this.Lbl_QCircuit.Click += new System.EventHandler(this.Label1_Click);
            // 
            // chckbox_Circuit
            // 
            this.chckbox_Circuit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chckbox_Circuit.FormattingEnabled = true;
            this.chckbox_Circuit.Items.AddRange(new object[] {
            "ASE",
            "ASEoD",
            "T1",
            "Multilink",
            "Opt-E-Man",
            "ADE",
            "Microwave ALu"});
            this.chckbox_Circuit.Location = new System.Drawing.Point(29, 46);
            this.chckbox_Circuit.Name = "chckbox_Circuit";
            this.chckbox_Circuit.Size = new System.Drawing.Size(187, 120);
            this.chckbox_Circuit.TabIndex = 1;
            this.chckbox_Circuit.SelectedIndexChanged += new System.EventHandler(this.CheckedListBox1_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chkBox_RtrType);
            this.panel3.Controls.Add(this.Lbl_RtrType);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 358);
            this.panel3.TabIndex = 0;
            // 
            // Lbl_RtrType
            // 
            this.Lbl_RtrType.AutoSize = true;
            this.Lbl_RtrType.Location = new System.Drawing.Point(31, 13);
            this.Lbl_RtrType.Name = "Lbl_RtrType";
            this.Lbl_RtrType.Size = new System.Drawing.Size(156, 15);
            this.Lbl_RtrType.TabIndex = 2;
            this.Lbl_RtrType.Text = "What model is this router?";
            this.Lbl_RtrType.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // chkBox_RtrType
            // 
            this.chkBox_RtrType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chkBox_RtrType.FormattingEnabled = true;
            this.chkBox_RtrType.Items.AddRange(new object[] {
            "ISR 4331",
            "Cisco 2811"});
            this.chkBox_RtrType.Location = new System.Drawing.Point(34, 46);
            this.chkBox_RtrType.Name = "chkBox_RtrType";
            this.chkBox_RtrType.Size = new System.Drawing.Size(187, 45);
            this.chkBox_RtrType.TabIndex = 3;
            this.chkBox_RtrType.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ChkBox_RtrType_ItemCheck);
            this.chkBox_RtrType.SelectedIndexChanged += new System.EventHandler(this.CheckedListBox1_SelectedIndexChanged_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(487, 364);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Rtr_Circuit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Rtr_Circuit";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rtr_Circuit_FormClosing);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_rtr)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tab_Circuits.ResumeLayout(false);
            this.tab_Circuit.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pBox_rtr;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tab_Circuits;
        private System.Windows.Forms.TabPage tab_Circuit;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Btn_back;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Button Btn_Next;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckedListBox chkBox_RtrType;
        private System.Windows.Forms.Label Lbl_RtrType;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckedListBox chckbox_Circuit;
        private System.Windows.Forms.Label Lbl_QCircuit;
    }
}