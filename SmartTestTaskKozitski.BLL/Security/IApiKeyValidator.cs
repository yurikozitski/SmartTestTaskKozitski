namespace SmartTestTaskKozitski.BLL.Security
{
    public interface IApiKeyValidator
    {
        bool IsValidApiKey(string userApiKey);
    }
}
