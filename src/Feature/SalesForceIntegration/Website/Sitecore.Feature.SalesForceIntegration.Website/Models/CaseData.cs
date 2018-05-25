using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Feature.SalesForceIntegration.Website.Models
{
    //https://levelnis.co.uk/blog/datatables-with-web-api-part-1-get-request
  
    public class SearchRequest
    {
        public int Draw { get; set; }
    }

    public abstract class SearchDetail
    {
    }

    public class CaseDetail : SearchDetail
    {

        public string caseNumberField { get; set; }
        public string appointmentDateField { get; set; }
        public string subjectField { get; set; }
        public string statusField { get; set; }
    }

    public abstract class SearchResponse<T> where T : SearchDetail
    {
        [JsonProperty("draw")]
        public int Draw { get; set; }

        [JsonProperty("recordsTotal")]
        public int RecordsTotal { get; set; }

        [JsonProperty("recordsFiltered")]
        public int RecordsFiltered { get; set; }

        [JsonProperty("data")]
        public IList<T> Data { get; set; }
    }

    public class CaseSearchResponse : SearchResponse<CaseDetail>
    {
    }


}