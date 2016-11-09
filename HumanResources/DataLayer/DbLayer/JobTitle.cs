using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.DbLayer
{
    [Table("JobTitle")]
    public partial class JobTitle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JobTitle()
        {
            EmpPromotions = new HashSet<EmpPromotion>();
        }

        public int JobTitleId { get; set; }

        [Required]
        [StringLength(100)]
        public string NameJobTitle { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmpPromotion> EmpPromotions { get; set; }
    }
}
