using OnSale.Common.Requests;

namespace OnSale.Web.Helpers
{
    public interface IMailHelper
    {
        Response SendMail(string to, string subject, string body);
    }

}
