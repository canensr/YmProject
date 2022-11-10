using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Activity
    {
        [Key]
        public int ActivityID { get; set; }
        [StringLength(50)]
        public string ActivitySubject { get; set; }
        [StringLength(200)]
        public string ActivityExplanation { get; set; }
        [StringLength(5)]
        public string ActivityDuration { get; set; }
        [StringLength(15)]
        public string ActivityDate { get; set; }    
    }
}
