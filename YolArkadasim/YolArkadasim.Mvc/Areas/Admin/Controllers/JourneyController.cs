using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.CodeAnalysis.CSharp;
using Newtonsoft.Json;
using YolArkadasim.Entities.ComplexTypes;
using YolArkadasim.Entities.Concrete;
using YolArkadasim.Entities.Dtos;
using YolArkadasim.Mvc.Areas.Admin.Models;
using YolArkadasim.Mvc.Helpers.Abstract;
using YolArkadasim.Services.Abstract;
using YolArkadasim.Shared.Utilities.Results.ComplexTypes;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace YolArkadasim.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class JourneyController : BaseController
    {
        private readonly IJourneyService _journeyService;
        private readonly ICategoryService _categoryService;
        

        public JourneyController(IJourneyService journeyService, ICategoryService categoryService,UserManager<User> userManager, IMapper mapper, IImageHelper imageHelper):base(userManager, mapper, imageHelper)
        {
            _journeyService = journeyService;
            _categoryService = categoryService;
            
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var result = await _journeyService.GetAllByNonDeletedAsync();
            if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            return NotFound();
        }
        [HttpGet]
        public async Task<IActionResult> UserIndex()
        {
            var result = await _journeyService.GetAllByNonDeletedAsync();
            if (result.ResultStatus == ResultStatus.Success) return View(result.Data);
            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult>  Add()
        {
            var result = await _categoryService.GetAllByNonDeletedAsync();
            if (result.ResultStatus == ResultStatus.Success)
            {
                return View(new JourneyAddViewModel
                {
                    Categories = result.Data.Categories
                });
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Add(JourneyAddViewModel journeyAddViewModel)
        {
            var category = await _categoryService.GetAllByNonDeletedAndActiveAsync();
            journeyAddViewModel.Categories = category.Data.Categories;
            if (ModelState.IsValid)
            {
                var journeyAddDto = Mapper.Map<JourneyAddDto>(journeyAddViewModel);
                var imageResult = await ImageHelper.Upload(journeyAddViewModel.Title,
                    journeyAddViewModel.ThumbnailFile, PictureType.Post);
                journeyAddDto.Thumbnail = imageResult.Data.FullName;
                var result = await _journeyService.AddAsync(journeyAddDto, /*"Halil Özat"*/LoggedInUser.UserName,LoggedInUser.Id);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    TempData.Add("SuccessMessage", result.Message);
                    return RedirectToAction("Index", "Journey");
                }
                else
                {
                    ModelState.AddModelError("", result.Message);
                }
            }

            var categories = await _categoryService.GetAllByNonDeletedAndActiveAsync();
            journeyAddViewModel.Categories = categories.Data.Categories;
            return View(journeyAddViewModel);
        }




        [HttpGet]
        public async Task<IActionResult> Update(int journeyId)
        {
            var journeyResult = await _journeyService.GetJourneyUpdateDtoAsync(journeyId);
            var categoriesResult = await _categoryService.GetAllByNonDeletedAndActiveAsync();
            if (journeyResult.ResultStatus == ResultStatus.Success && categoriesResult.ResultStatus == ResultStatus.Success)
            {
                var journeyUpdateViewModel = Mapper.Map<JourneyUpdateViewModel>(journeyResult.Data);
                journeyUpdateViewModel.Categories = categoriesResult.Data.Categories;
                return View(journeyUpdateViewModel);
            }
            else
            {
                return NotFound();
            }
        }


        [HttpPost]
        public async Task<IActionResult> Update(JourneyUpdateViewModel journeyUpdateViewModel)
        {
            if (ModelState.IsValid)
            {
                bool isNewThumbnailUploaded = false;
                var oldThumbnail = journeyUpdateViewModel.Thumbnail;
                if (journeyUpdateViewModel.ThumbnailFile != null)
                {
                    var uploadedImageResult = await ImageHelper.Upload(journeyUpdateViewModel.Title,
                        journeyUpdateViewModel.ThumbnailFile, PictureType.Post);
                    journeyUpdateViewModel.Thumbnail = uploadedImageResult.ResultStatus == ResultStatus.Success
                        ? uploadedImageResult.Data.FullName
                        : "postImages/defaultThumbnail.jpg";
                    if (oldThumbnail != "postImages/defaultThumbnail.jpg")
                    {
                        isNewThumbnailUploaded = true;
                    }
                }
                var journeyUpdateDto = Mapper.Map<JourneyUpdateDto>(journeyUpdateViewModel);
                var result = await _journeyService.UpdateAsync(journeyUpdateDto, LoggedInUser.UserName);
                if (result.ResultStatus == ResultStatus.Success)
                {
                    if (isNewThumbnailUploaded)
                    {
                        ImageHelper.Delete(oldThumbnail);
                    }
                    TempData.Add("SuccessMessage", result.Message);
                    return RedirectToAction("Index", "Journey");
                }
                else
                {
                    ModelState.AddModelError("", result.Message);
                }
            }

            var categories = await _categoryService.GetAllByNonDeletedAndActiveAsync();
            journeyUpdateViewModel.Categories = categories.Data.Categories;
            return View(journeyUpdateViewModel);
        }

        [HttpPost]
        public async Task<JsonResult> Delete(int journeyId)
        {
            var result = await _journeyService.DeleteAsync(journeyId, LoggedInUser.UserName);
            var journeyResult = JsonSerializer.Serialize(result);
            return Json(journeyResult);
        }

    }
}
