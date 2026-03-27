using System.Collections.Generic;
using System.Threading.Tasks;
using Pipedrive.Helpers;

namespace Pipedrive
{
    public class MailboxClient : ApiClient, IMailboxClient
    {
        public MailboxClient(IApiConnection apiConnection) : base(apiConnection)
        {
        }

        public Task<MailMessage> GetMailMessage(long id, bool includeBody = false)
        {
            var parameters = new Dictionary<string, string>();
            if (includeBody)
            {
                parameters.Add("include_body", "1");
            }

            return ApiConnection.Get<MailMessage>(ApiUrls.MailboxMailMessage(id), parameters);
        }
    }
}
