using Amazon.Lambda.Annotations;
using Amazon.Lambda.Core;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace LambdaAnnotations;

public class MathsFunctions
{
    [LambdaFunction]
    [RestApi(LambdaHttpMethod.Get, "/{x}/add/{y}")]
    public int Add(int x, int y)
    {
        return x + y;
    }

    [LambdaFunction]
    [RestApi(LambdaHttpMethod.Get, "/{x}/subtract/{y}")]
    public int Subtract(int x, int y)
    {
        return x - y;
    }
}
