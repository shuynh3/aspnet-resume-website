using Microsoft.AspNetCore.Mvc;

namespace aspnet_resume_website.Pages.Components.Project
{
    public class ProjectViewComponent : ViewComponent
    {
        public ProjectViewComponent() { }

        public IViewComponentResult Invoke(string imageFileNames, string title, string description, string? techStack = null, string? techStackLinks = null, string? githubLink = null, string? link = null, bool? imageCentered = false)
        {
            ProjectModel projectModel = new ProjectModel(imageFileNames, title, description, techStack, techStackLinks, githubLink, link, (bool)imageCentered!);
            return View("Project", projectModel);
        }
    }
}
