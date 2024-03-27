using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SMI_Service
{
    [DataContract]
    public class Student
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public int Age { get; set; }

        [DataMember]
        public string Branch { get; set; }

        [DataMember]

        public string Gender { get; set; }


    }

    [DataContract]
    public class StudentData
    {
        [DataMember]

        public DataTable studentTable {get; set;}   

    }

   
}
