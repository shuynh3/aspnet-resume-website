using Microsoft.AspNetCore.Mvc;

namespace aspnet_resume_website.Pages.Components.Skills
{
    public class SkillsViewComponent : ViewComponent
    {
        public SkillsViewComponent()
        {
        }

        public IViewComponentResult Invoke()
        {
            return View("Skills");
        }
    }
}
