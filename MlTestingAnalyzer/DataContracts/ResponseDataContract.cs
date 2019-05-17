using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WindowsFormsMLTest
{
    [DataContract]
    public class ResponseDataContract
    {

        [DataMember(Name = "games")]
        public IList<string> games { get; set; }

        [DataMember(Name = "similarities")]
        public IList<double> similarities { get; set; }

        [DataMember(Name = "random")]
        public IList<string> random { get; set; }

        [DataMember(Name = "source_embedding")]
        public IList<double> source_embedding { get; set; }
    }
}