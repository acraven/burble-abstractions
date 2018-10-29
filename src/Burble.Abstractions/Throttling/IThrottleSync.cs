using System.Threading.Tasks;

namespace Burble.Abstractions.Throttling
{
   public interface IThrottleSync
   {
      Task WaitAsync();

      void Release();
   }
}
