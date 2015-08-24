using System;
using System.Collections.Generic;
using AppoloSharp.Model;
using Newtonsoft.Json;
using RestSharp;

namespace AppoloSharp
{
    public enum Elements
    {
        STUDENT,
        PROGRAM,
        COURSE_UNIT,
        LECTIVE_SEMESTER,
        CLASS,
        TEACHER
    }

    public class Appolo
    {
        /// <summary>
        /// The base link to access the REST API.
        /// </summary>
        private static readonly String BASE_LINK_API = "https://adeetc.thothapp.com/api/v1";

        private static Dictionary<Elements, string> elementsPathID = new Dictionary<Elements, string>()
        {
            [Elements.STUDENT] = "students",
            [Elements.PROGRAM] = "programs",
            [Elements.COURSE_UNIT] = "courseunits",
            [Elements.LECTIVE_SEMESTER] = "lectivesemesters",
            [Elements.CLASS] = "classes",
            [Elements.TEACHER] = "teachers"
        };


        private static T MakeRequest<T>(string content)
        {
            return JsonConvert.DeserializeObject<T>(content);
        }

        public static T GetElements<T>(Elements element)
        {
            RestClient client = new RestClient(BASE_LINK_API);
            var requestNewElement = new RestRequest(elementsPathID[element], Method.GET);
            var jsonResponse = client.Execute(requestNewElement);
            return JsonConvert.DeserializeObject<T> (jsonResponse.Content);
        }

        public static T GetElementById<T>(Elements element, string id)
        {
            RestClient client = new RestClient(BASE_LINK_API);
            var requestNewElement = new RestRequest(elementsPathID[element] + "/{id}", Method.GET);
            requestNewElement.AddUrlSegment("id", id);
            var jsonResponse = client.Execute(requestNewElement);
            return MakeRequest<T>(jsonResponse.Content);
        }

        public static T GetElementById<T>(Elements element, int id)
        {
            return GetElementById<T>(element, id.ToString());
        }


    }
}
