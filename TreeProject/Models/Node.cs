using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProject.Models
{
    public class Node
    {
        public Guid Key { get; set; }
        public string Name { get; set; }
        public List<Node> Nodes { get; set; }
    }
}
