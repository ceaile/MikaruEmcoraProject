using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using MikaruEmcora.Application.Interfaces;

namespace MikaruEmcora.Controllers {
    [ApiController]
    [Route("[controller]")] //
    public class MediaController : ControllerBase {
        public MediaController(IMapper mapper, IMediaService mediaService)    // ctor y doble tab para hacer el constructor automatico
        {
            this.mapper = mapper;
            this.mediaService = mediaService;
        }
    }
}
