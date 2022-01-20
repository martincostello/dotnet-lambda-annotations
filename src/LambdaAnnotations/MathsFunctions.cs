using Amazon.Lambda.Annotations;
using Amazon.Lambda.Core;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace LambdaAnnotations;

public class MathsFunctions
{
    [LambdaFunction]
    [RestApi(HttpMethod.Get, "/{x}/add/{y}")]
    public int Add(int x, int y)
    {
        return x + y;
    }

    [LambdaFunction]
    [RestApi(HttpMethod.Get, "/{x}/subtract/{y}")]
    public int Subtract(int x, int y)
    {
        return x - y;
    }

    [LambdaFunction]
    public async Task<int> AddAsync(int x, int y)
    {
        return await Task.FromResult(x + y);
    }
}
