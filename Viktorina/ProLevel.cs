using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Viktorina
{
    public partial class ProLevel : Form
    {
        private OleDbConnection connection;
        private List<Questions> selectedQuestions = new List<Questions>();
        private int currentQuestionIndex = 0;
        private List<string> userAnswers = new List<string>();

        public ProLevel()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadRandomQuestions();
            DisplayCurrentQuestion();
        }

        // Подключение к базе данных Access
        private void InitializeDatabase()
        {
            // Укажите путь к вашей базе данных Access
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\test.mdb;";
            connection = new OleDbConnection(connectionString);
            connection.Open();
        }

        // Загрузка случайных вопросов по одному из каждого блока
        private void LoadRandomQuestions()
        {
            Random rand = new Random();
            for (int block = 1; block <= 5; block++)
            {
                string query = "SELECT * FROM Questions WHERE BlockId = ?";
                OleDbCommand command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@BlockId", block);

                List<Questions> questions = new List<Questions>();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        questions.Add(new Questions
                        {
                            QuestionId = reader.GetInt32(0),
                            BlockId = reader.GetInt32(1),
                            QuestionText = reader.GetString(2),
                            OptionA = reader.GetString(3),
                            OptionB = reader.GetString(4),
                            OptionC = reader.GetString(5),
                            OptionD = reader.GetString(6),
                            CorrectAnswer = reader.GetString(7)
                        });
                    }
                }
                if (questions.Count > 0)
                {
                    int randomIndex = rand.Next(questions.Count);
                    selectedQuestions.Add(questions[randomIndex]);
                }
                else
                {
                    MessageBox.Show($"В блоке {block} нет вопросов.");
                }
            }
        }

        // Отображение текущего вопроса
        private void DisplayCurrentQuestion()
        {
            if (currentQuestionIndex < selectedQuestions.Count)
            {
                var question = selectedQuestions[currentQuestionIndex];
                labelQuestion.Text = question.QuestionText;
                radioButtonA.Text = question.OptionA;
                radioButtonB.Text = question.OptionB;
                radioButtonC.Text = question.OptionC;
                radioButtonD.Text = question.OptionD;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            string selectedAnswer = null;
            if (radioButtonA.Checked) selectedAnswer = radioButtonA.Text;
            if (radioButtonB.Checked) selectedAnswer = radioButtonB.Text;
            if (radioButtonC.Checked) selectedAnswer = radioButtonC.Text;
            if (radioButtonD.Checked) selectedAnswer = radioButtonD.Text;

            if (selectedAnswer != null)
            {
                userAnswers.Add(selectedAnswer);
                currentQuestionIndex++;
                if (currentQuestionIndex < selectedQuestions.Count)
                {
                    DisplayCurrentQuestion();
                }
                else
                {
                    MessageBox.Show("Вы завершили тест. Нажмите Завершить для просмотра результатов.");
                    buttonNext.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Выберите один из вариантов ответа!");
            }
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            string results = "Результаты теста:\n\n";
            for (int i = 0; i < selectedQuestions.Count; i++)
            {
                var question = selectedQuestions[i];
                results += $"Вопрос {i + 1}: {question.QuestionText}\n";
                results += $"Ваш ответ: {userAnswers[i]}\n";
                if (userAnswers[i] != question.CorrectAnswer)
                {
                    results += $"Правильный ответ: {question.CorrectAnswer}\n";
                }
                results += "\n";
            }
            MessageBox.Show(results);
        }
    }
}
