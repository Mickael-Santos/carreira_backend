using System.Reflection;
using Balta.ContentContext.Enums;

namespace Balta.ContentContext
{
    public class Course : Content
    {
        public Course(string title, string url, EContentLevel level)
            :base(title, url)
        {
            Modules = new List<Module>();
            Level = level;
        }
        public string ?Tag { get; set; }

        public List<Module> Modules { get; set; }

        public EContentLevel Level { get; set; }
        public int DurationInMinutes { get; set; }
    }
}
