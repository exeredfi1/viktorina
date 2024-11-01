using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Viktorina
{
    public partial class PANADOBICA : Form
    {
        private List<Question> questions;
        private int currentQuestionIndex;
        private int score;

        public PANADOBICA()
        {
            InitializeComponent();
            InitializeQuiz();
        }

        private void InitializeQuiz()
        {
            questions = new List<Question>();
            currentQuestionIndex = 0;
            score = 0;

            // Вопросы для легкого уровня
            questions.Add(new Question("Что такое MIT App Inventor?", "Инструмент для разработки мобильных приложений"));
            questions.Add(new Question("Какая основная цель MIT App Inventor?", " Развивать навыки программирования у начинающих"));
            questions.Add(new Question("Какой компонент требуется для работы MIT App Inventor?", "aiStarter"));

            // Вопросы для среднего уровня
            questions.Add(new Question("Какое программное обеспечение нужно установить для работы с MIT App Inventor на компьютере с Windows?", "aiStarter"));
            questions.Add(new Question("Проектирование пользовательского интерфейса\r\nКакой элемент пользовательского интерфейса позволяет добавлять кнопки и изображения?", "Конструктор"));
            questions.Add(new Question("Какой язык является основным для веб-разработки?", "JavaScript"));

            // Вопросы для продвинутого уровня
            questions.Add(new Question("Какой компонент используется для установки фона приложения?", "Компонент изображения"));
            questions.Add(new Question("Какой метод используется для увеличения сложности игры в MIT App Inventor?", "Какой метод используется для увеличения сложности игры в MIT App Inventor?"));
            questions.Add(new Question("Какой блок используется для программирования движения мяча в игре?", "Какой блок используется для программирования движения мяча в игре?"));

            lblResult.Text = "";
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            currentQuestionIndex = 0;
            DisplayQuestion();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            currentQuestionIndex = 3; // Начинаем со среднего уровня
            DisplayQuestion();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            currentQuestionIndex = 6; // Начинаем с продвинутого уровня
            DisplayQuestion();
        }

        private void DisplayQuestion()
        {
            if (currentQuestionIndex < questions.Count)
            {
                lblQuestion.Text = questions[currentQuestionIndex].Text;
            }
            else
            {
                lblQuestion.Text = "Викторина завершена! Ваш счет: " + score;
                lblResult.Text = "";
                btnSubmit.Enabled = false; // Отключаем кнопку после окончания викторины
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var currentQuestion = questions[currentQuestionIndex];
            if (txtAnswer.Text.Trim().ToLower() == currentQuestion.Answer.ToLower())
            {
                score++;
                lblResult.Text = "Правильно!";
            }
            else
            {
                lblResult.Text = "Неправильно! Правильный ответ: " + currentQuestion.Answer;
            }

            currentQuestionIndex++;
            txtAnswer.Clear();
            DisplayQuestion();
        }

        private void QuizForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            // Если нужно закрыть текущую форму, раскомментируйте следующую строку:
            this.Hide();
            Start start = new Start();
            // Открываем Form2
            start.Show();
        }
    }

    public class Question
    {
        public string Text { get; set; }
        public string Answer { get; set; }

        public Question(string text, string answer)
        {
            Text = text;
            Answer = answer;
        }
    }
}