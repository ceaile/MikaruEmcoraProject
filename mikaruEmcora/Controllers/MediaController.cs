using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using MikaruEmcora.Application.Interfaces;
using MikaruEmcora.DTOs;
using MikaruEmcora.Core.Entities;


namespace MikaruEmcora.Controllers {
    [ApiController]
    [Route("[controller]")] //
    public class MediaController : ControllerBase {
        private readonly IMediaService mediaService;
        private readonly IMapper mapper;  //intermediario entre el dto y la entidad
        public MediaController(IMapper mapper, IMediaService mediaService)    // ctor y doble tab para hacer el constructor automatico
        {
            this.mapper = mapper;
            this.mediaService = mediaService;
        }


        //metodos rest
        [HttpGet("GetMediaObjByName/{mediaTitle}")]   //opcional el objeto, puede devolver una lista
        public async Task<IEnumerable<MediaDTO>> GetMediaObjs(string mediaTitle) {
            //adaptar:
            if (string.IsNullOrWhiteSpace(mediaTitle)) {
                var list = await mediaService.GetMediaList();
                var mapped = mapper.Map<IEnumerable<MediaDTO>>(list);
                return mapped;
            }

            var listByName = await mediaService.GetMediaObjByName(mediaTitle);
            var mappedByName = mapper.Map<IEnumerable<MediaDTO>>(listByName);
            return mappedByName;

        }

        //adaptar:
        [HttpGet("GetMediaObjById/{mediaObjId}")] //url que espera y parametro para llamar esta func
        public async Task<MediaDTO> GetMediaObjById(int mediaObjId) {
            var mediaObj = await mediaService.GetMediaObjById(mediaObjId);
            var mapped = mapper.Map<MediaDTO>(mediaObj);
            return mapped;
        }

        [HttpPost]
        public async Task<MediaDTO> CreateMediaObj(MediaDTO mediaObjViewModel) {
            var mapped = mapper.Map<Media>(mediaObjViewModel);
            if (mapped == null)
                throw new Exception($"Entity could not be mapped.");

            var entityDto = await mediaService.Create(mapped);

            var mappedViewModel = mapper.Map<MediaDTO>(entityDto);
            return mappedViewModel; //devuelve 200 ok o 500 fail
        }

        [HttpPut]
        public async Task UpdateMediaObj(MediaDTO mediaObjViewModel) {
            var mapped = mapper.Map<Media>(mediaObjViewModel);
            if (mapped == null)
                throw new Exception($"Entity could not be mapped.");

            await mediaService.Update(mapped);
        }

        [HttpDelete]
        public async Task DeleteMediaObj(MediaDTO mediaObjViewModel) {
            var mapped = mapper.Map<Media>(mediaObjViewModel);
            if (mapped == null)
                throw new Exception($"Entity could not be mapped.");

            await mediaService.Delete(mapped);
        }
    }

}
