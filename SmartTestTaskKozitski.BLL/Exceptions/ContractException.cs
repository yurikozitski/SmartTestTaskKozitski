using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTestTaskKozitski.BLL.Exceptions
{
    public class ContractException : Exception
    {
        public ContractException() { }

        public ContractException(string message) : base(message) { }
    }
}
