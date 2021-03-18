using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    public class Employee : BaseEmployee, IManaged
    {
        public IEmployee Manager { get; set; } = null;

        public virtual void AssignManager(IEmployee manager)
        {
            // Simulate doing other tasks
            Manager = manager;
        }
    }
}
