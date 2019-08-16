namespace PolicyModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Policy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Policy()
        {
            Client_has_Policy = new HashSet<Client_has_Policy>();
        }

        [Key]
        public int id_policy { get; set; }

        [Required]
        [StringLength(50)]
        public string policy_name { get; set; }

        [Required]
        public string policy_description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Client_has_Policy> Client_has_Policy { get; set; }
    }
}
