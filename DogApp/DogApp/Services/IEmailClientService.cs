using System;
using System.Threading.Tasks;

namespace DogsApp.Services
{
    public interface IEmailClientService
    {
        Task<bool> SendEmail(string To, string from, string Subject, string Body);
    }
}
