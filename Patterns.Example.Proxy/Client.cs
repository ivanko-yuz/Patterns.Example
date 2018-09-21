namespace Patterns.Example.Proxy
{
    public class Client
    {
        public void Operation(Abstraction service)
        {
            service.Opretation();
        }
    }
}
