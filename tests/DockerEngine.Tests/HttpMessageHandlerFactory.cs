namespace DockerEngine;

internal static class HttpMessageHandlerFactory
{
    public static HttpMessageHandler GetHttpMessageHandler(Uri dockerEndpoint)
    {
        switch (dockerEndpoint.Scheme)
        {
            case "http":
            case "https":
                return new HttpClientHandler();
            case "tcp":
                return new HttpClientHandler();
            case "npipe":
                return new NamedPipeMessageHandler();
            case "unix":
                return new UnixSocketMessageHandler();
            default:
                throw new InvalidOperationException($"The Docker scheme {dockerEndpoint.Scheme} is not supported.");
        }
    }
}