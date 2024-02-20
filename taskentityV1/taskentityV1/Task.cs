using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskentityV1
{
    [Table("NewTask")]

    internal class Task
    {
        public int Id { get; set; }

        [Required]
        public string Title{ get; set; }
        public string? Description { get; set; }

       
        public DateTime Date { get; set; }

    }
}
