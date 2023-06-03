using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProject.Models
{
    public class Node
    {
        public Guid Key { get; set; }
        public string FIO { get; set; }
        public DateTime Birthday { get; set; }
        public string Street { get; set; }
        public int House { get; set; }
        public string City { get; set; }
        public int Level { get; set; }
        public Node Parent { get; set; }
        public ObservableCollection<Node> Nodes { get; set; }
    }
}
