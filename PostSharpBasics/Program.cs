using System;
using PostSharp.Aspects;

namespace PostSharpBasics
{
    [Serializable]
    public class MethodStartAndStop : OnMethodBoundaryAspect
    {

        public override void OnEntry(MethodExecutionArgs args)
        {
            Console.WriteLine("The {0} method has been entered.", args.Method.Name);
        }
        public override void OnExit(MethodExecutionArgs args)
        {
            Console.WriteLine("The {0} method has exited.", args.Method.Name);
            Console.ReadKey();
        }
    }

    static class Program
    {
        [MethodStartAndStop]
        static void Main()
        {
        }
    }
}
