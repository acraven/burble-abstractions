namespace Grouchy.HttpApi.Client.Abstractions.Configuration
{
   public interface IHttpApiWithThrottling : IHttpApiConfiguration
   {
      string ThrottlePolicy { get; }
   }
}