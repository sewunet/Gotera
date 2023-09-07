using Gotera.Application.DTOs.Email;
using System.Threading.Tasks;

namespace Gotera.Application.Interfaces
{
    public interface IEmailService
    {
        Task SendAsync(EmailRequest request);
    }
}