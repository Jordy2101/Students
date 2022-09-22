using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Application.MessageCodes
{
    public struct MessageCodes
    {

        public static readonly string EmptyCollections = "No records found to display or process!";

        public static string FieldEmpty(object property)
        {
            return $"This field {property} is required";
        }

        public static string FieldExcess(int beginning, int end, object property)
        {
            return $"The {property} must be between {beginning} and {end} characters long";
        }
    }
}
