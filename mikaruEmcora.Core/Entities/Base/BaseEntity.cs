using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
estoy haciendo mi primer proyecto de .net core api y frontend en angular. se trata de un portfolio de artista en el que el artista puede iniciar sesion y quitar y poner imagenes de su portfolio.
*/
namespace MikaruEmcora.Core.Entities.Base {
    public class BaseEntity {
        public int Id { get; set; }                         
        public DateTime CreatedAt { get; set; }
        public DateTime LastUpdate { get; set; }  //miEntidad.LastUpdate = DateTime.Now;
    }
}
