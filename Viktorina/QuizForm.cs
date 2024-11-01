using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Viktorina
{
    public partial class QuizForm : Form
    {
        private int currentIndex = 0;
        private int points = 0;

        // Список вопросов и ответов
        private List<QuestionItem> quizQuestions = new List<QuestionItem>
        {
            new QuestionItem("Что такое MIT App Inventor?", new string[] { "Среда для создания веб-приложений", "Инструмент для разработки мобильных приложений", "Программа для редактирования видео", "Программное обеспечение для редактирования " }, 1),
            new QuestionItem("Какая основная цель MIT App Inventor?", new string[] { "Развивать навыки программирования у начинающих", "Создавать сложные серверные приложения", "Использовать машинное обучение", "Разрабатывать видеоигры" }, 0),
            new QuestionItem("Какой компонент требуется для работы MIT App Inventor?", new string[] { "aiStarter", "Blender", "Adobe Photoshop", "Unity" }, 0),
            new QuestionItem("Какое программное обеспечение нужно установить для работы с MIT App Inventor на компьютере с Windows?", new string[] { "Android Studio", "aiStarter", "Unity Hub", "Xcode" }, 1),
            new QuestionItem("Какой компонент используется для установки фона приложения?", new string[] { "Фоновая кнопка", "ActivityStarter", "Компонент изображения", "Блок-навигация" }, 2),
            new QuestionItem("Какой метод используется для увеличения сложности игры в MIT App Inventor?", new string[] { "Увеличение числа уровней", "Добавление новых героев", "Замедление игры", "Уменьшение очков" }, 0),
            new QuestionItem("Какой блок используется для программирования движения мяча в игре?", new string[] { "EdgeReached", "Ball1.EdgeReached", "Player.Move", "Action.Reach" }, 1),
            new QuestionItem("Что такое альфа-тестирование?", new string[] { "Тестирование, проведенное группой пользователей", "Тестирование перед запуском приложения", "Обновление приложения", "Программирование нового компонента" }, 0),
            new QuestionItem("Какая фаза является завершающей в дизайне приложений?", new string[] { "Тестирование", "Прототипирование", "Настройка", "Визуальная оптимизация" }, 0),







        };

        public QuizForm()
        {
            InitializeComponent();
            DisplayQuestion();
        }

        private void DisplayQuestion()
        {
            if (currentIndex < quizQuestions.Count)
            {
                var currentQuestion = quizQuestions[currentIndex];
                questionTextLabel.Text = currentQuestion.Text;
                scoreDisplayLabel.Text = $"Баллы: {points}";

                // Устанавливаем текст для каждой кнопки
                optionButton1.Text = currentQuestion.Options[0];
                optionButton2.Text = currentQuestion.Options[1];
                optionButton3.Text = currentQuestion.Options[2];
                optionButton4.Text = currentQuestion.Options[3];

                // Устанавливаем индекс ответа в свойство Tag каждой кнопки
                optionButton1.Tag = 0;
                optionButton2.Tag = 1;
                optionButton3.Tag = 2;
                optionButton4.Tag = 3;
            }
            else
            {
                MessageBox.Show($"Спасибо за участие! Ваш итоговый балл: {points}");
                // Если нужно закрыть текущую форму, раскомментируйте следующую строку:
                this.Hide();
                Start start = new Start();
                // Открываем Form2
                start.Show();
            }
        }

        private void OptionButton_Click(object sender, EventArgs e)
        {
            var selectedButton = sender as System.Windows.Forms.Button;
            int chosenAnswer = (int)selectedButton.Tag;

            if (chosenAnswer == quizQuestions[currentIndex].CorrectAnswer)
            {
                points++;
                MessageBox.Show("Вы молодец! +1 балл");
            }
            else
            {
                MessageBox.Show("Неправильный ответ");
            }

            currentIndex++;
            DisplayQuestion();
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

    public class QuestionItem
    {
        public string Text { get; }
        public string[] Options { get; }
        public int CorrectAnswer { get; }

        public QuestionItem(string text, string[] options, int correctAnswer)
        {
            Text = text;
            Options = options;
            CorrectAnswer = correctAnswer;
        }
    }
}
