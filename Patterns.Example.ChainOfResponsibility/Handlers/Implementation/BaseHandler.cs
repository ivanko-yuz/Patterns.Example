namespace Patterns.Example.ChainOfResponsibility
{
    public class BaseHandler
    {
        private BaseHandler nextHandle;

        public BaseHandler SetNext(BaseHandler handler)
        {
            nextHandle = handler;
            return nextHandle;
        }

        public virtual void Handle(object item)
        {
            if (nextHandle != null)
                nextHandle.Handle(item);
        }
    }
}
