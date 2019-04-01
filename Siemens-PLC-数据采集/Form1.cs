using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sharp7;
using Oracle.DataAccess.Client;


namespace Siemens_PLC_数据采集
{
    public partial class Form1 : Form
    {
        private S7Client Client;
        private byte[] Buffer = new byte[65536];
 

        public Form1()
        {
            InitializeComponent();
            Client = new S7Client();
            if (IntPtr.Size == 4)
                this.Text = this.Text + " - Running 32 bit Code";
            else
                this.Text = this.Text + " - Running 64 bit Code";
        }
        private void ShowResult(int Result)
        {
            // This function returns a textual explaination of the error code
            消息列表.Text = Client.ErrorText(Result) + " (" + Client.ExecTime().ToString() + " ms)";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Client.Disconnect();
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            connectPlc.Enabled = true;
            disconnectPlc.Enabled = false;
            connectStatus.BackColor = Color.DarkGray;

            消息列表.Items.Add("断开IP地址为 " + textBox1.Text + "的连接");
            if (消息列表.Items.Count == 40)
            {
                消息列表.Items.Clear();
            }

        }

        private void connectPlc_Click(object sender, EventArgs e)
        {
            int Result;
            int Rack = System.Convert.ToInt32(textBox2.Text);
            int Slot = System.Convert.ToInt32(textBox3.Text);
            Result = Client.ConnectTo(textBox1.Text, Rack, Slot);
            ShowResult(Result);
            if (Result == 0)
            {

                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                connectPlc.Enabled = false;
                disconnectPlc.Enabled = true;
                connectStatus.BackColor = Color.Green;
                startRead.Enabled = true;

                消息列表.Items.Add("建立IP地址为 " +textBox1.Text + "的连接成功");
                if (消息列表.Items.Count == 40)
                {
                    消息列表.Items.Clear();
                }
            }
        }

        private void ReadDbw()
        {
            int DBNumber;
            int Size = 10;
            int Result;

            DBNumber = System.Convert.ToInt32(textBox6.Text);
            Result = Client.DBRead(DBNumber, 0, Size, Buffer);
            if (Result == 0)
                HexDump(Buffer, Size);

        }
        private void HexDump(byte[] bytes, int Size)
        {
            if (bytes == null)
                return;
            int bytesLength = Size;
            int bytesPerLine = 16;

            char[] HexChars = "0123456789ABCDEF".ToCharArray();

            int firstHexColumn =
                  8                   // 8 characters for the address
                + 3;                  // 3 spaces

            int firstCharColumn = firstHexColumn
                + bytesPerLine * 3       // - 2 digit for the hexadecimal value and 1 space
                + (bytesPerLine - 1) / 8 // - 1 extra space every 8 characters from the 9th
                + 2;                  // 2 spaces 

            int lineLength = firstCharColumn
                + bytesPerLine           // - characters to show the ascii value
                + Environment.NewLine.Length; // Carriage return and line feed (should normally be 2)

            char[] line = (new String(' ', lineLength - 2) + Environment.NewLine).ToCharArray();
            int expectedLines = (bytesLength + bytesPerLine - 1) / bytesPerLine;
            StringBuilder result = new StringBuilder(expectedLines * lineLength);

            for (int i = 0; i < bytesLength; i += bytesPerLine)
            {
                line[0] = HexChars[(i >> 28) & 0xF];
                line[1] = HexChars[(i >> 24) & 0xF];
                line[2] = HexChars[(i >> 20) & 0xF];
                line[3] = HexChars[(i >> 16) & 0xF];
                line[4] = HexChars[(i >> 12) & 0xF];
                line[5] = HexChars[(i >> 8) & 0xF];
                line[6] = HexChars[(i >> 4) & 0xF];
                line[7] = HexChars[(i >> 0) & 0xF];

                int hexColumn = firstHexColumn;
                int charColumn = firstCharColumn;

                for (int j = 0; j < bytesPerLine; j++)
                {
                    if (j > 0 && (j & 7) == 0) hexColumn++;
                    if (i + j >= bytesLength)
                    {
                        line[hexColumn] = ' ';
                        line[hexColumn + 1] = ' ';
                        line[charColumn] = ' ';
                    }
                    else
                    {
                        byte b = bytes[i + j];
                        line[hexColumn] = HexChars[(b >> 4) & 0xF];
                        line[hexColumn + 1] = HexChars[b & 0xF];
                        line[charColumn] = (b < 32 ? '·' : (char)b);
                    }
                    hexColumn += 3;
                    charColumn++;
                }
                result.Append(line);
            }
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


     

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void startRead_Click(object sender, EventArgs e)
        {
            
            timer1.Start();
        }

        private void getDbwValues()
        {
            if (消息列表.Items.Count == 3)
            {
                消息列表.Items.Clear();
            }
            ReadDbw();
            int Pos = System.Convert.ToInt32(textBox7.Text);
            int S7Int = S7.GetIntAt(Buffer, Pos);
            textBox8.Text = System.Convert.ToString(S7Int);
            textBox8.Enabled = false;
            消息列表.Items.Add(DateTime.Now.ToString());
            消息列表.Items.Add("从DB" + textBox6.Text + "获取到的DBW" + textBox7.Text + "的值是" + System.Convert.ToString(S7Int));
            消息列表.Items.Add("---");
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void OracleConnect_Click(object sender, EventArgs e)
        {
            string dataSource = dataSourceIp.Text;
            string orcname = orcName.Text;
            string userid = userId.Text;
            string userpw = userPw.Text;

            string M_str_sqlcon = "Data Source=" + dataSource + "/" + orcname + ";User Id=" + userid + ";Password=" + userpw + "";//定义数据库连接字符串
            OracleConnection myCon = new OracleConnection(M_str_sqlcon);
            myCon.Open();
            if (myCon.State == ConnectionState.Open)
            {
                消息列表.Items.Add("连接数据库"+ dataSource + "/" + orcname + "成功");
                OcStatus.BackColor = Color.Green;
                OracleConnect.Enabled = false;
                orcName.Enabled = false;
                userId.Enabled = false;
                userPw.Enabled = false;

                string str_sqlstr = "SELECT TABLE_NAME FROM USER_TABLES";
                string str_sqlTable = "USER_TABLES";

                OracleDataAdapter orcda = new OracleDataAdapter(str_sqlstr, myCon);
                DataSet myds = new DataSet();
                orcda.Fill(myds, str_sqlTable);
                dataGridView1.DataSource = myds.Tables[str_sqlTable];


            }




        }
    

 

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string tableName = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            oracleTableName.Text = tableName;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = System.Convert.ToInt32(readCycle.Text);
            getDbwValues();
        }
    }
}
