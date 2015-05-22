using System.Collections.Generic;
using Octosharp.Requests;
using Octosharp.Responses;

namespace Octosharp
{
    public interface IOctoRequest<TResponse> where TResponse : OctoJsonResponse
    {
        string PathSegment { get; }
        IEnumerable<QueryParameter> QueryParmeters { get; }
    }
}