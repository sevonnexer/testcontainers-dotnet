namespace DockerEngine;

internal sealed class NamedPipeMessageHandler : HttpMessageHandler
{
    private const string NamedPipe = "npipe://./pipe/docker_engine";

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}