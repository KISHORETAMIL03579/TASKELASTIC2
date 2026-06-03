using System.Xml.Linq;

namespace DOMAIN.Entities
{
    public class ReviewDetails
    {
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new();
    }
}
