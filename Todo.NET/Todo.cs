﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Todo.NET
{
    public partial class Todo : Form
    {
        String todoLoc = "D:\\Dropbox\\todo\\todo.txt";
        LinkedList<todoItem> todoList = new LinkedList<todoItem>();

        String[] alphabetArr = new String[26] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
            "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        String alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        //LinkedList<String> todoList = new LinkedList<String>();
        public Todo()
        {
            InitializeComponent();

           

            readTodo();
            writeListBox();


        }


        private void readTodo()
        {
            try
            {
                using (StreamReader sr = new StreamReader(todoLoc))
                {
                    String line;
                    Int16 lineCount = 0;
                    while ((line = sr.ReadLine()) != null){

                        String priority, date, todo, project, context;

                        //String[] words = line.Split(' ');

                        if (line[0].Equals("(") && alphabet.IndexOf(line[1], 0) != -1 && line[2].Equals(")"))
                        {
                            priority = line[1].ToString();
                        
                        }
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
            Int16 count = 1;
            foreach (var item in todoList)
            {
                listBox1.Items.Add(count.ToString() + ". " + item);
                count++;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = listBox1.SelectedItem.ToString();
            //string curItem = listView1.SelectedItems.ToString();

            //MessageBox.Show(curItem);

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
