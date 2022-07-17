using Microsoft.AspNetCore.Mvc;

namespace aspnet_resume_website.Pages.Components.Contact
{
    public class ContactViewComponent : ViewComponent
    {
        public ContactViewComponent()
        {
        }

        public IViewComponentResult Invoke()
        {
            return View("Contact");
        }
    }
}
