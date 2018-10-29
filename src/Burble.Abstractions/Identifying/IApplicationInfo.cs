namespace Burble.Abstractions.Identifying
{
   public interface IApplicationInfo
   {
      string Name { get; }
      
      string Version { get; }
      
      string Environment { get; }
      
      string OperatingSystem { get; }
   }
}