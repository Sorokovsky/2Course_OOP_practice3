namespace Task_2;
public static class Program
{
    public static void Main()
    {
        Player player = new Player();
        player.Record();
        player.Stop();
        player.Play();
        player.Pause();
    }
}