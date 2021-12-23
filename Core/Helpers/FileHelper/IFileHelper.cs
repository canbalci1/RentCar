﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;





namespace Core.Helpers.FileHelper
{
    public interface IFileHelper
    {
        string Upload(IFormFile file, string root);
        void Delete(string filePath);
        string Update(IFormFile file, string filePath, string root);
    }
}
