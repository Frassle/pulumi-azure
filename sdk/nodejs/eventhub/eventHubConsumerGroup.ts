// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

export class EventHubConsumerGroup extends pulumi.CustomResource {
    /**
     * Get an existing EventHubConsumerGroup resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: EventHubConsumerGroupState, opts?: pulumi.CustomResourceOptions): EventHubConsumerGroup {
        return new EventHubConsumerGroup(name, <any>state, { ...opts, id: id });
    }

    public readonly eventhubName: pulumi.Output<string>;
    public readonly location: pulumi.Output<string | undefined>;
    public readonly name: pulumi.Output<string>;
    public readonly namespaceName: pulumi.Output<string>;
    public readonly resourceGroupName: pulumi.Output<string>;
    public readonly userMetadata: pulumi.Output<string | undefined>;

    /**
     * Create a EventHubConsumerGroup resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: EventHubConsumerGroupArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: EventHubConsumerGroupArgs | EventHubConsumerGroupState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: EventHubConsumerGroupState = argsOrState as EventHubConsumerGroupState | undefined;
            inputs["eventhubName"] = state ? state.eventhubName : undefined;
            inputs["location"] = state ? state.location : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["namespaceName"] = state ? state.namespaceName : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["userMetadata"] = state ? state.userMetadata : undefined;
        } else {
            const args = argsOrState as EventHubConsumerGroupArgs | undefined;
            if (!args || args.eventhubName === undefined) {
                throw new Error("Missing required property 'eventhubName'");
            }
            if (!args || args.namespaceName === undefined) {
                throw new Error("Missing required property 'namespaceName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["eventhubName"] = args ? args.eventhubName : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["namespaceName"] = args ? args.namespaceName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["userMetadata"] = args ? args.userMetadata : undefined;
        }
        super("azure:eventhub/eventHubConsumerGroup:EventHubConsumerGroup", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering EventHubConsumerGroup resources.
 */
export interface EventHubConsumerGroupState {
    readonly eventhubName?: pulumi.Input<string>;
    readonly location?: pulumi.Input<string>;
    readonly name?: pulumi.Input<string>;
    readonly namespaceName?: pulumi.Input<string>;
    readonly resourceGroupName?: pulumi.Input<string>;
    readonly userMetadata?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a EventHubConsumerGroup resource.
 */
export interface EventHubConsumerGroupArgs {
    readonly eventhubName: pulumi.Input<string>;
    readonly location?: pulumi.Input<string>;
    readonly name?: pulumi.Input<string>;
    readonly namespaceName: pulumi.Input<string>;
    readonly resourceGroupName: pulumi.Input<string>;
    readonly userMetadata?: pulumi.Input<string>;
}
