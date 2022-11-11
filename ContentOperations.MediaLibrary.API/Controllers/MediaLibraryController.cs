// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContentOperations.MediaLibrary.API.Controllers
{
    using ContentOperations.MediaLibrary.Application.DataTransferObjects;
    using ContentOperations.MediaLibrary.Application.Interfaces;
    using ContentOperations.MediaLibrary.Domain.Entities;

    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class MediaLibraryController : ControllerBase
    {
        private readonly IMediaLibraryService _mediaLibraryService;

        public MediaLibraryController(IMediaLibraryService mediaLibraryService)
        {
            this._mediaLibraryService = mediaLibraryService;
        }
        // GET: api/<MediaLibraryController>
        [HttpGet]
        public ActionResult<IEnumerable<StorageType>> Get()
        {
            return Ok(this._mediaLibraryService.GetStorageTypes());
        }

        [HttpPost]
        public IActionResult Post([FromBody] MediaStatusDTO dto)
        {
            this._mediaLibraryService.GetMediaFileStatus(dto);

            return this.Ok(dto);
        }
    }
}
