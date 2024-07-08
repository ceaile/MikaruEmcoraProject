using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MikaruEmcora.Infraestructure.Repository.Base;
using MikaruEmcora.Infraestructure.Data;
using MikaruEmcora.Core.Entities;
using MikaruEmcora.Core.Repositories;
using System.Data.Entity;

namespace MikaruEmcora.Infraestructure.Repository {
    public class MediaRepository : Repository<Media>, IMediaRepository {
        public MediaRepository(MikaruEmcoraContext dbContext) : base(dbContext) { }


        public async Task<IEnumerable<Media>> GetMediaByTitleAsync(string mediaTitle) { //probablemente no lo use
            return await dbContext.MediaObjs
                .Where(x => x.Title.Contains(mediaTitle))
                .ToListAsync();
        }
    }


 
}
