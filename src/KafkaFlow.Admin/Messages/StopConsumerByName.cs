using System.Runtime.Serialization;

namespace KafkaFlow.Admin.Messages;

/// <summary>
/// The message that stops a consumer
/// </summary>
[DataContract]
public class StopConsumerByName : IAdminMessage
{
    /// <summary>
    /// Gets or sets the consumer name that will be stopped
    /// </summary>
    [DataMember(Order = 1)]
    public string ConsumerName { get; set; }
}
