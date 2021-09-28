namespace Edi.Validator.Constants
{
    internal class Configurations
    {
        internal const string EdiNationBaseUrl = "https://api.edination.com/v2";
        internal const string EdiNationX12ReadApiUrl = "/x12/read?ignoreNullValues=false&continueOnError=false&charSet=utf-8";
        internal const string EdiNationX12ValidateApiUrl = "/x12/validate";
        internal const string EdiNationApiKey = "Ocp-Apim-Subscription-Key";
        internal const string EdiNationApiKeyValue = "3ecf6b1c5cf34bd797a5f4c57951a1cf";
    }
}
