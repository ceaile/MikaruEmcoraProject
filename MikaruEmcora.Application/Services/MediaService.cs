using MikaruEmcora.Core.Entities;
using MikaruEmcora.Core.Repositories;
using MikaruEmcora.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MikaruEmcora.Application.Services {
    /**
     * junta la logica del repositorio y las entidades. 
     * no usamos los repos en las capas de dominio y core 
     * y no usamos mas alla de acciones en bdd las entidades de la capa de infraestructura
     * */
    public class MediaService : IMediaService {



        private readonly IMediaRepository mediaRepository;

        //constructor
        public MediaService(IMediaRepository mediaRepository) { //usamos
            this.mediaRepository = mediaRepository;
        }

        public async Task<Media> Create(Media mediaObj) {
            await ValidateMediaObjIfExist(mediaObj);

            var newEntity = await mediaRepository.AddAsync(mediaObj);
            return newEntity;
        }

        public async Task Delete(Media mediaObj) {
            ValidateMediaObjIfNotExist(mediaObj);
            var deletedMediaObj = await mediaRepository.GetByIdAsync(mediaObj.Id);
            if (deletedMediaObj == null)
                throw new ApplicationException($"Entity could not be loaded.");

            await mediaRepository.DeleteAsync(deletedMediaObj);
        }

        public async Task<Media> GetMediaObjById(int mediaObjId) {
            var mediaObj = await mediaRepository.GetByIdAsync(mediaObjId);
            return mediaObj;
        }

        public async Task<IEnumerable<Media>> GetMediaObjByName(string mediaTitle) {
            var mediaList = await mediaRepository.GetMediaObjByTitleAsync(mediaTitle);
            return mediaList;
        }

        public async Task<IEnumerable<Media>> GetMediaList() {
            var mediaList = await mediaRepository.GetAllAsync();
            return mediaList;
        }

        /**
         * Settea la entidad mapeada antes de hacer el cambio en bbdd
         */
        public async Task Update(Media mediaObj) {
            ValidateMediaObjIfNotExist(mediaObj);

            var editMediaObj = await mediaRepository.GetByIdAsync(mediaObj.Id);
            if (editMediaObj == null)
                throw new ApplicationException($"Entity could not be loaded.");

            editMediaObj.Id = mediaObj.Id;
            editMediaObj.AltText = mediaObj.AltText;

            await mediaRepository.UpdateAsync(editMediaObj);
        }

        private async Task ValidateMediaObjIfExist(Media mediaObj) {
            var existingEntity = await mediaRepository.GetByIdAsync(mediaObj.Id);
            if (existingEntity != null)
                throw new ApplicationException($"{mediaObj.ToString()} with this id already exists");
        }

        private void ValidateMediaObjIfNotExist(Media mediaObj) {
            var existingEntity = mediaRepository.GetByIdAsync(mediaObj.Id);
            if (existingEntity == null)
                throw new ApplicationException($"{mediaObj.ToString()} with this id is not exists");
        }





    }
}
