using System;

namespace P02_Articles
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author} ";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            string title = input[0];
            string content = input[1];
            string author = input[2];

            var article = new Article(title, content, author);

            int length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                var command = Console.ReadLine().Split(':');
                string method = command[0];
                string newText = command[1].Trim();

                if (method == "Edit")
                {
                    article.Edit(newText);
                }
                else if (method == "ChangeAuthor")
                {
                    article.ChangeAuthor(newText);
                }
                else if (method == "Rename")
                {
                    article.Rename(newText);
                }
            }

            Console.WriteLine(article);
        }
    }
}