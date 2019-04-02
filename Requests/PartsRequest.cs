using System;
using System.Collections.Generic;
using Octosharp.Responses;

namespace Octosharp.Requests
{
    //example: http://octopart.com/api/v3/parts/103cdb613d20cffb?apikey=APIKEYGOESHERE
    public class PartsRequest : IOctoRequest<OctoJsonResponse>
    {
        private readonly string _endpoint;

        public PartsRequest(string endpoint)
        {
            if (endpoint == null) throw new NullReferenceException("endpoint");
            _endpoint = endpoint;
        }

        public string PathSegment
        {
            get { return "parts/" + _endpoint; }
        }

        public IEnumerable<QueryParameter> QueryParmeters { get; private set; }
    }
}