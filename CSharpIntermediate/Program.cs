using System;

namespace CSharpIntermediate
{
    class Program
    {
        public static void Main(string[] args)
        {
            var customer = new Customer(1234, "Sathish");
            var order = new Order();
            customer.orders.Add(order);
            Console.WriteLine("Hello World!");

            var employee = new EncapsulationImpl();
            employee.GetPayCheck();

            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subscriber
            var messageService = new MessageService();

            //videoEncoder.VideoEncoded += mailService.VideoEncodedSubscription;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.VidEncoded += mailService.VideoEncodedSubscription;

            videoEncoder.Encode(video);
        }
    }

    public class MailService
    {
        //public void VideoEncodedSubscription(object source, VideoEventArgs e)
        public void VideoEncodedSubscription(object source, EventArgs e)
        {
            //Console.WriteLine("Mail service: Sending an email of title: " + e.videoProp.Title);
            Console.WriteLine("Mail service: Sending in email of title: ");
        }
    }

    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Message service: Sending message of video title: " + e.videoProp.Title);
        }
    }
}
