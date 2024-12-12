using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App.Class.ExampleInheritanceInterface
{
    public interface Animal
    {
        public int Id { get; set; }
        public string ? Name { get; set; }
        public string ? Category { get; set; }
        public string? Bread { get; set; }
        public string? Eat { get; set; }
        public void Breeds();
        public void Eats();
       
    }
}
