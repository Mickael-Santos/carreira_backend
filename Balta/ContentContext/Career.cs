namespace Balta.ContentContext
{
    public class Career : Content
    {
        public Career(string title, string url)
            :base(title, url)
        {
            Items = new List<CareerItem>();
        }
        public List<CareerItem> Items {get; set;}

        public int TotalCourses => Items.Count();
    }
}
