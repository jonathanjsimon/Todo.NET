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

        //SettingsStorage settingsObj;

        public Boolean debug = false;
        public Boolean backup = true;

        public static String todoLoc = @"D:\Dropbox\todo\todo.txt";
        public static String todoBakLoc = todoLoc + ".bak";
        //String todoBakLoc = "D:\\Dropbox\\todo\\todo.txt.bak";

        String homeFolder = Environment.GetEnvironmentVariable("USERPROFILE");


        //String todoLoc = "F:\\todo\\todo.txt";
        List<todoItem> todoList = new List<todoItem>();
        /*
        String[] alphabetArr = new String[26] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
            "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        String alphabet = @"ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        */
        Boolean isWritingList = false;

        public Todo()
        {
            InitializeComponent();

            loadSettings();

            readTodo();
            writeListBox();
        }


        private void loadSettings()
        {

            //settingsObj = new SettingsStorage(@"D:\Dropbox\todo\todo.txt", true, false, true);
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

                    todoItem newItem;

                    while ((line = sr.ReadLine()) != null){

                        lineCount++;

                        newItem = parseTodo(line, lineCount);
                        
                        todoList.Add(newItem);

                        if (debug) Console.WriteLine(newItem.ToString());
                    }

                }

            }
            catch (Exception e)
            {

                String message = todoLoc + " could not be accessed\n" + e.Message;
                MessageBox.Show(message);

            }
        }

        private todoItem parseTodo(String todoFull, Int16 lineCount)
        {
            String priority = "", date = "", todo = "", project = "", context = "";

            String[] words = todoFull.Split(' ');

            foreach (var word in words)
            {
                if (Regex.Match(word, @"^\([ABCDEFGHIJKLMNOPQRSTUVWXYZ]\)", RegexOptions.IgnoreCase).Success)
                {
                    priority = word[1].ToString();
                    if (debug) Console.WriteLine(priority);

                }
                else if (Regex.Match(word, @"^2[0-9][0-9][0-9]\-[0-9][0-9]\-[0-9][0-9]", RegexOptions.IgnoreCase).Success)
                {
                    date = word;
                    if (debug) Console.WriteLine(date);
                }
                else if (Regex.Match(word, @"^\+[a-zA-Z0-9]+", RegexOptions.IgnoreCase).Success)
                {
                    project = word;
                    if (debug) Console.WriteLine(project);
                }
                else if (Regex.Match(word, @"^@[a-zA-Z0-9]+", RegexOptions.IgnoreCase).Success)
                {
                    context = word;
                    if (debug) Console.WriteLine(context);
                }
                else
                {
                    todo = todo + " " + word;
                }
            }

            return new todoItem(lineCount.ToString(), priority, date, todo, project, context, todoFull);
        }

        private void addTodo(String todoFull)
        {
            string testfile = "D:\\Dropbox\\todo\\testfile.txt";

            //if (File.Exists(todoLoc)){

            try
            {

                if (backup)
                    File.Copy(todoLoc, todoBakLoc, true);



                using (StreamWriter sw = File.AppendText(todoLoc))
                {
                    sw.WriteLine(todoFull);
                }

                if (debug)
                {
                    using (StreamReader sr = new StreamReader(todoLoc))
                    {
                        String line;

                        while ((line = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }

                readTodo();
                writeListBox();

            }
            catch (Exception e)
            {
                String message = todoLoc + " could not be accessed\n" + e.Message;
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

            Console.WriteLine(todoList.Count);

            for (int i = 0; i < todoList.Count; i++)
            {
                todoListBox.Items.Add(todoList[i].ToString());

                Console.WriteLine(todoList[i].ToString());
            }

            /*
            Int16 count = 1;
            foreach (var item in todoList)
            {
                //todoListBox.Items.Add(((todoItem)item). + " " + item.ToString());
                todoListBox.Items.Add(todoList[count] + " " + item.ToString());
                count++;
            }
            */


            isWritingList = false;
        }

        private void todoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isWritingList && todoListBox.SelectedItem != null)
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
            about.ShowDialog();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            readTodo();
            writeListBox();
        }

        private void writeTest_Click(object sender, EventArgs e)
        {
            addTodo(todoLineBox.Text);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settingsWindow = new Settings();
            settingsWindow.ShowDialog();
        }

    }
}
