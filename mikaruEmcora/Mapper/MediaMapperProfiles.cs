using AutoMapper;
using MikaruEmcora.DTOs;
using MikaruEmcora.Core.Entities;

namespace MikaruEmcora.Mapper {
    public class MediaMapperProfiles : Profile {



        public MediaMapperProfiles() { 
            CreateMap<MediaDTO, Media>().ReverseMap().IgnoreAllPropertiesWithAnInaccessibleSetter(); //convierte el mediadto a objeto de entidad media
            //reverse map hace que si recibe un objeto lo convierta a dto
            //si uno no tiene atributos que el otro tenga, se puede hacer que los ignore para ahorrar errores
        }
    }
}
