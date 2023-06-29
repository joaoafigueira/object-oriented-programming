using System;
using System.Runtime.Intrinsics.X86;

namespace OOP
{
    public class Employee : Person
    {
        public DateTime AdmissionDate { get; set; }
        public string Register { get; set; }
    }

    //For inheritance to happen, a (child) class must be of the type of the parent class.
    //We cannot use inheritance simply to reuse code,  as there is a
    //semantic break (different meaning that is associated with the sense of the inheritance that is occurring).
}
