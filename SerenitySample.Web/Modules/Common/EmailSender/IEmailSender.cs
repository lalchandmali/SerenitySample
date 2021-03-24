using MimeKit;

namespace SerenitySample.Common
{
    public interface IEmailSender
    {
        void Send(MimeMessage message, bool skipQueue = false);
    }
}