using System;
using System.Threading;

namespace CSharpIntermediate
{
    public class VideoEventArgs :  EventArgs
    {
        public Video videoProp { get; set; }
    }
    public class VideoEncoder
    {
        //1 - Define a delegate
        //2 - Define an even based on that delegate
        //3 - Raise the event

        // C# developers did write some generic class to make this entire
        // event delegate work into single line using 
        // EventHandler (or) 
        // EventHandler<T> 
        //public delegate void VideoEncodedEventHandler(Object source, VideoEventArgs args);

        public event EventHandler<VideoEventArgs> VideoEncoded; // Generic class used (EventHandler<T>)
        public event EventHandler VidEncoded; // normal EventHandler used. but this requires the change in the event firing methods
        // you would have seen some changes in the 'MailService and MessageService class' some of them will be commented 
        // looks like the eventhandler can be both normal and generic here. 
        // this is fun but need to understand the real world use and put it in the right place
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding starts...");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VidEncoded != null)
            {
                VidEncoded(this, EventArgs.Empty);
            }
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { videoProp = video } );
            }
        }
    }
}