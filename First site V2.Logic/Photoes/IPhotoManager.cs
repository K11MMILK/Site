using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_site_V2.Logic.Photoes
{
    public interface IPhotoManager
    {
        int Create(IFormFile photo, int id);
        //bool PhotoExist(int PhotoId)
        byte[] PNGInBytes(IFormFile photo);
    }
}
