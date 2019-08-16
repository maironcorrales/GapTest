namespace PolicyModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Client_has_Policy
    {
        [Key]
        public int id_coverage_plan { get; set; }

        [Required]
        public string plan_Coverage_description { get; set; }

        [StringLength(30)]
        public string cover_object { get; set; }

        public int client_id_client { get; set; }

        public int policy_id_policy { get; set; }

        [Column(TypeName = "date")]
        public DateTime coverage_start { get; set; }

        public int coverage_amount { get; set; }

        public int coverage_period { get; set; }

        public decimal coverage_monthly_price { get; set; }

        public int risk { get; set; }

        public virtual Client Client { get; set; }

        public virtual Policy Policy { get; set; }
    }
}
