using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles2

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

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfArticles = int.Parse(Console.ReadLine());

            List<Article> articlesList = new List<Article>();

            for (int i = 0; i < numberOfArticles; i++)
            {
                string[] inputArticle = Console.ReadLine().Split(", ");

                string title = inputArticle[0];
                string content = inputArticle[1];
                string author = inputArticle[2];

                var article = new Article(title, content, author);
                articlesList.Add(article);
            }

            string orderToPrint = Console.ReadLine();

            switch (orderToPrint)
            {
                case "title": articlesList = articlesList.OrderBy(x => x.Title).ToList() ; break;
                case "content": articlesList = articlesList.OrderBy(x => x.Content).ToList(); break;
                case "author": articlesList = articlesList.OrderBy(x => x.Author).ToList(); break;
            }
            //Console.WriteLine(string.Join(Environment.NewLine, articlesList));.

            foreach (var article in articlesList)
            {
                Console.WriteLine(article);
            }
        }
    }
}
