using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Todo.NET
{
    public partial class Todo : Form
    {
        public Todo()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                //listView1.Items.Add(i.ToString());
                listBox1.Items.Add(i.ToString());
            }

            //label1.Text = "test";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBox1.SelectedItem.ToString();
            //string curItem = listView1.SelectedItems.ToString();

            MessageBox.Show(curItem);

            label1.Text = curItem;
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            string curItem = listBox1.SelectedItem.ToString();
            //string curItem = listView1.SelectedItems.ToString();

            MessageBox.Show(curItem);

            label1.Text = curItem;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void onlineHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.jonathanjsimon.com");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

    }
}
