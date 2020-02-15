using System;

namespace SayHello
{
    public interface IEmpRepository
    {
        public string sayHello();
    }

    public class EmpRepository : IEmpRepository
    {
        public string sayHello()
        {
            return "hello world!";
        }
    }
}
