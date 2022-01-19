using Amazon.Lambda.Annotations;
using Amazon.Lambda.Core;
using HttpMethod = Amazon.Lambda.Annotations.HttpMethod;

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
}
