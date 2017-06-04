//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChessSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Moves
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int PlayerId { get; set; }
        public int Number { get; set; }
        public byte Piece { get; set; }
        public byte MoveFrom { get; set; }
        public byte MoveTo { get; set; }
        public int Duration { get; set; }
        public byte CapturedPiece { get; set; }
    
        public virtual Games Games { get; set; }
        public virtual Players Players { get; set; }
    }
}
