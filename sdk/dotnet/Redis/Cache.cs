// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Redis {

	public sealed class CacheArgsPatchSchedule : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> DayOfWeek { get; set; }
		public Pulumi.IO<int> StartHourUtc { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("day_of_week", Protobuf.ToProtobuf(DayOfWeek)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("start_hour_utc", Protobuf.ToProtobuf(StartHourUtc)));
		} // ToProtobuf

	} // CacheArgsPatchSchedule

	public sealed class CacheArgsRedisConfiguration : Pulumi.IIOProtobuf {
		public Pulumi.IO<int> Maxclients { get; set; }
		public Pulumi.IO<int> MaxmemoryDelta { get; set; }
		public Pulumi.IO<string> MaxmemoryPolicy { get; set; }
		public Pulumi.IO<int> MaxmemoryReserved { get; set; }
		public Pulumi.IO<string> NotifyKeyspaceEvents { get; set; }
		public Pulumi.IO<bool> RdbBackupEnabled { get; set; }
		public Pulumi.IO<int> RdbBackupFrequency { get; set; }
		public Pulumi.IO<int> RdbBackupMaxSnapshotCount { get; set; }
		public Pulumi.IO<string> RdbStorageConnectionString { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("maxclients", Protobuf.ToProtobuf(Maxclients)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("maxmemory_delta", Protobuf.ToProtobuf(MaxmemoryDelta)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("maxmemory_policy", Protobuf.ToProtobuf(MaxmemoryPolicy)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("maxmemory_reserved", Protobuf.ToProtobuf(MaxmemoryReserved)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("notify_keyspace_events", Protobuf.ToProtobuf(NotifyKeyspaceEvents)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("rdb_backup_enabled", Protobuf.ToProtobuf(RdbBackupEnabled)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("rdb_backup_frequency", Protobuf.ToProtobuf(RdbBackupFrequency)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("rdb_backup_max_snapshot_count", Protobuf.ToProtobuf(RdbBackupMaxSnapshotCount)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("rdb_storage_connection_string", Protobuf.ToProtobuf(RdbStorageConnectionString)));
		} // ToProtobuf

	} // CacheArgsRedisConfiguration

	public sealed class CachePatchSchedule : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> DayOfWeek { get; set; }
		public Pulumi.IO<int> StartHourUtc { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("day_of_week", Protobuf.ToProtobuf(DayOfWeek)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("start_hour_utc", Protobuf.ToProtobuf(StartHourUtc)));
		} // ToProtobuf

		public static CachePatchSchedule FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new CachePatchSchedule();
				if (obj.Fields.ContainsKey("day_of_week")) {
					result.DayOfWeek = Protobuf.ToString(obj.Fields["day_of_week"]);
				}
				if (obj.Fields.ContainsKey("start_hour_utc")) {
					result.StartHourUtc = Protobuf.ToInt(obj.Fields["start_hour_utc"]);
				}
			return result;
		} // FromProtobuf

	} // CachePatchSchedule

	public sealed class CacheRedisConfiguration : Pulumi.IIOProtobuf {
		public Pulumi.IO<int> Maxclients { get; set; }
		public Pulumi.IO<int> MaxmemoryDelta { get; set; }
		public Pulumi.IO<string> MaxmemoryPolicy { get; set; }
		public Pulumi.IO<int> MaxmemoryReserved { get; set; }
		public Pulumi.IO<string> NotifyKeyspaceEvents { get; set; }
		public Pulumi.IO<bool> RdbBackupEnabled { get; set; }
		public Pulumi.IO<int> RdbBackupFrequency { get; set; }
		public Pulumi.IO<int> RdbBackupMaxSnapshotCount { get; set; }
		public Pulumi.IO<string> RdbStorageConnectionString { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("maxclients", Protobuf.ToProtobuf(Maxclients)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("maxmemory_delta", Protobuf.ToProtobuf(MaxmemoryDelta)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("maxmemory_policy", Protobuf.ToProtobuf(MaxmemoryPolicy)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("maxmemory_reserved", Protobuf.ToProtobuf(MaxmemoryReserved)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("notify_keyspace_events", Protobuf.ToProtobuf(NotifyKeyspaceEvents)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("rdb_backup_enabled", Protobuf.ToProtobuf(RdbBackupEnabled)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("rdb_backup_frequency", Protobuf.ToProtobuf(RdbBackupFrequency)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("rdb_backup_max_snapshot_count", Protobuf.ToProtobuf(RdbBackupMaxSnapshotCount)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("rdb_storage_connection_string", Protobuf.ToProtobuf(RdbStorageConnectionString)));
		} // ToProtobuf

		public static CacheRedisConfiguration FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new CacheRedisConfiguration();
				if (obj.Fields.ContainsKey("maxclients")) {
					result.Maxclients = Protobuf.ToInt(obj.Fields["maxclients"]);
				}
				if (obj.Fields.ContainsKey("maxmemory_delta")) {
					result.MaxmemoryDelta = Protobuf.ToInt(obj.Fields["maxmemory_delta"]);
				}
				if (obj.Fields.ContainsKey("maxmemory_policy")) {
					result.MaxmemoryPolicy = Protobuf.ToString(obj.Fields["maxmemory_policy"]);
				}
				if (obj.Fields.ContainsKey("maxmemory_reserved")) {
					result.MaxmemoryReserved = Protobuf.ToInt(obj.Fields["maxmemory_reserved"]);
				}
				if (obj.Fields.ContainsKey("notify_keyspace_events")) {
					result.NotifyKeyspaceEvents = Protobuf.ToString(obj.Fields["notify_keyspace_events"]);
				}
				if (obj.Fields.ContainsKey("rdb_backup_enabled")) {
					result.RdbBackupEnabled = Protobuf.ToBool(obj.Fields["rdb_backup_enabled"]);
				}
				if (obj.Fields.ContainsKey("rdb_backup_frequency")) {
					result.RdbBackupFrequency = Protobuf.ToInt(obj.Fields["rdb_backup_frequency"]);
				}
				if (obj.Fields.ContainsKey("rdb_backup_max_snapshot_count")) {
					result.RdbBackupMaxSnapshotCount = Protobuf.ToInt(obj.Fields["rdb_backup_max_snapshot_count"]);
				}
				if (obj.Fields.ContainsKey("rdb_storage_connection_string")) {
					result.RdbStorageConnectionString = Protobuf.ToString(obj.Fields["rdb_storage_connection_string"]);
				}
			return result;
		} // FromProtobuf

	} // CacheRedisConfiguration

	/// <summary>
	/// The set of arguments for constructing a Cache resource.
	/// </summary>
	public struct CacheArgs {
		/// <summary>
		/// The size of the Redis cache to deploy. Valid values for a SKU `family` of C (Basic/Standard) are `0, 1, 2, 3, 4, 5, 6`, and for P (Premium) `family` are `1, 2, 3, 4`.
		/// </summary>
		public Pulumi.IO<int> Capacity { get; set; }

		/// <summary>
		/// Enable the non-SSL port (6789) - disabled by default.
		/// </summary>
		public Pulumi.IO<bool> EnableNonSslPort { get; set; }

		/// <summary>
		/// The SKU family to use. Valid values are `C` and `P`, where C = Basic/Standard, P = Premium.
		/// </summary>
		public Pulumi.IO<string> Family { get; set; }

		/// <summary>
		/// The location of the resource group.
		/// </summary>
		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// The name of the Redis instance. Changing this forces a
		/// new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// A list of `patch_schedule` blocks as defined below - only available for Premium SKU's.
		/// </summary>
		public Pulumi.IO<Pulumi.IO<CacheArgsPatchSchedule>[]> PatchSchedules { get; set; }

		/// <summary>
		/// The Static IP Address to assign to the Redis Cache when hosted inside the Virtual Network. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> PrivateStaticIpAddress { get; set; }

		/// <summary>
		/// A `redis_configuration` as defined below - with some limitations by SKU - defaults/details are shown below.
		/// </summary>
		public Pulumi.IO<CacheArgsRedisConfiguration> RedisConfiguration { get; set; }

		/// <summary>
		/// The name of the resource group in which to
		/// create the Redis instance.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// *Only available when using the Premium SKU* The number of Shards to create on the Redis Cluster.
		/// </summary>
		public Pulumi.IO<int> ShardCount { get; set; }

		/// <summary>
		/// The SKU of Redis to use - can be either Basic, Standard or Premium.
		/// </summary>
		public Pulumi.IO<string> SkuName { get; set; }

		/// <summary>
		/// The ID of the Subnet within which the Redis Cache should be deployed. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> SubnetId { get; set; }

		/// <summary>
		/// A mapping of tags to assign to the resource.
		/// </summary>
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Tags { get; set; }

		/// <summary>
		/// A list of a single item of the Availability Zone which the Redis Cache should be allocated in.
		/// </summary>
		public Pulumi.IO<string> Zones { get; set; }

	} // CacheArgs

	/// <summary>
	/// Manages a Redis Cache.
	/// </summary>
	public class Cache : Pulumi.CustomResource {
		/// <summary>
		/// The size of the Redis cache to deploy. Valid values for a SKU `family` of C (Basic/Standard) are `0, 1, 2, 3, 4, 5, 6`, and for P (Premium) `family` are `1, 2, 3, 4`.
		/// </summary>
		public Pulumi.IO<int> Capacity { get; set; }

		/// <summary>
		/// Enable the non-SSL port (6789) - disabled by default.
		/// </summary>
		public Pulumi.IO<bool> EnableNonSslPort { get; set; }

		/// <summary>
		/// The SKU family to use. Valid values are `C` and `P`, where C = Basic/Standard, P = Premium.
		/// </summary>
		public Pulumi.IO<string> Family { get; set; }

		/// <summary>
		/// The Hostname of the Redis Instance
		/// </summary>
		public Pulumi.IO<string> Hostname { get; set; }

		/// <summary>
		/// The location of the resource group.
		/// </summary>
		public Pulumi.IO<string> Location { get; set; }

		/// <summary>
		/// The name of the Redis instance. Changing this forces a
		/// new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// A list of `patch_schedule` blocks as defined below - only available for Premium SKU's.
		/// </summary>
		public Pulumi.IO<CachePatchSchedule[]> PatchSchedules { get; set; }

		/// <summary>
		/// The non-SSL Port of the Redis Instance
		/// </summary>
		public Pulumi.IO<int> Port { get; set; }

		/// <summary>
		/// The Primary Access Key for the Redis Instance
		/// </summary>
		public Pulumi.IO<string> PrimaryAccessKey { get; set; }

		/// <summary>
		/// The Static IP Address to assign to the Redis Cache when hosted inside the Virtual Network. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> PrivateStaticIpAddress { get; set; }

		/// <summary>
		/// A `redis_configuration` as defined below - with some limitations by SKU - defaults/details are shown below.
		/// </summary>
		public Pulumi.IO<CacheRedisConfiguration> RedisConfiguration { get; set; }

		/// <summary>
		/// The name of the resource group in which to
		/// create the Redis instance.
		/// </summary>
		public Pulumi.IO<string> ResourceGroupName { get; set; }

		/// <summary>
		/// The Secondary Access Key for the Redis Instance
		/// </summary>
		public Pulumi.IO<string> SecondaryAccessKey { get; set; }

		/// <summary>
		/// *Only available when using the Premium SKU* The number of Shards to create on the Redis Cluster.
		/// </summary>
		public Pulumi.IO<int> ShardCount { get; set; }

		/// <summary>
		/// The SKU of Redis to use - can be either Basic, Standard or Premium.
		/// </summary>
		public Pulumi.IO<string> SkuName { get; set; }

		/// <summary>
		/// The SSL Port of the Redis Instance
		/// </summary>
		public Pulumi.IO<int> SslPort { get; set; }

		/// <summary>
		/// The ID of the Subnet within which the Redis Cache should be deployed. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> SubnetId { get; set; }

		/// <summary>
		/// A mapping of tags to assign to the resource.
		/// </summary>
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Tags { get; set; }

		/// <summary>
		/// A list of a single item of the Availability Zone which the Redis Cache should be allocated in.
		/// </summary>
		public Pulumi.IO<string> Zones { get; set; }

		public Cache(string name, CacheArgs args, Pulumi.ResourceOptions opts = default(Pulumi.ResourceOptions))
			: base("azure:redis/cache:Cache", name, SerialiseArgs(args), opts) {
			Capacity = base.Outputs["capacity"].Select(item => Protobuf.ToInt(item));
			EnableNonSslPort = base.Outputs["enableNonSslPort"].Select(item => Protobuf.ToBool(item));
			Family = base.Outputs["family"].Select(item => Protobuf.ToString(item));
			Hostname = base.Outputs["hostname"].Select(item => Protobuf.ToString(item));
			Location = base.Outputs["location"].Select(item => Protobuf.ToString(item));
			Name = base.Outputs["name"].Select(item => Protobuf.ToString(item));
			PatchSchedules = base.Outputs["patchSchedules"].Select(item => Protobuf.ToList(item, item1 => CachePatchSchedule.FromProtobuf(item1)));
			Port = base.Outputs["port"].Select(item => Protobuf.ToInt(item));
			PrimaryAccessKey = base.Outputs["primaryAccessKey"].Select(item => Protobuf.ToString(item));
			PrivateStaticIpAddress = base.Outputs["privateStaticIpAddress"].Select(item => Protobuf.ToString(item));
			RedisConfiguration = base.Outputs["redisConfiguration"].Select(item => CacheRedisConfiguration.FromProtobuf(item));
			ResourceGroupName = base.Outputs["resourceGroupName"].Select(item => Protobuf.ToString(item));
			SecondaryAccessKey = base.Outputs["secondaryAccessKey"].Select(item => Protobuf.ToString(item));
			ShardCount = base.Outputs["shardCount"].Select(item => Protobuf.ToInt(item));
			SkuName = base.Outputs["skuName"].Select(item => Protobuf.ToString(item));
			SslPort = base.Outputs["sslPort"].Select(item => Protobuf.ToInt(item));
			SubnetId = base.Outputs["subnetId"].Select(item => Protobuf.ToString(item));
			Tags = base.Outputs["tags"].Select(item => Protobuf.ToMap(item));
			Zones = base.Outputs["zones"].Select(item => Protobuf.ToString(item));
		} // ctor

		private static Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>> SerialiseArgs(CacheArgs args) {
			var props = new Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>();
			props["capacity"] = Protobuf.ToProtobuf(args.Capacity);
			props["enableNonSslPort"] = Protobuf.ToProtobuf(args.EnableNonSslPort);
			props["family"] = Protobuf.ToProtobuf(args.Family);
			props["location"] = Protobuf.ToProtobuf(args.Location);
			props["name"] = Protobuf.ToProtobuf(args.Name);
			props["patchSchedules"] = Protobuf.ToProtobuf(args.PatchSchedules, item => Protobuf.ToProtobuf(item));
			props["privateStaticIpAddress"] = Protobuf.ToProtobuf(args.PrivateStaticIpAddress);
			props["redisConfiguration"] = Protobuf.ToProtobuf(args.RedisConfiguration);
			props["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);
			props["shardCount"] = Protobuf.ToProtobuf(args.ShardCount);
			props["skuName"] = Protobuf.ToProtobuf(args.SkuName);
			props["subnetId"] = Protobuf.ToProtobuf(args.SubnetId);
			props["tags"] = Protobuf.ToProtobuf(args.Tags);
			props["zones"] = Protobuf.ToProtobuf(args.Zones);
			props["hostname"] = null; //out
			props["port"] = null; //out
			props["primaryAccessKey"] = null; //out
			props["secondaryAccessKey"] = null; //out
			props["sslPort"] = null; //out
			return props;
		} // SerialiseArgs

	} // Cache
} // Pulumi.Azure.Redis