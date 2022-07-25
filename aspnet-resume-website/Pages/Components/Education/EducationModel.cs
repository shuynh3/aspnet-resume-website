namespace aspnet_resume_website.Pages.Components.Education
{
    public class EducationModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string DateString { get; set; }
        public string ImageLocation { get; set; }

        public EducationModel(string title, string description, string startDate, string endDate, string image)
        {
            Title = title;
            Description = description;
            DateString = getDateString(startDate, endDate);
            ImageLocation = getImageLocation(image);
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
