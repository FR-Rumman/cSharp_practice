namespace EventAndDelegate
{
    public class VedioEncoder
    {
        //1- define a delegate
        //2- define an event base on delegates
        //3- Raise the event
        public delegate void VideoEncoderEventHandler(object source, EventArgs args);

        public event VideoEncoderEventHandler
            videoEncoded;

        public void Encode(Vedio vedio)
        {
            Console.WriteLine("Encoding video");
            Thread.Sleep(3000);

            OnVideoEncoded();


        }
        protected virtual void OnVideoEncoded()
        {
            if (videoEncoded != null)
                videoEncoded(this, EventArgs.Empty);
        }
    }
}
