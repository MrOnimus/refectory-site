using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Canteen.Core.Services
{
    public class FileLoader: IFileLoader
    {
        public async Task<string> LoadImg(IFormFile file)
        {
            string path = "/files/" + Guid.NewGuid().ToString() + "_" + file.FileName;

            using (var fileStream = new FileStream(Directory.GetCurrentDirectory() + "/wwwroot" + path, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            return path;
        }
    }
}
