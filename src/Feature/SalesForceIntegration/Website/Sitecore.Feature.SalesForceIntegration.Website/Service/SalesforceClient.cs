using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace Sitecore.Feature.SalesForceIntegration.Website
{
    public class SalesforceClient
    {
        private const string LOGIN_ENDPOINT = "https://login.salesforce.com/services/oauth2/token";
        private const string API_ENDPOINT = "/services/data/v36.0/";

        public string Username { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string AuthToken { get; set; }
        public string InstanceUrl { get; set; }


        public void Login()
        {
            String jsonResponse;
            using (var client = new HttpClient())
            {
                var request = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                {"grant_type", "password"},
                {"client_id", ClientId},
                {"client_secret", ClientSecret},
                {"username", Username},
                {"password", Password + Token}
            }
                );
                request.Headers.Add("X-PrettyPrint", "1");
                var response = client.PostAsync(LOGIN_ENDPOINT, request).Result;
                jsonResponse = response.Content.ReadAsStringAsync().Result;
            }
            var values = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonResponse);
            AuthToken = values["access_token"];
            InstanceUrl = values["instance_url"];
        }

        public SalesforceClient()
        {
            Username = "vahid@rxpservices.com";
            Password = "qweasdzxcV1";
            Token = "YRX9FtBdKgOl9QhDUdVSNzjX";
            ClientId = "3MVG9g9rbsTkKnAU7VXrfwHswK6oMWNlG1Q5wqxm9NGka1Qp9hOmviX3SpCAgEpHCWolBI8Ca9xK3puepXykC";
            ClientSecret = "8614019079989811194";
        }

    }
}
