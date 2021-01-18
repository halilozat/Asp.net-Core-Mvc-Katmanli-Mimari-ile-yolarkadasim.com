using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using YolArkadasim.Entities.Concrete;
using YolArkadasim.Services.Abstract;
using YolArkadasim.Shared.Utilities.Results.ComplexTypes;
using YolArkadasim.Mvc.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;

namespace YolArkadasim.Mvc.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin,Editor")]
    [Area("Admin")]
    public class HomeController : Controller
    {

        private readonly ICategoryService _categoryService;
        private readonly IJourneyService _journeyService;
        private readonly ICommentService _commentService;
        private readonly UserManager<User> _userManager;

        public HomeController(ICategoryService categoryService, IJourneyService journeyService, ICommentService commentService, UserManager<User> userManager)
        {
            _categoryService = categoryService;
            _journeyService = journeyService;
            _commentService = commentService;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var categoriesCountResult = await _categoryService.CountByNonDeletedAsync();
            var journeysCountResult = await _journeyService.CountByNonDeletedAsync();
            var commentsCountResult = await _commentService.CountByNonDeletedAsync();
            var usersCount = await _userManager.Users.CountAsync();
            var journeysResult = await _journeyService.GetAllAsync();
            if (categoriesCountResult.ResultStatus == ResultStatus.Success && journeysCountResult.ResultStatus == ResultStatus.Success && commentsCountResult.ResultStatus 
                == ResultStatus.Success && usersCount > -1 && journeysCountResult.ResultStatus == ResultStatus.Success)
            {
                return View(new DashboardViewModel
                {
                    CategoriesCount = categoriesCountResult.Data,
                    JourneysCount = journeysCountResult.Data,
                    CommentsCount = commentsCountResult.Data,
                    UsersCount = usersCount,
                    Journeys = journeysResult.Data
                });
            }
            return NotFound();
        }
    }
}
