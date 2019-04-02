using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_Articles_2._0
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

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var articlesList = new List<Article>();

            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine().Split(", ");
                string title = input[0];
                string content = input[1];
                string author = input[2];

                var article = new Article(title, content, author);
                articlesList.Add(article);
            }
            string sortBy = Console.ReadLine();
            if (sortBy == "title")
            {
                articlesList = articlesList.OrderBy(x => x.Title).ToList();
            }
            else if (sortBy =="content")
            {
                articlesList = articlesList.OrderBy(x => x.Content).ToList();
            }
            else if (sortBy == "author")
            {
                articlesList = articlesList.OrderBy(x => x.Author).ToList();
            }

            foreach (var article in articlesList)
            {
                Console.WriteLine(article);
            }
        }
    }
}
