using System;
//using System.Collections.Generic;
//using System.Linq;
using System.Runtime.Serialization;
//using System.Web;

namespace InfosWCFService
{
    [DataContract]
    public class Article
    {
        [DataMember]
        public int num { get; set; }
        [DataMember]
        public String title { get; set; }
        [DataMember]
        public String text { get; set; }
        [DataMember]
        public int likes { get; set; }
        [DataMember]
        public int dislikes { get; set; }
    }
}