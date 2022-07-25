using Microsoft.AspNetCore.Mvc;

namespace aspnet_resume_website.Pages.Components.Contactform
{
    public class ContactformViewComponent : ViewComponent
    {
        public ContactformViewComponent()
        {
        }

        public IViewComponentResult Invoke()
        {
            ContactformModel model = new ContactformModel();
            return View("ContactForm", model);
        }
    }
}
