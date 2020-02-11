using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WarrenConsoleApp
{
    public class Challenges
    {
        public Challenges(int id, string name, string description, string solution)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Solution = solution;
        }

        public Challenges()
        {
        }


        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Solution { get; set; }

    }
}
