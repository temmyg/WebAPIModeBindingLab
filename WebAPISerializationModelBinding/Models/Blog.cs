//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Spring.Mvc5QuickStart.Models
{
    using System;
    using System.Collections.Generic;
    
    //using System.Runtime.Serialization;
    
    //[DataContract(IsReference=true)]
    public partial class Blog
    {
    	
        //[DataMember]
        public System.Guid ID { get; set; }
    	
        //[DataMember]
        public string title { get; set; }
    	
        //[DataMember]
        public string content { get; set; }
    	
        //[DataMember]
        public System.DateTime CreatedTime { get; set; }
    	
        //[DataMember]
        public long AuthorId { get; set; }
    
    	//[DataMember]
        public virtual Author Author { get; set; }
    }
}
