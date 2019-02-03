// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Eventhub {

	/// <summary>
	/// The set of arguments for constructing a Queue resource.
	/// </summary>
	public struct QueueArgs {
		/// <summary>
		/// The ISO 8601 timespan duration of the idle interval after which the
		/// Queue is automatically deleted, minimum of 5 minutes.
		/// </summary>
		public Pulumi.IO<string> AutoDeleteOnIdle { get; set; }

		/// <summary>
		/// Boolean flag which controls whether the Queue has dead letter support when a message expires. Defaults to `false`.
		/// </summary>
		public Pulumi.IO<bool> DeadLetteringOnMessageExpiration { get; set; }

		/// <summary>
		/// The ISO 8601 timespan duration of the TTL of messages sent to this
		/// queue. This is the default value used when TTL is not set on message itself.
		/// </summary>
		public Pulumi.IO<string> DefaultMessageTtl { get; set; }

		/// <summary>
		/// The ISO 8601 timespan duration during which
		/// duplicates can be detected. Default value is 10 minutes. (`PT10M`)
		/// </summary>
		public Pulumi.IO<string> DuplicateDetectionHistoryTimeWindow { get; set; }

		public Pulumi.IO<bool> EnableBatchedOperations { get; set; }

		/// <summary>
		/// Boolean flag which controls whether Express Entities
		/// are enabled. An express queue holds a message in memory temporarily before writing
		/// it to persistent storage. Defaults to `false` for Basic and Standard. For Premium, it MUST
		/// be set to `false`.
		/// </summary>
		public Pulumi.IO<bool> EnableExpress { get; set; }

		/// <summary>
		/// Boolean flag which controls whether to enable
		/// the queue to be partitioned across multiple message brokers. Changing this forces
		/// a new resource to be created. Defaults to `false` for Basic and Standard. For Premium, it MUST
		/// be set to `true`.
		/// </summary>
		public Pulumi.IO<bool> EnablePartitioning { get; set; }

		/// <summary>
		/// Specifies the supported Azure location where the resource exists.
		/// Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// The ISO 8601 timespan duration of a peek-lock; that is, the amount of time that the message is locked for other receivers. Maximum value is 5 minutes. Defaults to 1 minute. (`PT1M`)
		/// </summary>
		public Pulumi.IO<string> LockDuration { get; set; }

		/// <summary>
		/// Integer value which controls when a message is automatically deadlettered. Defaults to `10`.
		/// </summary>
		public Pulumi.IO<int> MaxDeliveryCount { get; set; }

		/// <summary>
		/// Integer value which controls the size of
		/// memory allocated for the queue. For supported values see the "Queue/topic size"
		/// section of [this document](https://docs.microsoft.com/en-us/azure/service-bus-messaging/service-bus-quotas).
		/// </summary>
		public Pulumi.IO<int> MaxSizeInMegabytes { get; set; }

		/// <summary>
		/// Specifies the name of the ServiceBus Queue resource. Changing this forces a
		/// new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The name of the ServiceBus Namespace to create
		/// this queue in. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> NamespaceName { get; set; }

		/// <summary>
		/// Boolean flag which controls whether
		/// the Queue requires duplicate detection. Changing this forces
		/// a new resource to be created. Defaults to `false`.
		/// </summary>
		public Pulumi.IO<bool> RequiresDuplicateDetection { get; set; }

		/// <summary>
		/// Boolean flag which controls whether the Queue requires sessions.
		/// This will allow ordered handling of unbounded sequences of related messages. With sessions enabled
		/// a queue can guarantee first-in-first-out delivery of messages.
		/// Changing this forces a new resource to be created. Defaults to `false`.
		/// </summary>
		public Pulumi.IO<bool> RequiresSession { get; set; }

		/// <summary>
		/// The name of the resource group in which to
		/// create the namespace. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		public Pulumi.IO<bool> SupportOrdering { get; set; }

	} // QueueArgs

	/// <summary>
	/// Manage and manage a ServiceBus Queue.
	/// </summary>
	public class Queue : Pulumi.CustomResource {
		/// <summary>
		/// The ISO 8601 timespan duration of the idle interval after which the
		/// Queue is automatically deleted, minimum of 5 minutes.
		/// </summary>
		public Pulumi.IO<string> AutoDeleteOnIdle { get; set; }

		/// <summary>
		/// Boolean flag which controls whether the Queue has dead letter support when a message expires. Defaults to `false`.
		/// </summary>
		public Pulumi.IO<bool> DeadLetteringOnMessageExpiration { get; set; }

		/// <summary>
		/// The ISO 8601 timespan duration of the TTL of messages sent to this
		/// queue. This is the default value used when TTL is not set on message itself.
		/// </summary>
		public Pulumi.IO<string> DefaultMessageTtl { get; set; }

		/// <summary>
		/// The ISO 8601 timespan duration during which
		/// duplicates can be detected. Default value is 10 minutes. (`PT10M`)
		/// </summary>
		public Pulumi.IO<string> DuplicateDetectionHistoryTimeWindow { get; set; }

		public Pulumi.IO<bool> EnableBatchedOperations { get; set; }

		/// <summary>
		/// Boolean flag which controls whether Express Entities
		/// are enabled. An express queue holds a message in memory temporarily before writing
		/// it to persistent storage. Defaults to `false` for Basic and Standard. For Premium, it MUST
		/// be set to `false`.
		/// </summary>
		public Pulumi.IO<bool> EnableExpress { get; set; }

		/// <summary>
		/// Boolean flag which controls whether to enable
		/// the queue to be partitioned across multiple message brokers. Changing this forces
		/// a new resource to be created. Defaults to `false` for Basic and Standard. For Premium, it MUST
		/// be set to `true`.
		/// </summary>
		public Pulumi.IO<bool> EnablePartitioning { get; set; }

		/// <summary>
		/// Specifies the supported Azure location where the resource exists.
		/// Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// The ISO 8601 timespan duration of a peek-lock; that is, the amount of time that the message is locked for other receivers. Maximum value is 5 minutes. Defaults to 1 minute. (`PT1M`)
		/// </summary>
		public Pulumi.IO<string> LockDuration { get; set; }

		/// <summary>
		/// Integer value which controls when a message is automatically deadlettered. Defaults to `10`.
		/// </summary>
		public Pulumi.IO<int> MaxDeliveryCount { get; set; }

		/// <summary>
		/// Integer value which controls the size of
		/// memory allocated for the queue. For supported values see the "Queue/topic size"
		/// section of [this document](https://docs.microsoft.com/en-us/azure/service-bus-messaging/service-bus-quotas).
		/// </summary>
		public Pulumi.IO<int> MaxSizeInMegabytes { get; set; }

		/// <summary>
		/// Specifies the name of the ServiceBus Queue resource. Changing this forces a
		/// new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The name of the ServiceBus Namespace to create
		/// this queue in. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> NamespaceName { get; set; }

		/// <summary>
		/// Boolean flag which controls whether
		/// the Queue requires duplicate detection. Changing this forces
		/// a new resource to be created. Defaults to `false`.
		/// </summary>
		public Pulumi.IO<bool> RequiresDuplicateDetection { get; set; }

		/// <summary>
		/// Boolean flag which controls whether the Queue requires sessions.
		/// This will allow ordered handling of unbounded sequences of related messages. With sessions enabled
		/// a queue can guarantee first-in-first-out delivery of messages.
		/// Changing this forces a new resource to be created. Defaults to `false`.
		/// </summary>
		public Pulumi.IO<bool> RequiresSession { get; set; }

		/// <summary>
		/// The name of the resource group in which to
		/// create the namespace. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		public Pulumi.IO<bool> SupportOrdering { get; set; }

		public Queue(string name, QueueArgs args, Pulumi.ResourceOptions opts = default(Pulumi.ResourceOptions))
			: base("azure:eventhub/queue:Queue", name, SerialiseArgs(args), opts) {
			AutoDeleteOnIdle = base.Outputs["autoDeleteOnIdle"].Select(item => Protobuf.ToString(item));
			DeadLetteringOnMessageExpiration = base.Outputs["deadLetteringOnMessageExpiration"].Select(item => Protobuf.ToBool(item));
			DefaultMessageTtl = base.Outputs["defaultMessageTtl"].Select(item => Protobuf.ToString(item));
			DuplicateDetectionHistoryTimeWindow = base.Outputs["duplicateDetectionHistoryTimeWindow"].Select(item => Protobuf.ToString(item));
			EnableBatchedOperations = base.Outputs["enableBatchedOperations"].Select(item => Protobuf.ToBool(item));
			EnableExpress = base.Outputs["enableExpress"].Select(item => Protobuf.ToBool(item));
			EnablePartitioning = base.Outputs["enablePartitioning"].Select(item => Protobuf.ToBool(item));
			Location = base.Outputs["location"].Select(item => Protobuf.ToString(item));
			LockDuration = base.Outputs["lockDuration"].Select(item => Protobuf.ToString(item));
			MaxDeliveryCount = base.Outputs["maxDeliveryCount"].Select(item => Protobuf.ToInt(item));
			MaxSizeInMegabytes = base.Outputs["maxSizeInMegabytes"].Select(item => Protobuf.ToInt(item));
			Name = base.Outputs["name"].Select(item => Protobuf.ToString(item));
			NamespaceName = base.Outputs["namespaceName"].Select(item => Protobuf.ToString(item));
			RequiresDuplicateDetection = base.Outputs["requiresDuplicateDetection"].Select(item => Protobuf.ToBool(item));
			RequiresSession = base.Outputs["requiresSession"].Select(item => Protobuf.ToBool(item));
			ResourceGroupName = base.Outputs["resourceGroupName"].Select(item => Protobuf.ToString(item));
			SupportOrdering = base.Outputs["supportOrdering"].Select(item => Protobuf.ToBool(item));
		} // ctor

		private static Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>> SerialiseArgs(QueueArgs args) {
			var props = new Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>();
			props["autoDeleteOnIdle"] = Protobuf.ToProtobuf(args.AutoDeleteOnIdle);
			props["deadLetteringOnMessageExpiration"] = Protobuf.ToProtobuf(args.DeadLetteringOnMessageExpiration);
			props["defaultMessageTtl"] = Protobuf.ToProtobuf(args.DefaultMessageTtl);
			props["duplicateDetectionHistoryTimeWindow"] = Protobuf.ToProtobuf(args.DuplicateDetectionHistoryTimeWindow);
			props["enableBatchedOperations"] = Protobuf.ToProtobuf(args.EnableBatchedOperations);
			props["enableExpress"] = Protobuf.ToProtobuf(args.EnableExpress);
			props["enablePartitioning"] = Protobuf.ToProtobuf(args.EnablePartitioning);
			props["location"] = Protobuf.ToProtobuf(args.Location);
			props["lockDuration"] = Protobuf.ToProtobuf(args.LockDuration);
			props["maxDeliveryCount"] = Protobuf.ToProtobuf(args.MaxDeliveryCount);
			props["maxSizeInMegabytes"] = Protobuf.ToProtobuf(args.MaxSizeInMegabytes);
			props["name"] = Protobuf.ToProtobuf(args.Name);
			props["namespaceName"] = Protobuf.ToProtobuf(args.NamespaceName);
			props["requiresDuplicateDetection"] = Protobuf.ToProtobuf(args.RequiresDuplicateDetection);
			props["requiresSession"] = Protobuf.ToProtobuf(args.RequiresSession);
			props["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);
			props["supportOrdering"] = Protobuf.ToProtobuf(args.SupportOrdering);
			return props;
		} // SerialiseArgs

	} // Queue
} // Pulumi.Azure.Eventhub
