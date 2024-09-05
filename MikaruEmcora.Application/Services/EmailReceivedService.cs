using MikaruEmcora.Core.Entities;
using MikaruEmcora.Core.Repositories;
using MikaruEmcora.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MikaruEmcora.Application.Services {
    public class EmailReceivedService : IEmailReceivedService {
        //
        private readonly IEmailReceivedRepository emailReceivedRepository;
        public EmailReceivedService(IEmailReceivedRepository emailRepository) {
            this.emailReceivedRepository = emailRepository;
        }

        public async Task<EmailReceived> Create(EmailReceived emailReceived) {
            await ValidateEmailReceivedIfExist(emailReceived);
            var newEntity = await emailReceivedRepository.AddAsync(emailReceived);
            return newEntity;
        }
        public async Task Update(EmailReceived emailReceived) {
            ValidateEmailReceivedIfNotExist(emailReceived);

            var editEmailReceived = await emailReceivedRepository.GetByIdAsync(emailReceived.Id);
            if (editEmailReceived == null)
                throw new ApplicationException($"Entity could not be loaded.");

            editEmailReceived.Id = emailReceived.Id;
            editEmailReceived.Subject = emailReceived.Subject;

            await emailReceivedRepository.UpdateAsync(editEmailReceived);
        }
        public async Task Delete(EmailReceived emailReceived) {
            ValidateEmailReceivedIfNotExist(emailReceived);
            var deletedEmailReceived = await emailReceivedRepository.GetByIdAsync(emailReceived.Id);
            if (deletedEmailReceived == null)
                throw new ApplicationException($"Entity could not be loaded.");

            await emailReceivedRepository.DeleteAsync(deletedEmailReceived);
        }
        public async Task<IEnumerable<EmailReceived>> GetEmailsReceivedList() {
            var emailsReceivedList = await emailReceivedRepository.GetAllAsync();
            return emailsReceivedList;
        }

        public async Task<EmailReceived> GetEmailReceivedById(int emailReceivedId) {
            var emailReceived = await emailReceivedRepository.GetByIdAsync(emailReceivedId);
            return emailReceived;
        }

        public async Task<IEnumerable<EmailReceived>> GetEmailReceivedBySubject(string emailSubject) {
            var emailsReceivedList = await emailReceivedRepository.GetEmailBySubjectAsync(emailSubject);
            return emailsReceivedList;
        }

        

        


        private async Task ValidateEmailReceivedIfExist(EmailReceived emailReceived) {
            var existingEntity = await emailReceivedRepository.GetByIdAsync(emailReceived.Id);
            if (existingEntity != null)
                throw new ApplicationException($"{emailReceived.ToString()} with this id already exists");
        }

        private void ValidateEmailReceivedIfNotExist(EmailReceived emailReceived) {
            var existingEntity = emailReceivedRepository.GetByIdAsync(emailReceived.Id);
            if (existingEntity == null)
                throw new ApplicationException($"{emailReceived.ToString()} with this id is not exists");
        }

        //
    }
}
