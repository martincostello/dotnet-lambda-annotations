using Amazon.Lambda.Core;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace LambdaAnnotations;

public class MyFunction
{
    public virtual string? ToUpper(string input)
    {
        return input?.ToUpperInvariant();
    }
}
