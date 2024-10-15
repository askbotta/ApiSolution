using RestSharp;
using System;
using TechTalk.SpecFlow;

namespace API.Project_Sample.StepDefinitions
{
    [Binding]
    public class TestAPIStepDefinitions
    {

        private readonly IApiClient _apiClient;
        private RestResponse _response;
        public TestAPIStepDefinitions()
        {
            _apiClient = new RestApiClient();
        }

        [Given(@"I make a GET request to retrieve all objects")]
        public void GivenIMakeAGETRequestToRetrieveAllObjects()
        {
            _response = _apiClient.GetObjects();
        }

        [Then(@"the response status code should be (.*)")]
        public void ThenTheResponseStatusCodeShouldBe(int p0)
        {
           
        }

        [Given(@"I make a GET request for object with id ""([^""]*)""")]
        public void GivenIMakeAGETRequestForObjectWithId(string p0)
        {
          
        }

        [Given(@"I make a POST request to create a new object")]
        public void GivenIMakeAPOSTRequestToCreateANewObject()
        {
            
        }

        [Given(@"the response status code should be (.*)")]
        public void GivenTheResponseStatusCodeShouldBe(int p0)
        {
           
        }
    }
}
