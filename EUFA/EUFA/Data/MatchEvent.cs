//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EUFA.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class MatchEvent
    {
        public int Id { get; set; }
        public int MatchId { get; set; }
        public int MatchMinute { get; set; }
        public bool TeamA { get; set; }
        public string EventType { get; set; }
        public string AdditionalInformation { get; set; }
    
        public virtual Match Match { get; set; }
    }
}