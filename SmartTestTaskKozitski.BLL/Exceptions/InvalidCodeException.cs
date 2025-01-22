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
