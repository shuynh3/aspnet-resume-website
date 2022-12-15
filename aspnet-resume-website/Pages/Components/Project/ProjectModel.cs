namespace aspnet_resume_website.Pages.Components.Project
{
    public class ProjectModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string? TechStackIconsHTML { get; set; }
        public string? GithubLink { get; set; }
        public string? Link { get; set; }
        public string ImageId { get; set; }
        public string DefaultImageClass { get; set; }
        public string ImageClassesHTML { get; set; }
        public string ImageStyleClassesHTML { get; set; }
        public bool ImageCentered { get; set; }

        public ProjectModel(string imageFileNames, string title, string description, string? techStack, string? techStackLinks, string? githubLink, string? link, bool imageCentered)
        {
            var classNames = getClassNames(imageFileNames);

            ImageId = classNames[0];
            DefaultImageClass = classNames[0];
            ImageClassesHTML = getClassesStringHTML(classNames);
            ImageStyleClassesHTML = getClassesStylesHTML(imageFileNames, classNames);
            Title = title;
            Description = description;
            TechStackIconsHTML = getTechStackIconsHTML(techStack, techStackLinks);
            GithubLink = githubLink;
            Link = link;
            ImageCentered = imageCentered;
        }

        private string[] getClassNames(string imageFileNames)
        {
            var uniqueSuffix = Guid.NewGuid().ToString();
            var classNames = imageFileNames.Split(" ");
            for (int i = 0; i < classNames.Length; i++)
            {
                classNames[i] += uniqueSuffix;
            }
            return classNames;
        }

        private string getClassesStringHTML(string[] classNames)
        {
            var classesString = "[";
            for (int i = 0; i < classNames.Length; i++)
            {
                classesString += $"'{classNames[i]}', ";
            }
            return classesString + "]";
        }

        private string getClassesStylesHTML(string imageFileNames, string[] classNames)
        {
            var fileNames = imageFileNames.Split(" ");
            var imageStyles = "";
            for (int i = 0; i < fileNames.Length; i++)
            {
                var style = $".{classNames[i]} {{ background-image: url(\"/images/{fileNames[i]}.png\"); }} ";
                imageStyles += style;
            }
            return imageStyles;
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
                    techStackHTML += $"<a href='{links[i]}' target='_blank'><div class='project-tech-stack-image' style='background-image: url(&quot;/images/{fileNames[i]}.png&quot;);'></div></a>";
                }
                return techStackHTML;
            }
            else
            {
                return null;
            }
        }
    }
}
