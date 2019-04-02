using System;

namespace Articles1
{

    public class Article                    
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

        public void Edit(string newText)
        {
            Content = newText;
        }

        public void ChangeAuthor (string newText)
        {
            Author = newText;
        }

        public void Rename (string newText)
        {
            Title = newText;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");

            string title = input[0];
            string content = input[1];
            string author = input[2];

            var article = new Article(title, content, author);

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commandInput = Console.ReadLine().Split(": ");

                string command = commandInput[0];
                string newText = commandInput[1];

                switch (command)
                {
                    case "Edit": article.Edit(newText); break;
                    case "ChangeAuthor": article.ChangeAuthor(newText); break;
                    case "Rename": article.Rename(newText); break;
                }
            }
            Console.WriteLine(article);
        }
    }
}