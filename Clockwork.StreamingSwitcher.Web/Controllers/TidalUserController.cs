using System.Web.Mvc;
using Clockwork.StreamingSwitcher.TidalIntegration.AspNetIdentity;

namespace Clockwork.StreamingSwitcher.Web.Controllers
{
    [Authorize]
    public class TidalUserController : Controller
    {
        public ActionResult UserProfile()
        {
            var deserializeUserModel = TidalClaimsDeserializer.DeserializeUserModel(User.Identity);

            if (deserializeUserModel == null)
                return new EmptyResult();

            return PartialView("Partials/UserProfile", deserializeUserModel);
        }
    }
}