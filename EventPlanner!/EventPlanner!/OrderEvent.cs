//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EventPlanner_
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderEvent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderEvent()
        {
            this.OrganizeEvents = new HashSet<OrganizeEvent>();
        }
    
        public int EventID { get; set; }
        public int ClientID { get; set; }
        public string EventType { get; set; }
        public System.DateTime DateOfEvent { get; set; }
        public Nullable<System.TimeSpan> TimeOfEvent { get; set; }
        public int NoOfGuest { get; set; }
        public Nullable<int> V_ID { get; set; }
        public Nullable<int> P_ID { get; set; }
        public int EM_Fee { get; set; }
        public int CateringCost { get; set; }
        public int TotalCost { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Photographer Photographer { get; set; }
        public virtual Vanue Vanue { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrganizeEvent> OrganizeEvents { get; set; }
    }
}
