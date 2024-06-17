using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{

    public interface IWorkable
    {
        void Work();
    }

    public interface IManageable
    {
        void Manage();
    }
    public class Manager : IWorkable, IManageable
    {
        public void Work()
        {
            Console.WriteLine("Manager is working.");
        }

        public void Manage()
        {
            Console.WriteLine("Manager is managing tasks.");
        }
    }

    public class Worker : IWorkable
    {
        public void Work()
        {
            Console.WriteLine("Worker is working.");
        }
    }

    public class Robot : IWorkable
    {
        public void Work()
        {
            Console.WriteLine("Robot is working.");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Manager manager = new Manager();
            Worker worker = new Worker();
            Robot robot = new Robot();
            manager.Work();
            worker.Work();
            robot.Work();
            manager.Manage();
        }
    }
}
