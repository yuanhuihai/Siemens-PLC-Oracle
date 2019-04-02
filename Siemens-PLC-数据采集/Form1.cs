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
            listInfo.Text = Client.ErrorText(Result) + " (" + Client.ExecTime().ToString() + " ms)";
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

            listInfo.Items.Add("断开IP地址为 " + textBox1.Text + "的连接");
         

        }

        private void connectPlc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                listInfo.Items.Add("PLC IP 地址不能为空!");
                textBox1.Focus();
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                listInfo.Items.Add("PLC机架号不能为空!");
                textBox2.Focus();
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                listInfo.Items.Add("PLC插槽不能为空!");
                textBox3.Focus();
            }
            else
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

                    listInfo.Items.Add("建立IP地址为 " + textBox1.Text + "的连接成功");
                  
                }
            }
           
        }

        private void ReadDbw()
        {
            int DBNumber;
            int Size = 10;
            int Result;

            DBNumber = System.Convert.ToInt32(dbNum.Text);
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void startRead_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(readCycle.Text))
            {
                listInfo.Items.Add("循环时间不能为空!");
                readCycle.Focus();
            }
            if (string.IsNullOrEmpty(dbNum.Text))
            {
                listInfo.Items.Add("DB字段不能为空!");             
                dbNum.Focus();
            }
            if (string.IsNullOrEmpty(dbwNum.Text))
            {
                listInfo.Items.Add("DBW字段不能为空!");
                dbwNum.Focus();
            }
            else
            {
                timer1.Start();
            }
          
        }

        private void getDbwValues()
        {

           
                ReadDbw();
                int Pos = System.Convert.ToInt32(dbwNum.Text);
                int S7Int = S7.GetIntAt(Buffer, Pos);
                textBox8.Text = System.Convert.ToString(S7Int);
                textBox8.Enabled = false;
                listInfo.Items.Add(DateTime.Now.ToString());
                listInfo.Items.Add("从DB" + dbNum.Text + "获取到的DBW" + dbwNum.Text + "的值是" + System.Convert.ToString(S7Int));
                listInfo.Items.Add("---");
               




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

            if (string.IsNullOrEmpty(dataSourceIp.Text))
            {
                listInfo.Items.Add("数据库IP地址不能为空!");
                dataSourceIp.Focus();
            }
            if (string.IsNullOrEmpty(orcName.Text))
            {
                listInfo.Items.Add("数据库实例名不能为空!");
                orcName.Focus();
            }
            if (string.IsNullOrEmpty(userId.Text))
            {
                listInfo.Items.Add("用户名不能为空!");
                userId.Focus();
            }
            if (string.IsNullOrEmpty(userPw.Text))
            {
                listInfo.Items.Add("密码不能为空!");
                userPw.Focus();
            }
            else
            {
                string M_str_sqlcon = "Data Source=" + dataSource + "/" + orcname + ";User Id=" + userid + ";Password=" + userpw + "";//定义数据库连接字符串
                OracleConnection myCon = new OracleConnection(M_str_sqlcon);
                myCon.Open();
                if (myCon.State == ConnectionState.Open)
                {
                    listInfo.Items.Add("连接数据库" + dataSource + "/" + orcname + "成功");
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
            if (listInfo.Items.Count == 6)
            {
                listInfo.Items.Clear();
            }
            readStatus.BackColor = Color.Green;
        }
    }
}
