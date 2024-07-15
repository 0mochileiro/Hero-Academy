using Microsoft.AspNetCore.Mvc;
using SHA.Common.Storage;

namespace SHA.ApplicationService.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ImageResourceManagerController : ControllerBase
    {
        private readonly StorageManager _storageManager;

        public ImageResourceManagerController()
        {
            _storageManager = new StorageManager();
        }

        public IActionResult GetStoredImage(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return BadRequest("Image ID cannot be null or empty.");
            }

            try
            {
                var imageBytes = _storageManager.GetStoredImage(id);

                if (imageBytes is null || imageBytes.Length == 0)
                {
                    return NotFound("The request image not found.");
                }

                return File(imageBytes, "image/jpeg");
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred while retrieving the image."); //TODO: Implement application-level logging for file not existing.
            }
        }
    }
}