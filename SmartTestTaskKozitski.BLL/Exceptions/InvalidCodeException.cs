using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTestTaskKozitski.BLL.Exceptions
{
    public class InvalidCodeException : ContractException
    {
        public long[] Codes { get; }

        public override string Message => $"One or more of these codes are invalid: {string.Join(", ", Codes)}";

        public InvalidCodeException(params long[] codes)
        {
            this.Codes = codes;
        }
    }
}
