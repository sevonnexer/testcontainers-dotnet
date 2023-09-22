namespace DockerEngine;

internal sealed class UnixSocketMessageHandler : HttpMessageHandler
{
    private const string UnixSocket = "unix:///var/run/docker.sock";

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}