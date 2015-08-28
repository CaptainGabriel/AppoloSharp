using System;
using System.Collections.Generic;
using AppoloSharp.Model;
using Newtonsoft.Json;
using RestSharp;

namespace AppoloSharp
{
    /// <summary>
    /// Enums used to choose the element to
    /// obtain via this library.
    /// </summary>
    public enum Elements
    {
        STUDENT,
        PROGRAM,
        COURSE_UNIT,
        LECTIVE_SEMESTER,
        CLASS,
        TEACHER
    }

    /// <summary>
    /// The main class of this library.
    /// Provides the methods of yhis library. 
    /// </summary>
    public class Appolo
    {
        /// <summary>
        /// The base link to access the REST API.
        /// </summary>
        private static readonly String BASE_LINK_API = "https://adeetc.thothapp.com/api/v1";

        /// <summary>
        /// The dictionary that contains the keywords used by the Thoth API in terms of their
        /// JSON responses.
        /// </summary>
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

        /// <summary>
        /// The method that returns an array of elements.
        /// 
        /// The generic form allows the possibility of invoking
        /// this method for different kinds of elements.
        /// 
        /// In order to specify which element to search, use the enumerator
        /// Elements like: 
        ///     <example>
        ///         <code>
        ///         Appolo.GetElements(Elements.STUDENT);
        ///         </code>
        ///     </example>
        /// </summary>
        public static T GetElements<T>(Elements element)
        {
            RestClient client = new RestClient(BASE_LINK_API);
            var requestNewElement = new RestRequest(elementsPathID[element], Method.GET);
            var jsonResponse = client.Execute(requestNewElement);
            return JsonConvert.DeserializeObject<T> (jsonResponse.Content);
        }

        /// <summary>
        /// This method returns a single instance of the object T.
        /// 
        /// In order to specify which element to search, use the enumerator
        /// Elements and a unique identifier.
        /// 
        /// </summary>
        public static T GetElementById<T>(Elements element, string id)
        {
            RestClient client = new RestClient(BASE_LINK_API);
            var requestNewElement = new RestRequest(elementsPathID[element] + "/{id}", Method.GET);
            requestNewElement.AddUrlSegment("id", id);
            var jsonResponse = client.Execute(requestNewElement);
            return MakeRequest<T>(jsonResponse.Content);
        }

        /// <summary>
        /// Wrapper for the method Appolo#GetElementById(Elements, string)
        /// </summary>
        public static T GetElementById<T>(Elements element, int id)
        {
            return GetElementById<T>(element, id.ToString());
        }


    }
}
