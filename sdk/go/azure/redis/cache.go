// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package redis

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Manages a Redis Cache.
type Cache struct {
	s *pulumi.ResourceState
}

// NewCache registers a new resource with the given unique name, arguments, and options.
func NewCache(ctx *pulumi.Context,
	name string, args *CacheArgs, opts ...pulumi.ResourceOpt) (*Cache, error) {
	if args == nil || args.Capacity == nil {
		return nil, errors.New("missing required argument 'Capacity'")
	}
	if args == nil || args.Family == nil {
		return nil, errors.New("missing required argument 'Family'")
	}
	if args == nil || args.Location == nil {
		return nil, errors.New("missing required argument 'Location'")
	}
	if args == nil || args.RedisConfiguration == nil {
		return nil, errors.New("missing required argument 'RedisConfiguration'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.SkuName == nil {
		return nil, errors.New("missing required argument 'SkuName'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["capacity"] = nil
		inputs["enableNonSslPort"] = nil
		inputs["family"] = nil
		inputs["location"] = nil
		inputs["name"] = nil
		inputs["patchSchedules"] = nil
		inputs["privateStaticIpAddress"] = nil
		inputs["redisConfiguration"] = nil
		inputs["resourceGroupName"] = nil
		inputs["shardCount"] = nil
		inputs["skuName"] = nil
		inputs["subnetId"] = nil
		inputs["tags"] = nil
	} else {
		inputs["capacity"] = args.Capacity
		inputs["enableNonSslPort"] = args.EnableNonSslPort
		inputs["family"] = args.Family
		inputs["location"] = args.Location
		inputs["name"] = args.Name
		inputs["patchSchedules"] = args.PatchSchedules
		inputs["privateStaticIpAddress"] = args.PrivateStaticIpAddress
		inputs["redisConfiguration"] = args.RedisConfiguration
		inputs["resourceGroupName"] = args.ResourceGroupName
		inputs["shardCount"] = args.ShardCount
		inputs["skuName"] = args.SkuName
		inputs["subnetId"] = args.SubnetId
		inputs["tags"] = args.Tags
	}
	inputs["hostname"] = nil
	inputs["port"] = nil
	inputs["primaryAccessKey"] = nil
	inputs["secondaryAccessKey"] = nil
	inputs["sslPort"] = nil
	s, err := ctx.RegisterResource("azure:redis/cache:Cache", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Cache{s: s}, nil
}

// GetCache gets an existing Cache resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCache(ctx *pulumi.Context,
	name string, id pulumi.ID, state *CacheState, opts ...pulumi.ResourceOpt) (*Cache, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["capacity"] = state.Capacity
		inputs["enableNonSslPort"] = state.EnableNonSslPort
		inputs["family"] = state.Family
		inputs["hostname"] = state.Hostname
		inputs["location"] = state.Location
		inputs["name"] = state.Name
		inputs["patchSchedules"] = state.PatchSchedules
		inputs["port"] = state.Port
		inputs["primaryAccessKey"] = state.PrimaryAccessKey
		inputs["privateStaticIpAddress"] = state.PrivateStaticIpAddress
		inputs["redisConfiguration"] = state.RedisConfiguration
		inputs["resourceGroupName"] = state.ResourceGroupName
		inputs["secondaryAccessKey"] = state.SecondaryAccessKey
		inputs["shardCount"] = state.ShardCount
		inputs["skuName"] = state.SkuName
		inputs["sslPort"] = state.SslPort
		inputs["subnetId"] = state.SubnetId
		inputs["tags"] = state.Tags
	}
	s, err := ctx.ReadResource("azure:redis/cache:Cache", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Cache{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *Cache) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *Cache) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// The size of the Redis cache to deploy. Valid values for a SKU `family` of C (Basic/Standard) are `0, 1, 2, 3, 4, 5, 6`, and for P (Premium) `family` are `1, 2, 3, 4`.
func (r *Cache) Capacity() *pulumi.IntOutput {
	return (*pulumi.IntOutput)(r.s.State["capacity"])
}

// Enable the non-SSL port (6789) - disabled by default.
func (r *Cache) EnableNonSslPort() *pulumi.BoolOutput {
	return (*pulumi.BoolOutput)(r.s.State["enableNonSslPort"])
}

// The SKU family to use. Valid values are `C` and `P`, where C = Basic/Standard, P = Premium.
func (r *Cache) Family() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["family"])
}

// The Hostname of the Redis Instance
func (r *Cache) Hostname() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["hostname"])
}

// The location of the resource group.
func (r *Cache) Location() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["location"])
}

// The name of the Redis instance. Changing this forces a
// new resource to be created.
func (r *Cache) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// A list of `patch_schedule` blocks as defined below - only available for Premium SKU's.
func (r *Cache) PatchSchedules() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["patchSchedules"])
}

// The non-SSL Port of the Redis Instance
func (r *Cache) Port() *pulumi.IntOutput {
	return (*pulumi.IntOutput)(r.s.State["port"])
}

// The Primary Access Key for the Redis Instance
func (r *Cache) PrimaryAccessKey() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["primaryAccessKey"])
}

// The Static IP Address to assign to the Redis Cache when hosted inside the Virtual Network. Changing this forces a new resource to be created.
func (r *Cache) PrivateStaticIpAddress() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["privateStaticIpAddress"])
}

// A `redis_configuration` as defined below - with some limitations by SKU - defaults/details are shown below.
func (r *Cache) RedisConfiguration() *pulumi.Output {
	return r.s.State["redisConfiguration"]
}

// The name of the resource group in which to
// create the Redis instance.
func (r *Cache) ResourceGroupName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["resourceGroupName"])
}

// The Secondary Access Key for the Redis Instance
func (r *Cache) SecondaryAccessKey() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["secondaryAccessKey"])
}

// *Only available when using the Premium SKU* The number of Shards to create on the Redis Cluster.
func (r *Cache) ShardCount() *pulumi.IntOutput {
	return (*pulumi.IntOutput)(r.s.State["shardCount"])
}

// The SKU of Redis to use - can be either Basic, Standard or Premium.
func (r *Cache) SkuName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["skuName"])
}

// The SSL Port of the Redis Instance
func (r *Cache) SslPort() *pulumi.IntOutput {
	return (*pulumi.IntOutput)(r.s.State["sslPort"])
}

// The ID of the Subnet within which the Redis Cache should be deployed. Changing this forces a new resource to be created.
func (r *Cache) SubnetId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["subnetId"])
}

func (r *Cache) Tags() *pulumi.MapOutput {
	return (*pulumi.MapOutput)(r.s.State["tags"])
}

// Input properties used for looking up and filtering Cache resources.
type CacheState struct {
	// The size of the Redis cache to deploy. Valid values for a SKU `family` of C (Basic/Standard) are `0, 1, 2, 3, 4, 5, 6`, and for P (Premium) `family` are `1, 2, 3, 4`.
	Capacity interface{}
	// Enable the non-SSL port (6789) - disabled by default.
	EnableNonSslPort interface{}
	// The SKU family to use. Valid values are `C` and `P`, where C = Basic/Standard, P = Premium.
	Family interface{}
	// The Hostname of the Redis Instance
	Hostname interface{}
	// The location of the resource group.
	Location interface{}
	// The name of the Redis instance. Changing this forces a
	// new resource to be created.
	Name interface{}
	// A list of `patch_schedule` blocks as defined below - only available for Premium SKU's.
	PatchSchedules interface{}
	// The non-SSL Port of the Redis Instance
	Port interface{}
	// The Primary Access Key for the Redis Instance
	PrimaryAccessKey interface{}
	// The Static IP Address to assign to the Redis Cache when hosted inside the Virtual Network. Changing this forces a new resource to be created.
	PrivateStaticIpAddress interface{}
	// A `redis_configuration` as defined below - with some limitations by SKU - defaults/details are shown below.
	RedisConfiguration interface{}
	// The name of the resource group in which to
	// create the Redis instance.
	ResourceGroupName interface{}
	// The Secondary Access Key for the Redis Instance
	SecondaryAccessKey interface{}
	// *Only available when using the Premium SKU* The number of Shards to create on the Redis Cluster.
	ShardCount interface{}
	// The SKU of Redis to use - can be either Basic, Standard or Premium.
	SkuName interface{}
	// The SSL Port of the Redis Instance
	SslPort interface{}
	// The ID of the Subnet within which the Redis Cache should be deployed. Changing this forces a new resource to be created.
	SubnetId interface{}
	Tags interface{}
}

// The set of arguments for constructing a Cache resource.
type CacheArgs struct {
	// The size of the Redis cache to deploy. Valid values for a SKU `family` of C (Basic/Standard) are `0, 1, 2, 3, 4, 5, 6`, and for P (Premium) `family` are `1, 2, 3, 4`.
	Capacity interface{}
	// Enable the non-SSL port (6789) - disabled by default.
	EnableNonSslPort interface{}
	// The SKU family to use. Valid values are `C` and `P`, where C = Basic/Standard, P = Premium.
	Family interface{}
	// The location of the resource group.
	Location interface{}
	// The name of the Redis instance. Changing this forces a
	// new resource to be created.
	Name interface{}
	// A list of `patch_schedule` blocks as defined below - only available for Premium SKU's.
	PatchSchedules interface{}
	// The Static IP Address to assign to the Redis Cache when hosted inside the Virtual Network. Changing this forces a new resource to be created.
	PrivateStaticIpAddress interface{}
	// A `redis_configuration` as defined below - with some limitations by SKU - defaults/details are shown below.
	RedisConfiguration interface{}
	// The name of the resource group in which to
	// create the Redis instance.
	ResourceGroupName interface{}
	// *Only available when using the Premium SKU* The number of Shards to create on the Redis Cluster.
	ShardCount interface{}
	// The SKU of Redis to use - can be either Basic, Standard or Premium.
	SkuName interface{}
	// The ID of the Subnet within which the Redis Cache should be deployed. Changing this forces a new resource to be created.
	SubnetId interface{}
	Tags interface{}
}
