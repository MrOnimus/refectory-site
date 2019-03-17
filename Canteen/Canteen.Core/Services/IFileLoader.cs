using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Canteen.Core.Services
{
    public interface IFileLoader
    {
        Task<string> LoadImg(IFormFile file);
    }
}
