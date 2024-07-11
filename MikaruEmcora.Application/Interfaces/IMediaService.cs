using MikaruEmcora.Core.Entities;
using MikaruEmcora.Core.Entities.Base;
using MikaruEmcora.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MikaruEmcora.Application.Interfaces {
    public interface IMediaService {
        //funcionalidades  
        Task<IEnumerable<Media>> GetMediaList();
        Task<Media> GetMediaObjById(int mediaObjId);
        Task<IEnumerable<Media>> GetMediaObjByName(string mediaObj);
        Task Update(Media mediaObj);
        Task Delete(Media mediaObj);
    }
}
