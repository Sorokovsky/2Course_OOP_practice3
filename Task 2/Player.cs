namespace Task_2
{
    public class Player : IPlayable, IRecordable
    {
        public void Pause()
        {
            Console.WriteLine("Paused track.");
        }

        public void Play()
        {
            Console.WriteLine("Play track.");
        }

        public void Record()
        {
            Console.WriteLine("Record track.");
        }

        public void Stop()
        {
            Console.WriteLine("Stopped track.");
        }
    }
}
