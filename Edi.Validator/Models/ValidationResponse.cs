using System.Collections.Generic;

namespace Edi.Validator.Models
{
    public class ValidationResponse
    {
        public int LastIndex { get; set; }
        public List<object> Details { get; set; }
        public string Status { get; set; }
    }
}
