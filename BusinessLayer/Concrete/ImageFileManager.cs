﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ImageFileManager : IImageFileService
    {
        IImageFileDal _image;

        public ImageFileManager(IImageFileDal image)
        {
            _image = image;
        }

        public List<ImageFile> GetList()
        {
            return _image.List();
        }
    }
}
