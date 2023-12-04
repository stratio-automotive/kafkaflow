using System.Collections.Generic;
using System.Linq;
using Confluent.Kafka;
using KafkaFlow.Consumers;

namespace KafkaFlow.Admin.Extensions;

internal static class MessageConsumerExtensions
{
    public static IReadOnlyList<TopicPartition> FilterAssigment(this IMessageConsumer consumer, IList<string> topics)
    {
        return topics.Any() ? consumer.Assignment.Where(a => topics.Contains(a.Topic)).ToList() : consumer.Assignment;
    }
}
