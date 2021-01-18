using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YolArkadasim.Entities.Concrete;
using YolArkadasim.Entities.Dtos;

namespace YolArkadasim.Mvc.Areas.Admin.Models
{
    public class DashboardViewModel
    {
        public int CategoriesCount { get; set; }
        public int JourneysCount { get; set; }
        public int CommentsCount { get; set; }
        public int UsersCount { get; set; }
        public JourneyListDto Journeys { get; set; }
    }
}
