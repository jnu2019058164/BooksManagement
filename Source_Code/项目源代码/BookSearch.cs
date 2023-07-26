using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;

namespace BookAdmin
{
    public partial class BookSearch : Form
    {
        SqlDataAdapter adapter;
        public BookSearch()
        {
            InitializeComponent();
        }

        private void BookSearch_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“bookAdminDataSet.Book”中。您可以根据需要移动或删除它。
            try
            {
                this.bookTableAdapter.Fill(this.bookAdminDataSet.Book);
            }
            catch
            {
                MessageBox.Show("数据库错误！是否未连接数据库？");
                this.Close();
            }
            
            this.dataGridViewTextBoxColumn1.ReadOnly = true;           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //搜索，结果填充到数据集
            //使用sql语句搜索相关项
            string search = "select * from " + 
                this.bookAdminDataSet.Book.TableName + 
                " where BookName Like '%" + 
                textBox1.Text + "%' or " +
                "Author Like '%" +
                textBox1.Text + "%' or " +
                "Publisher Like '%" +
                textBox1.Text + "%' or " +
                "Categories Like '%" +
                textBox1.Text + "%' or " +
                "BookId Like '%" +
                textBox1.Text + "%'";
            adapter = new SqlDataAdapter(search, Properties.Settings.Default.BookAdminConnectionString);
            DataTable dt = bookAdminDataSet.Tables[0];
            this.bookAdminDataSet.Book.Clear();
            adapter.Fill(this.bookAdminDataSet.Book);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //点击图片打开文件
            if (this.textBox2.Text.Length != 0)
            {
                Process p = new Process();
                p.StartInfo.FileName = Path.GetFullPath("statics") + "\\" + this.textBox2.Text;
                p.Start();
            }
            else
            {
                MessageBox.Show("未选中文件");
            }
        }

        private void bookDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //表格与书名栏和图片框有数据绑定
            try
            {
                this.textBox2.DataBindings.Add("Text", bookBindingSource, "BookName");
                pictureBox1.DataBindings.Add("Image", bookBindingSource, "Cover");
            }
            catch
            {
                return;
            }
        }
    }
}
