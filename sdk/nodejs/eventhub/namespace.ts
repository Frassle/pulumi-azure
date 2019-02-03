// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

export class Namespace extends pulumi.CustomResource {
    /**
     * Get an existing Namespace resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: NamespaceState, opts?: pulumi.CustomResourceOptions): Namespace {
        return new Namespace(name, <any>state, { ...opts, id: id });
    }

    public readonly capacity: pulumi.Output<number | undefined>;
    public /*out*/ readonly defaultPrimaryConnectionString: pulumi.Output<string>;
    public /*out*/ readonly defaultPrimaryKey: pulumi.Output<string>;
    public /*out*/ readonly defaultSecondaryConnectionString: pulumi.Output<string>;
    public /*out*/ readonly defaultSecondaryKey: pulumi.Output<string>;
    public readonly location: pulumi.Output<string>;
    public readonly name: pulumi.Output<string>;
    public readonly resourceGroupName: pulumi.Output<string>;
    public readonly sku: pulumi.Output<string>;
    public readonly tags: pulumi.Output<{[key: string]: any}>;

    /**
     * Create a Namespace resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: NamespaceArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: NamespaceArgs | NamespaceState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: NamespaceState = argsOrState as NamespaceState | undefined;
            inputs["capacity"] = state ? state.capacity : undefined;
            inputs["defaultPrimaryConnectionString"] = state ? state.defaultPrimaryConnectionString : undefined;
            inputs["defaultPrimaryKey"] = state ? state.defaultPrimaryKey : undefined;
            inputs["defaultSecondaryConnectionString"] = state ? state.defaultSecondaryConnectionString : undefined;
            inputs["defaultSecondaryKey"] = state ? state.defaultSecondaryKey : undefined;
            inputs["location"] = state ? state.location : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["sku"] = state ? state.sku : undefined;
            inputs["tags"] = state ? state.tags : undefined;
        } else {
            const args = argsOrState as NamespaceArgs | undefined;
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.sku === undefined) {
                throw new Error("Missing required property 'sku'");
            }
            inputs["capacity"] = args ? args.capacity : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["sku"] = args ? args.sku : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["defaultPrimaryConnectionString"] = undefined /*out*/;
            inputs["defaultPrimaryKey"] = undefined /*out*/;
            inputs["defaultSecondaryConnectionString"] = undefined /*out*/;
            inputs["defaultSecondaryKey"] = undefined /*out*/;
        }
        super("azure:eventhub/namespace:Namespace", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Namespace resources.
 */
export interface NamespaceState {
    readonly capacity?: pulumi.Input<number>;
    readonly defaultPrimaryConnectionString?: pulumi.Input<string>;
    readonly defaultPrimaryKey?: pulumi.Input<string>;
    readonly defaultSecondaryConnectionString?: pulumi.Input<string>;
    readonly defaultSecondaryKey?: pulumi.Input<string>;
    readonly location?: pulumi.Input<string>;
    readonly name?: pulumi.Input<string>;
    readonly resourceGroupName?: pulumi.Input<string>;
    readonly sku?: pulumi.Input<string>;
    readonly tags?: pulumi.Input<{[key: string]: any}>;
}

/**
 * The set of arguments for constructing a Namespace resource.
 */
export interface NamespaceArgs {
    readonly capacity?: pulumi.Input<number>;
    readonly location: pulumi.Input<string>;
    readonly name?: pulumi.Input<string>;
    readonly resourceGroupName: pulumi.Input<string>;
    readonly sku: pulumi.Input<string>;
    readonly tags?: pulumi.Input<{[key: string]: any}>;
}
