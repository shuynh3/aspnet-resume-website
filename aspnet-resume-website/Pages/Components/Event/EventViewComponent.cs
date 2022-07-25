using Microsoft.AspNetCore.Mvc;

namespace aspnet_resume_website.Pages.Components.Event
{
    public class EventViewComponent : ViewComponent
    {
        public EventViewComponent() { }

        public IViewComponentResult Invoke(string title, string description, string startDate, string endDate, string image = "default-resume", string techStack = "", string techStackLinks = "")
        {
            EventModel model = new EventModel(title, description, startDate, endDate, image, techStack, techStackLinks);
            return View("Event", model);
        }
    }
}
