namespace Com_Client_Project
{
    partial class Form1
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ابدءالاتصالToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عرضToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.status = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.stopCall = new System.Windows.Forms.Button();
            this.iNRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.مشاهدةجميعالمأخذToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defualt = new System.Windows.Forms.Button();
            this.إيقافالأتصالToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.الرئيسيةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تغيرالخصائصToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xOGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticTakTioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حولناToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.startCall = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd",
            "Mark",
            "Space"});
            this.comboBox5.Location = new System.Drawing.Point(35, 242);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(160, 36);
            this.comboBox5.TabIndex = 22;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.BackColor = System.Drawing.Color.Ivory;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.comboBox1.Location = new System.Drawing.Point(35, 41);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(10, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 36);
            this.comboBox1.TabIndex = 18;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "One",
            "Two",
            "OneFivePoint"});
            this.comboBox4.Location = new System.Drawing.Point(35, 187);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(160, 36);
            this.comboBox4.TabIndex = 21;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboBox2.Location = new System.Drawing.Point(35, 92);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 36);
            this.comboBox2.TabIndex = 19;
            // 
            // ابدءالاتصالToolStripMenuItem
            // 
            this.ابدءالاتصالToolStripMenuItem.Name = "ابدءالاتصالToolStripMenuItem";
            this.ابدءالاتصالToolStripMenuItem.Size = new System.Drawing.Size(266, 34);
            this.ابدءالاتصالToolStripMenuItem.Text = "ابدء الاتصال";
            // 
            // عرضToolStripMenuItem
            // 
            this.عرضToolStripMenuItem.Name = "عرضToolStripMenuItem";
            this.عرضToolStripMenuItem.Size = new System.Drawing.Size(138, 34);
            this.عرضToolStripMenuItem.Text = "عرض ";
            this.عرضToolStripMenuItem.Click += new System.EventHandler(this.عرضToolStripMenuItem_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("SST Arabic Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.Red;
            this.status.Location = new System.Drawing.Point(774, 479);
            this.status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(141, 55);
            this.status.TabIndex = 40;
            this.status.Text = "غير متصل";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SST Arabic", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(227, 187);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "بت التوقف";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(372, 199);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(724, 244);
            this.richTextBox1.TabIndex = 39;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SST Arabic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(242, 242);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "التكافؤ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.richTextBox2);
            this.groupBox2.Location = new System.Drawing.Point(372, 59);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(724, 129);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المهام";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(134, 46);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(573, 31);
            this.richTextBox2.TabIndex = 15;
            this.richTextBox2.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.comboBox5);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(17, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(336, 305);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الإعدادت";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "9600",
            "1155",
            "4800",
            "19200"});
            this.comboBox3.Location = new System.Drawing.Point(35, 138);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(160, 36);
            this.comboBox3.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SST Arabic", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(227, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "معدل البود";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SST Arabic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(229, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "بت البيانات";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SST Arabic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "اسم البورت";
            // 
            // stopCall
            // 
            this.stopCall.Location = new System.Drawing.Point(205, 492);
            this.stopCall.Name = "stopCall";
            this.stopCall.Size = new System.Drawing.Size(166, 69);
            this.stopCall.TabIndex = 43;
            this.stopCall.Text = "إيقاف الإتصال";
            this.stopCall.UseVisualStyleBackColor = true;
            this.stopCall.Click += new System.EventHandler(this.stopCall_Click);
            // 
            // iNRowToolStripMenuItem
            // 
            this.iNRowToolStripMenuItem.Name = "iNRowToolStripMenuItem";
            this.iNRowToolStripMenuItem.Size = new System.Drawing.Size(183, 34);
            this.iNRowToolStripMenuItem.Text = "7 IN Row";
            // 
            // مشاهدةجميعالمأخذToolStripMenuItem
            // 
            this.مشاهدةجميعالمأخذToolStripMenuItem.Name = "مشاهدةجميعالمأخذToolStripMenuItem";
            this.مشاهدةجميعالمأخذToolStripMenuItem.Size = new System.Drawing.Size(266, 34);
            this.مشاهدةجميعالمأخذToolStripMenuItem.Text = "عرض جميع المأخذ COM";
            // 
            // defualt
            // 
            this.defualt.Location = new System.Drawing.Point(17, 389);
            this.defualt.Name = "defualt";
            this.defualt.Size = new System.Drawing.Size(336, 54);
            this.defualt.TabIndex = 37;
            this.defualt.Text = "الحالة الأفتراضية";
            this.defualt.UseVisualStyleBackColor = true;
            this.defualt.Click += new System.EventHandler(this.defualt_Click_1);
            // 
            // إيقافالأتصالToolStripMenuItem
            // 
            this.إيقافالأتصالToolStripMenuItem.Name = "إيقافالأتصالToolStripMenuItem";
            this.إيقافالأتصالToolStripMenuItem.Size = new System.Drawing.Size(266, 34);
            this.إيقافالأتصالToolStripMenuItem.Text = "إيقاف الأتصال";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.الرئيسيةToolStripMenuItem,
            this.xOGameToolStripMenuItem,
            this.حولناToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1119, 37);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // الرئيسيةToolStripMenuItem
            // 
            this.الرئيسيةToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ابدءالاتصالToolStripMenuItem,
            this.إيقافالأتصالToolStripMenuItem,
            this.تغيرالخصائصToolStripMenuItem,
            this.مشاهدةجميعالمأخذToolStripMenuItem});
            this.الرئيسيةToolStripMenuItem.Font = new System.Drawing.Font("SST Arabic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.الرئيسيةToolStripMenuItem.Name = "الرئيسيةToolStripMenuItem";
            this.الرئيسيةToolStripMenuItem.Size = new System.Drawing.Size(85, 33);
            this.الرئيسيةToolStripMenuItem.Text = "الرئيسية";
            // 
            // تغيرالخصائصToolStripMenuItem
            // 
            this.تغيرالخصائصToolStripMenuItem.Name = "تغيرالخصائصToolStripMenuItem";
            this.تغيرالخصائصToolStripMenuItem.Size = new System.Drawing.Size(266, 34);
            this.تغيرالخصائصToolStripMenuItem.Text = "تغير الخصائص";
            // 
            // xOGameToolStripMenuItem
            // 
            this.xOGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ticTakTioToolStripMenuItem,
            this.iNRowToolStripMenuItem});
            this.xOGameToolStripMenuItem.Font = new System.Drawing.Font("SST Arabic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xOGameToolStripMenuItem.Name = "xOGameToolStripMenuItem";
            this.xOGameToolStripMenuItem.Size = new System.Drawing.Size(79, 33);
            this.xOGameToolStripMenuItem.Text = "الالعاب";
            // 
            // ticTakTioToolStripMenuItem
            // 
            this.ticTakTioToolStripMenuItem.Name = "ticTakTioToolStripMenuItem";
            this.ticTakTioToolStripMenuItem.Size = new System.Drawing.Size(183, 34);
            this.ticTakTioToolStripMenuItem.Text = "Tic Tak Tio";
            // 
            // حولناToolStripMenuItem
            // 
            this.حولناToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.عرضToolStripMenuItem});
            this.حولناToolStripMenuItem.Font = new System.Drawing.Font("SST Arabic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.حولناToolStripMenuItem.Name = "حولناToolStripMenuItem";
            this.حولناToolStripMenuItem.Size = new System.Drawing.Size(63, 33);
            this.حولناToolStripMenuItem.Text = "حولنا";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SST Arabic Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(581, 479);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 55);
            this.label8.TabIndex = 41;
            this.label8.Text = "حالة الإتصال : ";
            // 
            // startCall
            // 
            this.startCall.Location = new System.Drawing.Point(17, 492);
            this.startCall.Name = "startCall";
            this.startCall.Size = new System.Drawing.Size(166, 69);
            this.startCall.TabIndex = 42;
            this.startCall.Text = "بدء الإتصال";
            this.startCall.UseVisualStyleBackColor = true;
            this.startCall.Click += new System.EventHandler(this.startCall_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 584);
            this.Controls.Add(this.status);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.stopCall);
            this.Controls.Add(this.defualt);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.startCall);
            this.Font = new System.Drawing.Font("SST Arabic", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "العميل";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ToolStripMenuItem ابدءالاتصالToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عرضToolStripMenuItem;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button stopCall;
        private System.Windows.Forms.ToolStripMenuItem iNRowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مشاهدةجميعالمأخذToolStripMenuItem;
        private System.Windows.Forms.Button defualt;
        private System.Windows.Forms.ToolStripMenuItem إيقافالأتصالToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem الرئيسيةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تغيرالخصائصToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xOGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ticTakTioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حولناToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button startCall;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

