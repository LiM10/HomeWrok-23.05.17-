using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Fayl yaradilir
        string fayl = Environment.CurrentDirectory + "/" + "test.txt";

        // Create Button
        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(fayl))
            {
                File.CreateText(fayl);
                MessageBox.Show("Fayl ugurla yaradildi.");
            }
        }

        // Write Text
        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamWriter write = new StreamWriter(fayl))
            {
                write.WriteLine("Test ucun yaradilmis fayl");
            }
        }


        // Read Text
        private void button3_Click(object sender, EventArgs e)
        {
            using (StreamReader read = new StreamReader(fayl))
            {
                string text = read.ReadLine();
                richTextBox1.Text = text;
            }
        }

        // Delete File
        private void button4_Click(object sender, EventArgs e)
        {
            if (File.Exists(fayl))
            {
                File.Delete(fayl);
                MessageBox.Show("Fayl silindi.");
            }
        }

        // Rename file
        private void button5_Click(object sender, EventArgs e)
        {
            if (File.Exists(fayl))
            {
                File.Move(
                    @"C:\Users\ismay\OneDrive\Documents\Visual Studio 2017\Projects\HomeWork\HomeWork\bin\Debug\test.txt",
                    @"C:\Users\ismay\OneDrive\Documents\Visual Studio 2017\Projects\HomeWork\HomeWork\bin\Debug\newTest.txt"
                        );
            }
        }
    }
}
