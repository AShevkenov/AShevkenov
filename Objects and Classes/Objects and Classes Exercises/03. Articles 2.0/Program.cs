using System;
using System.Collections.Generic;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] currentArticle = Console.ReadLine().Split(", ");

            List<Article> articles = new List<Article>();

            while (n != 0)
            {
                n--;
                Article newArticle = new Article(currentArticle[0], currentArticle[1], currentArticle[2]);
                currentArticle = Console.ReadLine().Split(", ");
                articles.Add(newArticle);
            }

            foreach (var item in articles)
            {
                Console.WriteLine(item);
            }
        }

        class Article
        {
            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }

            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }


            public void ChangeAuthor(string author) => Author = author;
            public void Rename(string title) => Title = title;
            public void Edit(string content) => Content = content;

            public override string ToString() => $"{Title} - {Content}: {Author}";


        }
    }
}

