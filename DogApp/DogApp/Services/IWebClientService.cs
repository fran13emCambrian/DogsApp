using System;
using System.Threading.Tasks;

namespace DogsApp.Services
{
    public interface IWebClientService
    {
        Task<string> GetString(string Uri);
    }
}
