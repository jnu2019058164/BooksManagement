using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookAdmin
{
    
    public partial class BookUpload : Form
    {
        //数据对接准备
        SqlDataAdapter adapter;
        DataTable DT;

        //路径，用于文件操作
        string PathChs;
        string PathSave;
        public BookUpload()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Multiselect = false;
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //根据打开的图像文件创建原始图像大小的Bitmap对象
                Bitmap image = new Bitmap(this.openFileDialog1.FileName);
                //按比例缩放显示（因为Picture的SizeMode属性为Zoom）,但原始图像大小未变
                pictureBox1.Image = image;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //数据库交互准备
            DT = bookAdminDataSet.Tables[0];
            string queryString = "select * from " + DT.TableName;
            adapter = new SqlDataAdapter(queryString, Properties.Settings.Default.BookAdminConnectionString);
            SqlCommandBuilder builer = new SqlCommandBuilder(adapter);
            adapter.InsertCommand = builer.GetInsertCommand();
            //adapter.DeleteCommand = builer.GetDeleteCommand();
            //adapter.UpdateCommand = builer.GetUpdateCommand();
            DataRow r = DT.NewRow();

            //设置添加信息
            r["BookId"] = DateTime.Now.ToString("yyyyMMddhhmmss");
            r["Author"] = textBox5.Text;
            r["Publisher"] = textBox7.Text;
            r["Categories"] = textBox2.Text;
            r["BookName"] = this.button3.Text;
            Byte[] data;
            MemoryStream ms = new MemoryStream();
            if(this.pictureBox1.Image != null)
            {
                this.pictureBox1.Image.Save(ms, this.pictureBox1.Image.RawFormat);
            }
            //存取图片
            data = ms.ToArray();
            r["Cover"] = data;

            
            try
            {
                //移动电子书文档，文件若存在则不做操作
                if (!File.Exists(PathSave))               
                    File.Copy(PathChs, PathSave);

                //更新数据库
                DT.Rows.Add(r);
                adapter.Update(DT);

                //提醒
                MessageBox.Show("书本添加成功！");
            }
            catch
            {
                MessageBox.Show("上传失败，请退出重试，或关闭文件相关应用。");
                this.Close();
            }
          
        }



        private void BookUpload_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“bookAdminDataSet.Book”中。您可以根据需要移动或删除它。
            //填充数据
            try
            {
                this.bookTableAdapter1.Fill(this.bookAdminDataSet.Book);
            }
            //错误则提示，且关闭窗体
            catch
            {
                MessageBox.Show("数据库错误！上传不被允许。");
                this.Close();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //确认文件，同时加载路径信息          
            if (this.openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                //不允许多选中
                this.openFileDialog2.Multiselect = false;
                PathChs = Path.GetFullPath(this.openFileDialog2.FileName);
                PathSave = Environment.CurrentDirectory + "\\statics";
                if (!Directory.Exists(PathSave))
                    Directory.CreateDirectory(PathSave);
                PathSave += "\\";
                PathSave += this.openFileDialog2.SafeFileName;
                this.button3.Text = Convert.ToString(this.openFileDialog2.SafeFileName);
                this.button3.Font = new Font("宋体",7,FontStyle.Bold);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
