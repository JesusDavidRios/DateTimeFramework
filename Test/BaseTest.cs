using NUnit.Framework;
using RestSharp;
using RestSharp.Serialization.Json;
using DateTimeTestFramework.Table;
using System.Collections.Generic;

namespace DateTimeTestFramework
{
    public abstract class BaseTest
    {
        private RestClient _client;
        private RestRequest _request;
        private IRestResponse _response;
        private JsonDeserializer _jsonDeserializer;
        private static string s_baseUri = "http://localhost:3000/";
        public Tables OutPut;

        [SetUp]
        public void setUp()
        {
            _client = new RestClient(s_baseUri);
            _request = new RestRequest("table", Method.GET);
            _response = _client.Execute(_request);
            _jsonDeserializer = new JsonDeserializer();
            OutPut = _jsonDeserializer.Deserialize<Tables>(_response);
        }
    }
}
