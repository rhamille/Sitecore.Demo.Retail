using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Sitecore.Services.Infrastructure.Web.Http;
using System.Dynamic;
using Sitecore.Feature.SalesForceIntegration.Website.Models;

namespace Sitecore.Feature.SalesForceIntegration.Website.Controllers.Api
{
    [RoutePrefix("sitecore/api/sfcase")]
    public class SFCasesController : ServicesApiController
    {
        [HttpGet]
        [Route("")]
        public dynamic Get()
        {
            dynamic returnValue = new ExpandoObject();

            returnValue.Controller = "SFCaseController";
            returnValue.Info = "Check: OK";

            return returnValue;
        }

        [HttpGet]
        [Route("{contactId}")]
        public IHttpActionResult Get(string contactId, [FromUri]SearchRequest request)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11;


            var loginClient = new sfpartner.SforceService();
            var loginResponse = loginClient.login("vahid@rxpservices.com", "qweasdzxcV123" + "L80Spq90HxBbUAHujt8617At");


            var caseClient = new sfcase.CaseWebServiceService()
            {
                SessionHeaderValue = new sfcase.SessionHeader
                {
                    sessionId = loginResponse.sessionId,
                }
            };

            var casesResponse = caseClient.getCases(new sfcase.Request
            {
                contactId = contactId
            });

            var dataList = new List<CaseDetail>();

            if (casesResponse.cases != null)
            {
                foreach (var casex in casesResponse.cases)
                {
                    dataList.Add(new CaseDetail()
                    {
                        caseNumberField = casex.caseNumber,
                        appointmentDateField = casex.appointmentDate?.ToString("yyyy-MM-dd"),
                        subjectField = casex.subject,
                        statusField = casex.status
                    });
                }
            }
            var response = new CaseSearchResponse
            {
                Data = dataList,
                Draw = 1,
                RecordsFiltered = dataList.Count,
                RecordsTotal = dataList.Count
            };
            return Ok(response);
        }


        [HttpPut]
        [Route("{caseNumber}")]
        public IHttpActionResult UpdateCase(string caseNumber, [FromUri]SearchRequest request)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11;


            var loginClient = new sfpartner.SforceService();
            var loginResponse = loginClient.login("vahid@rxpservices.com", "qweasdzxcV123" + "L80Spq90HxBbUAHujt8617At");


            var caseClient = new sfcase.CaseWebServiceService()
            {
                SessionHeaderValue = new sfcase.SessionHeader
                {
                    sessionId = loginResponse.sessionId,
                }
            };

            var updateCaseResult = caseClient.updateCase(new sfcase.Request
            {
                caseWrapper = new sfcase.caseWrapper
                {
                    caseNumber = caseNumber,
                    status = "Confirmed",

                },
            });
           
            return Ok();
        }
    }
}
