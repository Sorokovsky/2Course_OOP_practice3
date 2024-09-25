namespace Task_1
{
    public class XMLHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("XML changed.");
        }

        public override void Create()
        {
            Console.WriteLine("XML created.");
        }

        public override void Open()
        {
            Console.WriteLine("XML opened.");
        }

        public override void Save()
        {
            Console.WriteLine("XML saved.");
        }
    }
}
