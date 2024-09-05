using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MikaruEmcora.Core.Entities;
using MikaruEmcora.Core.Entities.Base;
using MikaruEmcora.Core.Repositories.Base;

namespace MikaruEmcora.Core.Repositories {
    public interface IEmailReceivedRepository : IRepository<EmailReceived> {
        Task<IEnumerable<EmailReceived>> GetEmailBySubjectAsync(string emailSubject);
    }
}
