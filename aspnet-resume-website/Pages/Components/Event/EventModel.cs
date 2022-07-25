namespace aspnet_resume_website.Pages.Components.Event
{
    public class EventModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string DateString { get; set; }
        public string? TechStackIconsHTML { get; set; }

        public string ImageLocation { get; set; }

        public EventModel(string title, string description, string startDate, string endDate, string image, string techStack, string techStackLinks)
        {
            Title = title;
            Description = description;
            DateString = getDateString(startDate, endDate);
            TechStackIconsHTML = getTechStackIconsHTML(techStack, techStackLinks);
            ImageLocation = getImageLocation(image);

        }

        private string? getTechStackIconsHTML(string? techStack, string? techStackLinks)
        {
            if (techStack != null && techStackLinks != null)
            {
                var fileNames = techStack.Split(" ");
                var links = techStackLinks.Split(" ");
                var techStackHTML = "";
                for (int i = 0; i < fileNames.Length; i++)
                {
                    techStackHTML += $"<a href='{links[i]}' target='_blank'><div class='resume-info-tech-stack-icon' style='background-image: url(&quot;/images/{fileNames[i]}.png&quot;);'></div></a>";
                }
                return techStackHTML;
            }
            else
            {
                return null;
            }
        }

        private string getDateString(string startDate, string endDate)
        {
            return $"{startDate} - {endDate}";
        }

        private string getImageLocation(string image)
        {
            return $"/images/{image}.png";
        }
    }
}
