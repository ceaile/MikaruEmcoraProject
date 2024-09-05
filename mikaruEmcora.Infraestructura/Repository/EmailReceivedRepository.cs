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

namespace MikaruEmcora.Infraestructure.Repository
{
    public class EmailReceivedRepository : Repository<EmailReceived>, IEmailReceivedRepository  
    {
        public EmailReceivedRepository(MikaruEmcoraContext dbContext) : base(dbContext) { }

        public async Task<IEnumerable<EmailReceived>> GetEmailBySubjectAsync(string emailSubject)
        {
            return await dbContext.EmailsReceived
                .Where(x => x.Subject.Contains(emailSubject))
                .ToListAsync();
        }


    }
}
