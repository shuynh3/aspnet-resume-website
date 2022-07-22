namespace aspnet_resume_website.Pages.Components.Project
{
    public class ProjectModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string? GithubLink { get; set; }
        public string? Link { get; set; }
        public string ImageId { get; set; }
        public string DefaultImageClass { get; set; }
        public string ImageClassesString { get; set; }
        public string ImageStyleClasses { get; set; }
        public bool ImageCentered { get; set; }

        public ProjectModel(string imageFileNames, string title, string description, string? githubLink, string? link, bool imageCentered)
        {
            var classNames = getClassNames(imageFileNames);

            ImageId = classNames[0];
            DefaultImageClass = classNames[0];
            ImageClassesString = getClassesString(classNames);
            ImageStyleClasses = getClassesStyles(imageFileNames, classNames);
            Title = title;
            Description = description;
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
                classNames[0] += uniqueSuffix;
            }
            return classNames;
        }

        private string getClassesString(string[] classNames)
        {
            var classesString = "[";
            for (int i = 0; i < classNames.Length; i++)
            {
                classesString += $"'{classNames[i]}', ";
            }
            return classesString + "]";
        }

        private string getClassesStyles(string imageFileNames, string[] classNames)
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
    }
}
