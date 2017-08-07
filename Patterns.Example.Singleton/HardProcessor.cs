
namespace Patterns.Example.Singleton
{
    public class HardProcessor
    {
        private int _start;

        public HardProcessor(int start)
        {
            _start = start;
            LoggerSingleton.GetInstance().Log("Processor just created.");
        }
        public int ProcessTo(int end)
        {
            int sum = 0;
            for (int i = _start; i <= end; ++i)
            {
                sum += i;
                LoggerSingleton.GetInstance().Log("--Value: i = "+ i + " : " + sum);

            }
            LoggerSingleton.GetInstance().Log("Processor just calculated some value: " + sum);
            return sum;
        }
    }
}
