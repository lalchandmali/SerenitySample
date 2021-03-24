using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace SerenitySample.BasicSamples.Pages
{
    [PageAuthorize, Route("BasicSamples/[action]")]
    public partial class BasicSamplesController : Controller
    {
    }
}
