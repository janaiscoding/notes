using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace please_work
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Messages", typeof(String));

            dataGridView1.DataSource = table;

            dataGridView1.Columns["Messages"].Visible = false;
            dataGridView1.Columns["Title"].Width = 183;

        }
        

        private void txt_Message_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Title_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            txt_Title.Clear();
            txt_Message.Clear();

        }
      
private void btn_Save_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txt_Title.Text, txt_Message.Text);

            txt_Title.Clear();
            txt_Message.Clear();
        }
        private void btn_Read_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            if (index > -1)
            {
                txt_Title.Text = table.Rows[index].ItemArray[0].ToString();
                txt_Message.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            table.Rows[index].Delete();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
