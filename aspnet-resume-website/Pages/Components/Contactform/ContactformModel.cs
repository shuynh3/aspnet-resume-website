/*using System.Net.Mail;*/

namespace aspnet_resume_website.Pages.Components.Contactform
{
    public class ContactformModel
    {
        public ContactformModel()
        {

        }

        /*public void sendEmail(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            mail.To.Add("Sonnyhuynh214@gmail.com");
            mail.From = new MailAddress("from gmail address", "Email head", System.Text.Encoding.UTF8);
            mail.Subject = "This mail is send from asp.net application";
            mail.SubjectEncoding = System.Text.Encoding.UTF8;
            mail.Body = "This is Email Body Text";
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;

            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("SonnyHuynhWebsite@gmail.com", "sonnywebsite214");
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            try
            {
                client.Send(mail);
            }
            catch (Exception ex)
            {
                Exception ex2 = ex;
                string errorMessage = string.Empty;
                while (ex2 != null)
                {
                    errorMessage += ex2.ToString();
                    ex2 = ex2.InnerException;
                }
            }
        }*/
    }
}
