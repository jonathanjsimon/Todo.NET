using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Todo.NET
{
    public partial class Todo : Form
    {
        //String todoLoc = "D:\\Dropbox\\todo\\todo.txt";
        String todoLoc = "F:\\todo\\todo.txt";
        LinkedList<todoItem> todoList = new LinkedList<todoItem>();

        String[] alphabetArr = new String[26] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
            "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        Boolean isWritingList = false;

        //LinkedList<String> todoList = new LinkedList<String>();
        public Todo()
        {
            InitializeComponent();

           

            readTodo();
            writeListBox();


        }


        private void readTodo()
        {
            todoList.Clear();
            try
            {
                using (StreamReader sr = new StreamReader(todoLoc))
                {
                    String line;
                    Int16 lineCount = 0;
                    while ((line = sr.ReadLine()) != null){

                        String priority, date, todo, project, context;

                        String[] words = line.Split(' ');
                        //Console.WriteLine("{0}, {1}, {2} ", line[0], line[1], line[2]);
                        //if (line[0].ToString().Equals("(") && alphabet.IndexOf(line[1].ToString(), 0) != -1 && line[2].ToString().Equals(")"))
                        if (Regex.Match(words[0], @"^\([ABCDEFGHIJKLMNOPQRSTUVWXYZ]\)",RegexOptions.IgnoreCase).Success)
                        {
                            priority = line[1].ToString();
                            MessageBox.Show(priority);
                        
                        }

                        todoList.AddLast(new todoItem(line));
                    }


                        //todoList.AddLast(line);

                    /*

                    */
                }

            }
            catch (Exception e)
            {

                String message = todoLoc + " could not be read\n" + e.Message;
                MessageBox.Show(message);

            }
        }

        private void writeListBox()
        {

            isWritingList = true;

            while (todoListBox.Items.Count > 0)
            {
                todoListBox.Items.RemoveAt(0);
            }
            

            Int16 count = 1;
            foreach (var item in todoList)
            {
                todoListBox.Items.Add(count.ToString() + ". " + item.ToString());
                count++;
            }

            isWritingList = false;
        }

        private void todoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isWritingList)
            {
                string curItem = todoListBox.SelectedItem.ToString();
                //string curItem = listView1.SelectedItems.ToString();

                //MessageBox.Show(curItem);

                label1.Text = curItem;
                todoLineBox.Text = curItem;
            }
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

        private void refreshButton_Click(object sender, EventArgs e)
        {
            readTodo();
            writeListBox();
        }

    }
}
