using System;

namespace Articles
{
    public class Article            //   60/100 , защо?!?
    {
        public Article (string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public static Article Edit (string newText, Article Article)
        {
            Article.Content = newText;
            return Article;
        }

        public static Article ChangeAuthor (string newText, Article Article)
        {
            Article.Author = newText;
            return Article;
        }

        public static Article Rename (string newText, Article Article)
        {
            Article.Title = newText;
            return Article;
        }

        public override string ToString()
        {
            string result = $"{Title} - {Content}: {Author}";
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            string title = input[0];
            string content = input[1];
            string author = input[1];

            var article = new Article(title, content, author);

            int numCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numCommands; i++)
            {
                string[] tokens = Console.ReadLine().Split(": ");

                string command = tokens[0];
                string newText = tokens[1];

                switch (command)    
                {
                    case "Edit": Article.Edit(newText, article); break;
                    case "ChangeAuthor": Article.ChangeAuthor(newText, article); break;
                    case "Rename":  Article.Rename(newText, article); break;
                }
            }
            Console.WriteLine(article.ToString());
        }
    }
}