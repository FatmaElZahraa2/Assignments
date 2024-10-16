namespace Media_Player_Plugins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaPlayer mediaPlayer = new MediaPlayer();  
            
            IMedia audio1 = new Audio();
            IMedia audio2 = new Audio();

            IMedia video1 = new Video();
            IMedia video2 = new Video();

            mediaPlayer.AddTrack(audio1);
            mediaPlayer.AddTrack(audio2);
            mediaPlayer.AddTrack(video1);
            mediaPlayer.AddTrack(video2);


            mediaPlayer.StartTrack(video2);
            mediaPlayer.StopTrack(video2);
        }
    }
}