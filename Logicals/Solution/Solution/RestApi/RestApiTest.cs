using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using RestSharp;
using System.Text;
using System.Threading.Tasks;

namespace Logicals.RestApi
{
    [TestFixture]
    public class RestApiTests
    {
        private RestClient _client;

        [SetUp]
        public void Setup()
        {
            _client = new RestClient("https://jsonplaceholder.typicode.com"); // Replace with your base URL
        }

        [Test]
        public void Test_Get_Posts()
        {
            var request = new RestRequest("/posts/1", Method.Get);
            var response = _client.Execute(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public void Test_Post_CreatePost()
        {
            var request = new RestRequest("/posts", Method.Post);
            request.AddJsonBody(new
            {
                title = "foo",
                body = "bar",
                userId = 1
            });

            var response = _client.Execute(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.Created));
        }

        [Test]
        public void Test_Put_UpdatePost()
        {
            var request = new RestRequest("/posts/1", Method.Put);
            request.AddJsonBody(new
            {
                id = 1,
                title = "updated title",
                body = "updated body",
                userId = 1
            });

            var response = _client.Execute(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Test]
        public void Test_Patch_UpdatePost()
        {
            var request = new RestRequest("/posts/1", Method.Patch);
            request.AddJsonBody(new
            {
                title = "patched title"
            });

            var response = _client.Execute(request);

            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}
