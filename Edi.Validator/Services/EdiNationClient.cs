using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Edi.Validator.Constants;
using Edi.Validator.Models;
using Newtonsoft.Json;

namespace Edi.Validator.Services
{
    public class EdiNationClient
    {
        private readonly string EdiNationReadApiCompleteUrl;
        private readonly string EdiNationValidateApiCompleteUrl;

        public EdiNationClient()
        {
            EdiNationReadApiCompleteUrl = string.Concat(
                Configurations.EdiNationBaseUrl,
                Configurations.EdiNationX12ReadApiUrl);

            EdiNationValidateApiCompleteUrl = string.Concat(
                Configurations.EdiNationBaseUrl,
                Configurations.EdiNationX12ValidateApiUrl);
        }

        public async Task<Root> ReadX12PayloadContent(string x12Payload)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Add(Configurations.EdiNationApiKey, Configurations.EdiNationApiKeyValue);
                    httpClient.DefaultRequestHeaders.Add("Accept-Content", "application/json");

                    using (var formContent = new MultipartFormDataContent())
                    {
                        formContent.Add(new StreamContent(new MemoryStream(Encoding.UTF8.GetBytes(x12Payload))));

                        var response = await httpClient.PostAsync(this.EdiNationReadApiCompleteUrl, formContent);

                        if (!response.IsSuccessStatusCode)
                        {
                            return default;
                        }

                        var parsedX12Content = JsonConvert.DeserializeObject<IList<Root>>(await response.Content.ReadAsStringAsync());

                        return parsedX12Content.FirstOrDefault();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }

        public async Task<ValidationResponse> ValidateX12Content(Root x12ParsedContent)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Add(Configurations.EdiNationApiKey, Configurations.EdiNationApiKeyValue);

                    var parsedX12Content = new StringContent(JsonConvert.SerializeObject(x12ParsedContent), Encoding.UTF8, "application/json");

                    var validationResponse = await httpClient.PostAsync(this.EdiNationValidateApiCompleteUrl, parsedX12Content);

                    if (!validationResponse.IsSuccessStatusCode)
                    {
                        return default;
                    }

                    var validatedX12Content = JsonConvert.DeserializeObject<ValidationResponse>(await validationResponse.Content.ReadAsStringAsync());

                    return validatedX12Content;
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
    }
}
