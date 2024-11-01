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

namespace Viktorina
{
    public partial class TheoryForm : Form
    {
        public TheoryForm()
        {
            InitializeComponent();
            string htmlFilePath = Path.Combine(Application.StartupPath, "math_blocks" +
                ".html");
            webBrowser1.Navigate(htmlFilePath);
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {

            //// Если нужно закрыть текущую форму, раскомментируйте следующую строку:
            this.Hide();
            Start Start = new Start();
            //// Открываем Form2
            Start.Show();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void TheoryForm_Load(object sender, EventArgs e)
        {
            RefreshBrowser();
        }
        private void RefreshBrowser()
        {
            webBrowser1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string htmlFilePath = Path.Combine(Application.StartupPath, "math_blocks" +
               ".html");
            webBrowser1.Navigate(htmlFilePath);
        }
    }
}

