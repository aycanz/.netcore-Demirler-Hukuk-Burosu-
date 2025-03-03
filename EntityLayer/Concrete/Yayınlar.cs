using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Yayınlar

    {
        
    [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int YayınID { get; set; }

        public string BaslıkAdı { get; set; }
        public string Metin { get; set; }

    }
}
