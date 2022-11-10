﻿// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
        private readonly IMediaLibraryService _service;

        public MediaLibraryController(IMediaLibraryService service)
        {
            this._service = service;
        }
        // GET: api/<MediaLibraryController>
        [HttpGet]
        public ActionResult<IEnumerable<StorageFolder>> Get()
        {
            return Ok(this._service.GetStorageFolders());
        }

        [HttpPost]
        public IActionResult Post([FromBody] MediaFileStatusDTO dto)
        {
            this._service.GetMediaFileStatus(dto);

            return this.Ok(dto);
        }
    }
}
