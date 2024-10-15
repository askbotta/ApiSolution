using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Project_Sample
{
    public interface IApiClient
    {

        RestResponse GetObjects();
        RestResponse GetObjectById(string id);
        RestResponse CreateObject(string body);
        RestResponse UpdateObject(string id, string body);
        RestResponse DeleteObject(string id);
    }
}
