using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartParametersForPaginationAndStuff
{
    public class Person
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string EyeColor { get; set; }
        public string Name { get; set; }
        public int MyProperty { get; set; }
        public GenderEnum Gender { get; set; }
    }

    public enum GenderEnum
    {
        UNKNOWN = 0,
        FEMALE = 1,
        MALE = 2
    }
}