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
            questions.Add(new Question("Сколько будет 2 + 2?", "4"));
            questions.Add(new Question("Какой цвет у неба?", "голубой"));
            questions.Add(new Question("Сколько дней в неделе?", "7"));

            // Вопросы для среднего уровня
            questions.Add(new Question("Кто написал 'Войну и мир'?", "Толстой"));
            questions.Add(new Question("Какой элемент имеет символ 'O'?", "Кислород"));
            questions.Add(new Question("Какой язык является основным для веб-разработки?", "JavaScript"));

            // Вопросы для продвинутого уровня
            questions.Add(new Question("Какой алгоритм используется для сортировки?", "Сортировка слиянием"));
            questions.Add(new Question("Что такое ООП?", "Объектно-ориентированное программирование"));
            questions.Add(new Question("Какое число является квадратом 16?", "256"));

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