//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChessSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Games
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Games()
        {
            this.Moves1 = new HashSet<Moves>();
        }
    
        public int Id { get; set; }
        public Nullable<int> OrganizerId { get; set; }
        public Nullable<int> TournamentId { get; set; }
        public int Player1Id { get; set; }
        public int Player2Id { get; set; }
        public Nullable<int> WinnerId { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> Duration { get; set; }
        public Nullable<int> Moves { get; set; }
        public Nullable<bool> IsPublic { get; set; }
        public Nullable<bool> IsFinished { get; set; }
    
        public virtual Users Users { get; set; }
        public virtual Players Players { get; set; }
        public virtual Players Players1 { get; set; }
        public virtual Tournaments Tournaments { get; set; }
        public virtual Players Players2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Moves> Moves1 { get; set; }
    }
}
