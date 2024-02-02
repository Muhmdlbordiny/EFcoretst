using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testscaffold.Additional
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime Created { get; set; }

        public ICollection<StudentBook> Students { get; set; }
        public int DeliveryOrder { get; set; }

    }
}
