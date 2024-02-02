using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testscaffold.Additional
{
    public class Grade
    {
        [Key]
        public int id { get; set; }
        public decimal physics { get; set; }
        public decimal chemistry { get; set; }
        public decimal programming { get; set; }

        [ForeignKey("student")]
        public int? studentid { get; set; }
        public Student student { get; set; }
    }
}
