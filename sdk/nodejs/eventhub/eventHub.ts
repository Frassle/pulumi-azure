// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";

/**
 * Manages a Event Hubs as a nested resource within a Event Hubs namespace.
 */
export class EventHub extends pulumi.CustomResource {
    /**
     * Get an existing EventHub resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: EventHubState): EventHub {
        return new EventHub(name, <any>state, { id });
    }

    /**
     * A `capture_description` block as defined below.
     */
    public readonly captureDescription: pulumi.Output<{ destination: { archiveNameFormat: string, blobContainerName: string, name: string, storageAccountId: string }, enabled: boolean, encoding: string, intervalInSeconds?: number, sizeLimitInBytes?: number } | undefined>;
    public readonly location: pulumi.Output<string | undefined>;
    /**
     * Specifies the number of days to retain the events for this Event Hub. Needs to be between 1 and 7 days; or 1 day when using a Basic SKU for the parent EventHub Namespace.
     */
    public readonly messageRetention: pulumi.Output<number>;
    /**
     * The Name of the Destination where the capture should take place. At this time the only supported value is `EventHubArchive.AzureBlockBlob`.
     */
    public readonly name: pulumi.Output<string>;
    /**
     * Specifies the name of the EventHub Namespace. Changing this forces a new resource to be created.
     */
    public readonly namespaceName: pulumi.Output<string>;
    /**
     * Specifies the current number of shards on the Event Hub.
     */
    public readonly partitionCount: pulumi.Output<number>;
    /**
     * The identifiers for partitions created for Event Hubs.
     */
    public /*out*/ readonly partitionIds: pulumi.Output<string[]>;
    /**
     * The name of the resource group in which the EventHub's parent Namespace exists. Changing this forces a new resource to be created.
     */
    public readonly resourceGroupName: pulumi.Output<string>;

    /**
     * Create a EventHub resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: EventHubArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: EventHubArgs | EventHubState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: EventHubState = argsOrState as EventHubState | undefined;
            inputs["captureDescription"] = state ? state.captureDescription : undefined;
            inputs["location"] = state ? state.location : undefined;
            inputs["messageRetention"] = state ? state.messageRetention : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["namespaceName"] = state ? state.namespaceName : undefined;
            inputs["partitionCount"] = state ? state.partitionCount : undefined;
            inputs["partitionIds"] = state ? state.partitionIds : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
        } else {
            const args = argsOrState as EventHubArgs | undefined;
            if (!args || args.messageRetention === undefined) {
                throw new Error("Missing required property 'messageRetention'");
            }
            if (!args || args.namespaceName === undefined) {
                throw new Error("Missing required property 'namespaceName'");
            }
            if (!args || args.partitionCount === undefined) {
                throw new Error("Missing required property 'partitionCount'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["captureDescription"] = args ? args.captureDescription : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["messageRetention"] = args ? args.messageRetention : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["namespaceName"] = args ? args.namespaceName : undefined;
            inputs["partitionCount"] = args ? args.partitionCount : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["partitionIds"] = undefined /*out*/;
        }
        super("azure:eventhub/eventHub:EventHub", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering EventHub resources.
 */
export interface EventHubState {
    /**
     * A `capture_description` block as defined below.
     */
    readonly captureDescription?: pulumi.Input<{ destination: pulumi.Input<{ archiveNameFormat: pulumi.Input<string>, blobContainerName: pulumi.Input<string>, name: pulumi.Input<string>, storageAccountId: pulumi.Input<string> }>, enabled: pulumi.Input<boolean>, encoding: pulumi.Input<string>, intervalInSeconds?: pulumi.Input<number>, sizeLimitInBytes?: pulumi.Input<number> }>;
    readonly location?: pulumi.Input<string>;
    /**
     * Specifies the number of days to retain the events for this Event Hub. Needs to be between 1 and 7 days; or 1 day when using a Basic SKU for the parent EventHub Namespace.
     */
    readonly messageRetention?: pulumi.Input<number>;
    /**
     * The Name of the Destination where the capture should take place. At this time the only supported value is `EventHubArchive.AzureBlockBlob`.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Specifies the name of the EventHub Namespace. Changing this forces a new resource to be created.
     */
    readonly namespaceName?: pulumi.Input<string>;
    /**
     * Specifies the current number of shards on the Event Hub.
     */
    readonly partitionCount?: pulumi.Input<number>;
    /**
     * The identifiers for partitions created for Event Hubs.
     */
    readonly partitionIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The name of the resource group in which the EventHub's parent Namespace exists. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a EventHub resource.
 */
export interface EventHubArgs {
    /**
     * A `capture_description` block as defined below.
     */
    readonly captureDescription?: pulumi.Input<{ destination: pulumi.Input<{ archiveNameFormat: pulumi.Input<string>, blobContainerName: pulumi.Input<string>, name: pulumi.Input<string>, storageAccountId: pulumi.Input<string> }>, enabled: pulumi.Input<boolean>, encoding: pulumi.Input<string>, intervalInSeconds?: pulumi.Input<number>, sizeLimitInBytes?: pulumi.Input<number> }>;
    readonly location?: pulumi.Input<string>;
    /**
     * Specifies the number of days to retain the events for this Event Hub. Needs to be between 1 and 7 days; or 1 day when using a Basic SKU for the parent EventHub Namespace.
     */
    readonly messageRetention: pulumi.Input<number>;
    /**
     * The Name of the Destination where the capture should take place. At this time the only supported value is `EventHubArchive.AzureBlockBlob`.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Specifies the name of the EventHub Namespace. Changing this forces a new resource to be created.
     */
    readonly namespaceName: pulumi.Input<string>;
    /**
     * Specifies the current number of shards on the Event Hub.
     */
    readonly partitionCount: pulumi.Input<number>;
    /**
     * The name of the resource group in which the EventHub's parent Namespace exists. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName: pulumi.Input<string>;
}
