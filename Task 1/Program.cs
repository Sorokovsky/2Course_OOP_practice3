namespace Task_1;
public static class Program
{
    public static void Main()
    {
        AbstractHandler xml = new XMLHandler();
        AbstractHandler txt = new TXTHandler();
        AbstractHandler doc = new DocHandler();
        ShowHandlers(xml);
        ShowHandlers(txt);
        ShowHandlers(doc);
    }

    public static void ShowHandlers(AbstractHandler handler)
    {
        handler.Create();
        handler.Open();
        handler.Change();
        handler.Save();
    }
}
