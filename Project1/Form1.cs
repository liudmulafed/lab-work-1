using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        private readonly List<Article> articles = new List<Article>();
        public Form1()
        {
            InitializeComponent();
        }
        public class Article
        {
            public string Author {  get; set; }
            public int Pages { get; set; }
            public string Title { get; set; }
            public string Topic { get; set; }
            public string PublishDate { get; set; }
            public string Place {  get; set; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Article article = new Article()
            {
                Author = txtAuthor.Text,
                Pages = int.Parse(txtPages.Text),
                Topic = txtTopic.Text,
                Title = txtTitle.Text,
                PublishDate = txtDate.Text,
                Place = txtPlace.Text,
            };
            articles.Add(article);
            txtAuthor.Clear();
            txtPages.Clear();
            txtTopic.Clear();
            txtTitle.Clear();
            txtDate.Clear();
            txtPlace.Clear();

            MessageBox.Show("Статтю додано!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (articles.Count == 0)
            {
                MessageBox.Show("Немає збережених статей!");
                return;
            }
            string result = "";
            foreach (var a in articles)
            {
                result += $"Автор: {a.Author}\n" +
                    $"Кількість сторінок: {a.Pages}\n" +
                    $"Назва: {a.Title}\n" +
                    $"Тема: {a.Topic}\n" +
                    $"Дата публікації: {a.PublishDate}\n" +
                    $"Місце: {a.Place}\n" +
                    "______________________________________________________\n";
            }
            MessageBox.Show(result, "Список статей");
        }
    }
}
