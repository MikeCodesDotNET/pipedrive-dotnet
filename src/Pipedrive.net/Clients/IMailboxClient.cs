using System.Threading.Tasks;

namespace Pipedrive
{
    public interface IMailboxClient
    {
        Task<MailMessage> GetMailMessage(long id, bool includeBody = false);
    }
}
