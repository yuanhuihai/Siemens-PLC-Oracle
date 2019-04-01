namespace Siemens_PLC_数据采集
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.connectStatus = new System.Windows.Forms.Button();
            this.disconnectPlc = new System.Windows.Forms.Button();
            this.connectPlc = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.消息列表 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.readStatus = new System.Windows.Forms.Button();
            this.finishRead = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.startRead = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.readCycle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.confirmTable = new System.Windows.Forms.Button();
            this.oracleTableName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.orcName = new System.Windows.Forms.TextBox();
            this.OcStatus = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.OracleDisconnect = new System.Windows.Forms.Button();
            this.OracleConnect = new System.Windows.Forms.Button();
            this.userPw = new System.Windows.Forms.TextBox();
            this.userId = new System.Windows.Forms.TextBox();
            this.dataSourceIp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.connectStatus);
            this.groupBox1.Controls.Add(this.disconnectPlc);
            this.groupBox1.Controls.Add(this.connectPlc);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "建立PLC连接";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(59, 144);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "IP地址";
            // 
            // connectStatus
            // 
            this.connectStatus.Location = new System.Drawing.Point(286, 63);
            this.connectStatus.Name = "connectStatus";
            this.connectStatus.Size = new System.Drawing.Size(49, 23);
            this.connectStatus.TabIndex = 8;
            this.connectStatus.UseVisualStyleBackColor = true;
            // 
            // disconnectPlc
            // 
            this.disconnectPlc.Location = new System.Drawing.Point(124, 64);
            this.disconnectPlc.Name = "disconnectPlc";
            this.disconnectPlc.Size = new System.Drawing.Size(49, 23);
            this.disconnectPlc.TabIndex = 7;
            this.disconnectPlc.Text = "断开";
            this.disconnectPlc.UseVisualStyleBackColor = true;
            this.disconnectPlc.Click += new System.EventHandler(this.button2_Click);
            // 
            // connectPlc
            // 
            this.connectPlc.Location = new System.Drawing.Point(17, 64);
            this.connectPlc.Name = "connectPlc";
            this.connectPlc.Size = new System.Drawing.Size(49, 23);
            this.connectPlc.TabIndex = 1;
            this.connectPlc.Text = "连接";
            this.connectPlc.UseVisualStyleBackColor = true;
            this.connectPlc.Click += new System.EventHandler(this.connectPlc_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(305, 30);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(27, 21);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(222, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(27, 21);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "状态";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "插槽";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "机架号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP地址";
            // 
            // 消息列表
            // 
            this.消息列表.FormattingEnabled = true;
            this.消息列表.ItemHeight = 12;
            this.消息列表.Location = new System.Drawing.Point(372, 21);
            this.消息列表.Name = "消息列表";
            this.消息列表.Size = new System.Drawing.Size(247, 112);
            this.消息列表.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.readStatus);
            this.groupBox2.Controls.Add(this.finishRead);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.startRead);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.readCycle);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "循环读取DBW";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(306, 11);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(40, 21);
            this.textBox8.TabIndex = 17;
            // 
            // readStatus
            // 
            this.readStatus.Location = new System.Drawing.Point(283, 67);
            this.readStatus.Name = "readStatus";
            this.readStatus.Size = new System.Drawing.Size(49, 23);
            this.readStatus.TabIndex = 12;
            this.readStatus.UseVisualStyleBackColor = true;
            // 
            // finishRead
            // 
            this.finishRead.Location = new System.Drawing.Point(123, 67);
            this.finishRead.Name = "finishRead";
            this.finishRead.Size = new System.Drawing.Size(49, 23);
            this.finishRead.TabIndex = 16;
            this.finishRead.Text = "结束";
            this.finishRead.UseVisualStyleBackColor = true;
            this.finishRead.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(230, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "状态";
            // 
            // startRead
            // 
            this.startRead.Location = new System.Drawing.Point(17, 68);
            this.startRead.Name = "startRead";
            this.startRead.Size = new System.Drawing.Size(49, 23);
            this.startRead.TabIndex = 11;
            this.startRead.Text = "开始";
            this.startRead.UseVisualStyleBackColor = true;
            this.startRead.Click += new System.EventHandler(this.startRead_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(292, 40);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(40, 21);
            this.textBox7.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "字";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(198, 40);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(40, 21);
            this.textBox6.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "DB块";
            // 
            // readCycle
            // 
            this.readCycle.Location = new System.Drawing.Point(68, 38);
            this.readCycle.Name = "readCycle";
            this.readCycle.Size = new System.Drawing.Size(40, 21);
            this.readCycle.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "循环周期";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.confirmTable);
            this.groupBox3.Controls.Add(this.oracleTableName);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.orcName);
            this.groupBox3.Controls.Add(this.OcStatus);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.OracleDisconnect);
            this.groupBox3.Controls.Add(this.OracleConnect);
            this.groupBox3.Controls.Add(this.userPw);
            this.groupBox3.Controls.Add(this.userId);
            this.groupBox3.Controls.Add(this.dataSourceIp);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(12, 127);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 155);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "建立Oracle数据库连接";
            // 
            // confirmTable
            // 
            this.confirmTable.Location = new System.Drawing.Point(289, 125);
            this.confirmTable.Name = "confirmTable";
            this.confirmTable.Size = new System.Drawing.Size(49, 23);
            this.confirmTable.TabIndex = 21;
            this.confirmTable.Text = "选择";
            this.confirmTable.UseVisualStyleBackColor = true;
            // 
            // oracleTableName
            // 
            this.oracleTableName.Location = new System.Drawing.Point(124, 127);
            this.oracleTableName.Name = "oracleTableName";
            this.oracleTableName.ReadOnly = true;
            this.oracleTableName.Size = new System.Drawing.Size(153, 21);
            this.oracleTableName.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 12);
            this.label15.TabIndex = 19;
            this.label15.Text = "选择数据库中表格";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(195, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 18;
            this.label14.Text = "实例名";
            // 
            // orcName
            // 
            this.orcName.Location = new System.Drawing.Point(238, 24);
            this.orcName.Name = "orcName";
            this.orcName.Size = new System.Drawing.Size(100, 21);
            this.orcName.TabIndex = 17;
            // 
            // OcStatus
            // 
            this.OcStatus.Location = new System.Drawing.Point(286, 91);
            this.OcStatus.Name = "OcStatus";
            this.OcStatus.Size = new System.Drawing.Size(49, 23);
            this.OcStatus.TabIndex = 12;
            this.OcStatus.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(230, 97);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 11;
            this.label13.Text = "状态";
            // 
            // OracleDisconnect
            // 
            this.OracleDisconnect.Location = new System.Drawing.Point(124, 91);
            this.OracleDisconnect.Name = "OracleDisconnect";
            this.OracleDisconnect.Size = new System.Drawing.Size(49, 23);
            this.OracleDisconnect.TabIndex = 16;
            this.OracleDisconnect.Text = "断开";
            this.OracleDisconnect.UseVisualStyleBackColor = true;
            this.OracleDisconnect.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // OracleConnect
            // 
            this.OracleConnect.Location = new System.Drawing.Point(17, 91);
            this.OracleConnect.Name = "OracleConnect";
            this.OracleConnect.Size = new System.Drawing.Size(49, 23);
            this.OracleConnect.TabIndex = 11;
            this.OracleConnect.Text = "连接";
            this.OracleConnect.UseVisualStyleBackColor = true;
            this.OracleConnect.Click += new System.EventHandler(this.OracleConnect_Click);
            // 
            // userPw
            // 
            this.userPw.Location = new System.Drawing.Point(238, 57);
            this.userPw.Name = "userPw";
            this.userPw.Size = new System.Drawing.Size(100, 21);
            this.userPw.TabIndex = 15;
            // 
            // userId
            // 
            this.userId.Location = new System.Drawing.Point(62, 55);
            this.userId.Name = "userId";
            this.userId.Size = new System.Drawing.Size(100, 21);
            this.userId.TabIndex = 14;
            // 
            // dataSourceIp
            // 
            this.dataSourceIp.Location = new System.Drawing.Point(36, 24);
            this.dataSourceIp.Name = "dataSourceIp";
            this.dataSourceIp.Size = new System.Drawing.Size(123, 21);
            this.dataSourceIp.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(196, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 13;
            this.label12.Text = "密码";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 12;
            this.label11.Text = "用户名";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "IP";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(372, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(240, 138);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(374, 151);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 12);
            this.label16.TabIndex = 22;
            this.label16.Text = "数据库中表格列表";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(114, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 12);
            this.label17.TabIndex = 18;
            this.label17.Text = "ms";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 465);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.消息列表);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Siemens-PLC-Oracle数据采集系统-V1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button connectStatus;
        private System.Windows.Forms.Button disconnectPlc;
        private System.Windows.Forms.Button connectPlc;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox 消息列表;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox readCycle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button finishRead;
        private System.Windows.Forms.Button startRead;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button readStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button OracleDisconnect;
        private System.Windows.Forms.Button OracleConnect;
        private System.Windows.Forms.TextBox userPw;
        private System.Windows.Forms.TextBox userId;
        private System.Windows.Forms.TextBox dataSourceIp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button OcStatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox orcName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox oracleTableName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button confirmTable;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Timer timer1;
    }
}

