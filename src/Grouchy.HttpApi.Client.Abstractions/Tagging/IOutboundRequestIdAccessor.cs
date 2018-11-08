namespace Grouchy.HttpApi.Client.Abstractions.Tagging
{
   public interface IOutboundRequestIdAccessor
   {
      string OutboundRequestId { get; set; }
   }
}