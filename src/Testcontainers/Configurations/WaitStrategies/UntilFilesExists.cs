namespace DotNet.Testcontainers.Configurations
{
  using System.IO;
  using System.Threading.Tasks;
  using DotNet.Testcontainers.Containers;

  internal class UntilFilesExists : IWaitUntil
  {
    private readonly string _file;

    public UntilFilesExists(string file)
    {
      _file = file;
    }

    public Task<bool> UntilAsync(IContainer container)
    {
      try
      {
        await container.ReadFileAsync(_file);
        return true;
      }
      catch
      {
        return false;
      }
    }
  }
}
