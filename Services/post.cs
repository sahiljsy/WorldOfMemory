//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Services
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class post
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string post_path { get; set; }
        [DataMember]
        public string username { get; set; }
        [DataMember]
        public int likes { get; set; }
    }
}
