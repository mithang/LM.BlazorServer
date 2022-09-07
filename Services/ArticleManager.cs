namespace LM.BlazorServer.Services;

public class ArticleManager
{
    public class NewArticle
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Content { get; set; }
        public List<String> Categories { get; set; }
        public List<String> Authors { get; set; }
        public List<NewArticle> NewArticles { get; set; }

        public NewArticle()
        {
            Categories = new List<string>();
            Authors = new List<string>();
            NewArticles = new List<NewArticle>();
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