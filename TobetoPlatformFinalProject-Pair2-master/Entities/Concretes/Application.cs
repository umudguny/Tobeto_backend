using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Application : Entity<Guid>
    {
        public Guid StudentId { get; set; }
        public bool IsFormAccepted { get; set; } = false;
        public bool IsDocumentAccepted { get; set; } = false;

        public Student? Student { get; set; }
    }
}
