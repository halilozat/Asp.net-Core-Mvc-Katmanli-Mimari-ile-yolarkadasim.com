using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using YolArkadasim.Entities.ComplexTypes;
using YolArkadasim.Entities.Dtos;
using YolArkadasim.Shared.Utilities.Results.Abstract;

namespace YolArkadasim.Mvc.Helpers.Abstract
{
    public interface IImageHelper
    {
        Task<IDataResult<ImageUploadedDto>> Upload(string name, IFormFile pictureFile,PictureType pictureType, string folderName = null);
        IDataResult<ImageDeletedDto> Delete(string pictureName);
    }
}
