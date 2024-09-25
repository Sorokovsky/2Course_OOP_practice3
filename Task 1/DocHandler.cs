namespace Task_1
{
    public class DocHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("Doc changed.");
        }

        public override void Create()
        {
            Console.WriteLine("Doc created.");
        }

        public override void Open()
        {
            Console.WriteLine("Doc opened.");
        }

        public override void Save()
        {
            Console.WriteLine("Doc saved.");
        }
    }
}
