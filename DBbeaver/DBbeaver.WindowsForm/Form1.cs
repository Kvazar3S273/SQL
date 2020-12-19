using DBbeaver.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBbeaver.WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyContext context = new MyContext();
            foreach (var item in context.Departments)
            {
                object[] row =
                {
                    $" {item.Id}",
                    $" {item.Name}"
            };
                dataGridView1.Rows.Add(row);
            }
        }
    }
}
