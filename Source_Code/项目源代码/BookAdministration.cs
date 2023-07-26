using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookAdmin
{
    public partial class BookAdministration : Form
    {
        public BookAdministration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new BookSearch().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new BookUpload().Show();
        }
    }
}
