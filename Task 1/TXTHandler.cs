namespace Task_1
{
    public class TXTHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("TXT changed.");
        }

        public override void Create()
        {
            Console.WriteLine("TXT created.");
        }

        public override void Open()
        {
            Console.WriteLine("TXT opened.");
        }

        public override void Save()
        {
            Console.WriteLine("TXT saved.");
        }
    }
}
