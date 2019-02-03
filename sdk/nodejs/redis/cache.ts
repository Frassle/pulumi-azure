// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

export class Cache extends pulumi.CustomResource {
    /**
     * Get an existing Cache resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: CacheState, opts?: pulumi.CustomResourceOptions): Cache {
        return new Cache(name, <any>state, { ...opts, id: id });
    }

    public readonly capacity: pulumi.Output<number>;
    public readonly enableNonSslPort: pulumi.Output<boolean | undefined>;
    public readonly family: pulumi.Output<string>;
    public /*out*/ readonly hostname: pulumi.Output<string>;
    public readonly location: pulumi.Output<string>;
    public readonly name: pulumi.Output<string>;
    public readonly patchSchedules: pulumi.Output<{ dayOfWeek: string, startHourUtc?: number }[] | undefined>;
    public /*out*/ readonly port: pulumi.Output<number>;
    public /*out*/ readonly primaryAccessKey: pulumi.Output<string>;
    public readonly privateStaticIpAddress: pulumi.Output<string>;
    public readonly redisConfiguration: pulumi.Output<{ maxclients: number, maxmemoryDelta: number, maxmemoryPolicy?: string, maxmemoryReserved: number, notifyKeyspaceEvents?: string, rdbBackupEnabled?: boolean, rdbBackupFrequency?: number, rdbBackupMaxSnapshotCount?: number, rdbStorageConnectionString?: string }>;
    public readonly resourceGroupName: pulumi.Output<string>;
    public /*out*/ readonly secondaryAccessKey: pulumi.Output<string>;
    public readonly shardCount: pulumi.Output<number | undefined>;
    public readonly skuName: pulumi.Output<string>;
    public /*out*/ readonly sslPort: pulumi.Output<number>;
    public readonly subnetId: pulumi.Output<string | undefined>;
    public readonly tags: pulumi.Output<{[key: string]: any}>;
    public readonly zones: pulumi.Output<string | undefined>;

    /**
     * Create a Cache resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: CacheArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: CacheArgs | CacheState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: CacheState = argsOrState as CacheState | undefined;
            inputs["capacity"] = state ? state.capacity : undefined;
            inputs["enableNonSslPort"] = state ? state.enableNonSslPort : undefined;
            inputs["family"] = state ? state.family : undefined;
            inputs["hostname"] = state ? state.hostname : undefined;
            inputs["location"] = state ? state.location : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["patchSchedules"] = state ? state.patchSchedules : undefined;
            inputs["port"] = state ? state.port : undefined;
            inputs["primaryAccessKey"] = state ? state.primaryAccessKey : undefined;
            inputs["privateStaticIpAddress"] = state ? state.privateStaticIpAddress : undefined;
            inputs["redisConfiguration"] = state ? state.redisConfiguration : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["secondaryAccessKey"] = state ? state.secondaryAccessKey : undefined;
            inputs["shardCount"] = state ? state.shardCount : undefined;
            inputs["skuName"] = state ? state.skuName : undefined;
            inputs["sslPort"] = state ? state.sslPort : undefined;
            inputs["subnetId"] = state ? state.subnetId : undefined;
            inputs["tags"] = state ? state.tags : undefined;
            inputs["zones"] = state ? state.zones : undefined;
        } else {
            const args = argsOrState as CacheArgs | undefined;
            if (!args || args.capacity === undefined) {
                throw new Error("Missing required property 'capacity'");
            }
            if (!args || args.family === undefined) {
                throw new Error("Missing required property 'family'");
            }
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            if (!args || args.redisConfiguration === undefined) {
                throw new Error("Missing required property 'redisConfiguration'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.skuName === undefined) {
                throw new Error("Missing required property 'skuName'");
            }
            inputs["capacity"] = args ? args.capacity : undefined;
            inputs["enableNonSslPort"] = args ? args.enableNonSslPort : undefined;
            inputs["family"] = args ? args.family : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["patchSchedules"] = args ? args.patchSchedules : undefined;
            inputs["privateStaticIpAddress"] = args ? args.privateStaticIpAddress : undefined;
            inputs["redisConfiguration"] = args ? args.redisConfiguration : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["shardCount"] = args ? args.shardCount : undefined;
            inputs["skuName"] = args ? args.skuName : undefined;
            inputs["subnetId"] = args ? args.subnetId : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["zones"] = args ? args.zones : undefined;
            inputs["hostname"] = undefined /*out*/;
            inputs["port"] = undefined /*out*/;
            inputs["primaryAccessKey"] = undefined /*out*/;
            inputs["secondaryAccessKey"] = undefined /*out*/;
            inputs["sslPort"] = undefined /*out*/;
        }
        super("azure:redis/cache:Cache", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Cache resources.
 */
export interface CacheState {
    readonly capacity?: pulumi.Input<number>;
    readonly enableNonSslPort?: pulumi.Input<boolean>;
    readonly family?: pulumi.Input<string>;
    readonly hostname?: pulumi.Input<string>;
    readonly location?: pulumi.Input<string>;
    readonly name?: pulumi.Input<string>;
    readonly patchSchedules?: pulumi.Input<pulumi.Input<{ dayOfWeek: pulumi.Input<string>, startHourUtc?: pulumi.Input<number> }>[]>;
    readonly port?: pulumi.Input<number>;
    readonly primaryAccessKey?: pulumi.Input<string>;
    readonly privateStaticIpAddress?: pulumi.Input<string>;
    readonly redisConfiguration?: pulumi.Input<{ maxclients?: pulumi.Input<number>, maxmemoryDelta?: pulumi.Input<number>, maxmemoryPolicy?: pulumi.Input<string>, maxmemoryReserved?: pulumi.Input<number>, notifyKeyspaceEvents?: pulumi.Input<string>, rdbBackupEnabled?: pulumi.Input<boolean>, rdbBackupFrequency?: pulumi.Input<number>, rdbBackupMaxSnapshotCount?: pulumi.Input<number>, rdbStorageConnectionString?: pulumi.Input<string> }>;
    readonly resourceGroupName?: pulumi.Input<string>;
    readonly secondaryAccessKey?: pulumi.Input<string>;
    readonly shardCount?: pulumi.Input<number>;
    readonly skuName?: pulumi.Input<string>;
    readonly sslPort?: pulumi.Input<number>;
    readonly subnetId?: pulumi.Input<string>;
    readonly tags?: pulumi.Input<{[key: string]: any}>;
    readonly zones?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Cache resource.
 */
export interface CacheArgs {
    readonly capacity: pulumi.Input<number>;
    readonly enableNonSslPort?: pulumi.Input<boolean>;
    readonly family: pulumi.Input<string>;
    readonly location: pulumi.Input<string>;
    readonly name?: pulumi.Input<string>;
    readonly patchSchedules?: pulumi.Input<pulumi.Input<{ dayOfWeek: pulumi.Input<string>, startHourUtc?: pulumi.Input<number> }>[]>;
    readonly privateStaticIpAddress?: pulumi.Input<string>;
    readonly redisConfiguration: pulumi.Input<{ maxclients?: pulumi.Input<number>, maxmemoryDelta?: pulumi.Input<number>, maxmemoryPolicy?: pulumi.Input<string>, maxmemoryReserved?: pulumi.Input<number>, notifyKeyspaceEvents?: pulumi.Input<string>, rdbBackupEnabled?: pulumi.Input<boolean>, rdbBackupFrequency?: pulumi.Input<number>, rdbBackupMaxSnapshotCount?: pulumi.Input<number>, rdbStorageConnectionString?: pulumi.Input<string> }>;
    readonly resourceGroupName: pulumi.Input<string>;
    readonly shardCount?: pulumi.Input<number>;
    readonly skuName: pulumi.Input<string>;
    readonly subnetId?: pulumi.Input<string>;
    readonly tags?: pulumi.Input<{[key: string]: any}>;
    readonly zones?: pulumi.Input<string>;
}
