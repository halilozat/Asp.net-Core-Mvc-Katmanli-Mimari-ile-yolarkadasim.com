using System;
using System.Collections.Generic;
using System.Text;
using YolArkadasim.Shared.Entities.Abstract;

namespace YolArkadasim.Entities.Concrete
{
    public class Journey:EntityBase,IEntity
    {
        //public int JourneyId { get; set; }
        public string JourneyStart { get; set; }
        public string JourneyFinish { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Thumbnail { get; set; }
        public DateTime Date { get; set; }
        public int ViewCount { get; set; } = 0;
        public int CommentCount { get; set; } = 0;
        public string SeoAuthor { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTags { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } // bir yolculuğun bir kategorisi olmak zorunda.
        public int UserId { get; set; }
        public User User { get; set; }


        //public int CityId { get; set; }
        //public City City { get; set; }  
        public ICollection<Comment> Comments { get; set; } // Bir yolculuğun birden fazla yorumun olabilir
    }
}
