using Balta.SharedContext;

namespace Balta.ContentContext
{
    public class Module : Base
    {
        public Module()
        {
            Lectures = new List<Lecture>();
        }
        public int Order { get; set; }

        public string ?Title { get; set; }

        public List<Lecture> ?Lectures {get; set;}
    }
}