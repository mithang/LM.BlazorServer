namespace LM.BlazorServer.Services;

public class ArticleManager
{
    public class NewArticle
    {
        public int Id{ get; set;}
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Content { get; set; }
        
        public DateTime DatePublish { get; set; }
        public List<String> Categories { get; set; }
        public List<String> Authors { get; set; }
        public List<NewArticle> NewArticles { get; set; }

        public NewArticle()
        {
            Categories = new List<string>();
            Authors = new List<string>();
            NewArticles = new List<NewArticle>();
           
        }

        public List<NewArticle> GetNewArticles(string keysearch=null)
        {
            List<NewArticle> list = new List<NewArticle>(){
                new NewArticle()
                {
                    Id = 1,
                    Title = "Title 1",
                    DatePublish = DateTime.Now
                },
                new NewArticle()
                {
                    Id = 2,
                    Title = "Title 2",
                    DatePublish = DateTime.Now.AddDays(14)
                }
            };
            if (String.IsNullOrEmpty(keysearch))
            {
                return list;
            }

            return list.FindAll(op => op.Title.Contains(keysearch));
        }
        public void AddNewArticle(NewArticle article)
        {
            NewArticles.Add(article);
        }

        public void AddAuthors(string author)
        {
            Authors.Add(author);
        }
        public void RemoveAuthors(string author)
        {
            Authors.Remove(author);
        }
    }
}