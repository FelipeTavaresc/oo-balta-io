using Balta.ContentContext;

namespace ContentContext
{
    public class Career : Content
    {
        public Career()
        {
            Items = new List<Careeritem>();
        }
        public IList<Careeritem> Items { get; set; }
        public int TotalCourses => Items.Count; //Expression Body
        
    }
}