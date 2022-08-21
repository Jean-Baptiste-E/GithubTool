using System.Collections.Generic;
using EtsGitTools.Model.Repository;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;

namespace EtsGitTools
{
    public static class GraphQLClientHelper
    {
        private const string CODIGA_API_BASE_URL = "https://api.codiga.io/graphql";

        public static GraphQLHttpClient CreateCodigaGraphQlHttpClient(string token)
        {
            var client = new GraphQLHttpClient(CODIGA_API_BASE_URL, new NewtonsoftJsonSerializer());
            client.HttpClient.DefaultRequestHeaders.Add("X-Api-Token",$"{token}");
            
            return client;
        }
        

    }

    public class CodigaResponseType
    {
        public List<Repository> RepositoryList;
    }
    
}