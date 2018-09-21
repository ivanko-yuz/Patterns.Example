namespace Patterns.Example.Facade
{
    class Facade
    {
        private SubSystemA subSystemA;
        private SubSystemB subSystemB;
        private SubSystemC subSystemC;
        private SubSystemD subSystemD;

        public Facade()
        {
            subSystemA = new SubSystemA();
            subSystemB = new SubSystemB();
            subSystemC = new SubSystemC();
            subSystemD = new SubSystemD();
        }


        public void MethodA()
        {
            System.Console.WriteLine("  Facase method A");

            subSystemA.MethodA();
            subSystemB.MethodA();
            subSystemC.MethodA();
            subSystemD.MethodA();
        }

        public void MethodB()
        {
            System.Console.WriteLine("  Facase method B");
            
            subSystemB.MethodB();
            subSystemD.MethodB();
        }

        public void MethodC()
        {
            System.Console.WriteLine("  Facase method C");

            subSystemC.MethodC();
            subSystemD.MethodD();
        }

        public void MethodD()
        {
            System.Console.WriteLine("  Facase method D");

            subSystemD.MethodD();
        }
    }
}
