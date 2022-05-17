using First_site_V2.Storage;
using First_site_V2.Storage.Entities;
using Microsoft.AspNetCore.Http;

namespace First_site_V2.Logic.Photoes
{
    public class PhotoManager : IPhotoManager
    {
        GaisContext context;
        public PhotoManager(GaisContext _context)
        {
            context = _context;
        }
        public int Create(IFormFile photo, int id)
        {
            using (var memoryStream = new MemoryStream())
            {
                photo.CopyTo(memoryStream);

                var instanceOfPhoto = new Photo
                {
                    IsProfilePNG = false,
                    PNGinBytes = memoryStream.ToArray(),
                    UserId = id
                };

                context.Photos.Add(instanceOfPhoto);
                context.SaveChanges();

                return instanceOfPhoto.Id;
            }
        }

        public byte[] PNGInBytes(IFormFile photo)
        {
            byte[] pnginbytes;
            using (var memoryStream = new MemoryStream())
            {
                photo.CopyTo(memoryStream);
                pnginbytes = memoryStream.ToArray();
            }
            return pnginbytes;
            
        }
    }
}
