namespace EventAndDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Vedio() { Title = "video_1" };
            var videoEncoder = new VedioEncoder();  //publisher
            var mailService = new MailService();    //subscriber 

            videoEncoder.videoEncoded += mailService.OnvideoEncoded;

            videoEncoder.Encode(video);
        }
    }

    public class MailService
    {
        public void OnvideoEncoded(object source, EventArgs e)
        {
            Console.WriteLine("MailService: sending an eamil....");
        }
    }
}