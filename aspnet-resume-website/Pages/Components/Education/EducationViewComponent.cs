using Microsoft.AspNetCore.Mvc;

namespace aspnet_resume_website.Pages.Components.Education
{
    public class EducationViewComponent : ViewComponent
    {
        public EducationViewComponent() { }

        public IViewComponentResult Invoke(string title, string description, string startDate, string endDate, string image = "default-resume")
        {
            EducationModel model = new EducationModel(title, description, startDate, endDate, image);
            return View("Education", model);
        }
    }
}
