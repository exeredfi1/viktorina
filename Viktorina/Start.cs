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
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            // Если нужно закрыть текущую форму, раскомментируйте следующую строку:
            this.Hide();
            MainMenu mainmenu = new MainMenu();
            // Открываем Form2
            mainmenu.Show();
        }

        private void ButtonEasy_Click(object sender, EventArgs e)
        {
            PANADOBICA testtesta = new PANADOBICA();
            // Открываем Form2
            testtesta.Show();
            // Если нужно закрыть текущую форму, раскомментируйте следующую строку:
            this.Hide();
        }

        private void ButtonTheory_Click(object sender, EventArgs e)
        {
            TheoryForm theory = new TheoryForm();
            // Открываем Form2
            theory.Show();
            // Если нужно закрыть текущую форму, раскомментируйте следующую строку:
            this.Hide();

        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void ButtonNormal_Click(object sender, EventArgs e)
        {
            QuizForm quizform = new QuizForm();
            // Открываем Form2
            quizform.Show();
            // Если нужно закрыть текущую форму, раскомментируйте следующую строку:
            this.Hide();
        }

        private void ButtonHard_Click(object sender, EventArgs e)
        {
            ProLevel ProLevel = new ProLevel();
            // Открываем Form2
            ProLevel.Show();
            // Если нужно закрыть текущую форму, раскомментируйте следующую строку:
            this.Hide();
        }
    }
}
