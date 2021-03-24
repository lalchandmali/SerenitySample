using Serenity.ComponentModel;
using Serenity.Services;
using System;
using System.ComponentModel;

namespace SerenitySample.Membership
{
    [FormScript("Membership.ForgotPassword")]
    public class ForgotPasswordRequest : ServiceRequest
    {
        [Required(true), EmailEditor, DisplayName("E-mail Address")]
        public String Email { get; set; }
    }
}