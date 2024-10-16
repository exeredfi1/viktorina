using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viktorina
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            Start start = new Start();
            // Открываем Form2
            start.Show();
            // Если нужно закрыть текущую форму, раскомментируйте следующую строку:
            this.Hide();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAbout_Click(object sender, EventArgs e)
        {
            AboutForm About = new AboutForm();
            // Открываем Form2
            About.Show();
            // Если нужно закрыть текущую форму, раскомментируйте следующую строку:
            this.Hide();
        }

        private void ButtonProfile_Click(object sender, EventArgs e)
        {
            // Если нужно закрыть текущую форму, раскомментируйте следующую строку:
            this.Hide();
            ProfileForm profile = new ProfileForm();
            // Открываем Form2
            profile.Show();
        }
    }
}