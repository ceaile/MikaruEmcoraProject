using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MikaruEmcora.Core.Entities;
using MikaruEmcora.Core.Entities.Base;
using MikaruEmcora.Core.Repositories.Base;

namespace MikaruEmcora.Core.Repositories
{
    public interface IMediaRepository : IRepository<Media>
    {
        //not really neccessary for this project, but since we're learning from a course, let's leave it there
        Task<IEnumerable<Media>> GetMediaByTitleAsync(string AltText);
    }
}
