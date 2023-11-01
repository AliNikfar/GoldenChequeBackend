using GoldenChequeBackend.Domain.Settings;
using System.Threading.Tasks;

namespace GoldenChequeBackend.Service.Contract
{
    public interface IEmailService
    {
        Task SendEmailAsync(MailRequest mailRequest);

    }
}
