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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            String saveLocation = Environment.GetEnvironmentVariable("APPDATA") + @"\Todo.NET\settings";
        }
    }
}
