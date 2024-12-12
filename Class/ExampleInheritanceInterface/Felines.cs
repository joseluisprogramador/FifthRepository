using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App.Class.ExampleInheritanceInterface
{
    public class Felines : Animal
    {
        
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public string? Bread { get; set; }
        public string? Eat { get; set; }

        public Felines(int Id, string Name, string Category, string Bread, string Eat)
        {
            this.Id = Id;
            this.Name = Name;
            this.Category = Category;
            this.Bread = Bread;
            this.Eat = Eat;
        }
        public void Breeds()
        {
            Console.WriteLine($"The feline  {Name}  reproduces {Bread}");
        }

        public void Eats()
        {
            Console.WriteLine($" The feline {Name} eat : {Eat}");
        }
        
    }
}
