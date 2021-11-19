using System.Threading.Tasks;
using VotingCore.Models;

namespace VotingCore.Services
{
    public interface IEmailService
    {
        Task SendEmail(UserEmailOp userEmailOp);
        Task SendTestEmail(UserEmailOp userEmailOptions);
        Task SendEmailForEmailConfirmation(UserEmailOp userEmailOptions);
    }
}