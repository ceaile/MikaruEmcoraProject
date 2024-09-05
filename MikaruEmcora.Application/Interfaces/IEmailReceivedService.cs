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
    public interface IEmailReceivedService {

        Task<EmailReceived> Create(EmailReceived emailReceived);
        Task Update(EmailReceived emailReceived);
        Task Delete(EmailReceived emailReceived);

        Task<IEnumerable<EmailReceived>> GetEmailsReceivedList();
        Task<EmailReceived> GetEmailReceivedById(int emailReceivedId);
        Task<IEnumerable<EmailReceived>> GetEmailReceivedBySubject(string emailReceived);
    }
}
