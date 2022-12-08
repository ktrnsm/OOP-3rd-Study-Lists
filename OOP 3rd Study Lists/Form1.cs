using OOP_3rd_Study_Lists.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_3rd_Study_Lists
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Book b = new Book();
            b.BookName = "XYZ";
            b.BookType = "CXZ";
            b.Page = "123";

            Writer w = new Writer();
            w.Name = "ASD";
            w.LastName = "RTY";

            b.Writer = w;
            w.Books = new List<Book>();

            w.Books.Add(b);

            MessageBox.Show(b.Writer.Name);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Book b = new Book()
            {
                BookName=textBox1.Text,
                BookType=textBox2.Text,
                Page=textBox3.Text,
            };

            Writer w = new Writer()
            {
                Name=textBox4.Text,
                LastName=textBox5.Text
            };

            b.Writer = w;
            w.Books = new List<Book>();
            w.Books.Add(b);
            listBox1.Items.Add(b.ReflectInfo());
        }
    }
}
