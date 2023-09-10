using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AllTasks
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int? Id_TaskFinished { get; set; }
        public int Id_Area { get; set; }
        public string Created_At { get; set; }
    }
}
