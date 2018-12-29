// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Manages an availability set for virtual machines.
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const azurerm_resource_group_test = new azure.core.ResourceGroup("test", {
 *     location: "West US",
 *     name: "resourceGroup1",
 * });
 * const azurerm_availability_set_test = new azure.compute.AvailabilitySet("test", {
 *     location: azurerm_resource_group_test.location,
 *     name: "acceptanceTestAvailabilitySet1",
 *     resourceGroupName: azurerm_resource_group_test.name,
 *     tags: {
 *         environment: "Production",
 *     },
 * });
 * ```
 */
export class AvailabilitySet extends pulumi.CustomResource {
    /**
     * Get an existing AvailabilitySet resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: AvailabilitySetState, opts?: pulumi.CustomResourceOptions): AvailabilitySet {
        return new AvailabilitySet(name, <any>state, { ...opts, id: id });
    }

    /**
     * Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
     */
    public readonly location: pulumi.Output<string>;
    /**
     * Specifies whether the availability set is managed or not. Possible values are `true` (to specify aligned) or `false` (to specify classic). Default is `false`.
     */
    public readonly managed: pulumi.Output<boolean | undefined>;
    /**
     * Specifies the name of the availability set. Changing this forces a new resource to be created.
     */
    public readonly name: pulumi.Output<string>;
    /**
     * Specifies the number of fault domains that are used. Defaults to 3.
     */
    public readonly platformFaultDomainCount: pulumi.Output<number | undefined>;
    /**
     * Specifies the number of update domains that are used. Defaults to 5.
     */
    public readonly platformUpdateDomainCount: pulumi.Output<number | undefined>;
    /**
     * The name of the resource group in which to create the availability set. Changing this forces a new resource to be created.
     */
    public readonly resourceGroupName: pulumi.Output<string>;
    /**
     * A mapping of tags to assign to the resource.
     */
    public readonly tags: pulumi.Output<{[key: string]: any}>;

    /**
     * Create a AvailabilitySet resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AvailabilitySetArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: AvailabilitySetArgs | AvailabilitySetState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: AvailabilitySetState = argsOrState as AvailabilitySetState | undefined;
            inputs["location"] = state ? state.location : undefined;
            inputs["managed"] = state ? state.managed : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["platformFaultDomainCount"] = state ? state.platformFaultDomainCount : undefined;
            inputs["platformUpdateDomainCount"] = state ? state.platformUpdateDomainCount : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["tags"] = state ? state.tags : undefined;
        } else {
            const args = argsOrState as AvailabilitySetArgs | undefined;
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["location"] = args ? args.location : undefined;
            inputs["managed"] = args ? args.managed : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["platformFaultDomainCount"] = args ? args.platformFaultDomainCount : undefined;
            inputs["platformUpdateDomainCount"] = args ? args.platformUpdateDomainCount : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
        }
        super("azure:compute/availabilitySet:AvailabilitySet", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering AvailabilitySet resources.
 */
export interface AvailabilitySetState {
    /**
     * Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Specifies whether the availability set is managed or not. Possible values are `true` (to specify aligned) or `false` (to specify classic). Default is `false`.
     */
    readonly managed?: pulumi.Input<boolean>;
    /**
     * Specifies the name of the availability set. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Specifies the number of fault domains that are used. Defaults to 3.
     */
    readonly platformFaultDomainCount?: pulumi.Input<number>;
    /**
     * Specifies the number of update domains that are used. Defaults to 5.
     */
    readonly platformUpdateDomainCount?: pulumi.Input<number>;
    /**
     * The name of the resource group in which to create the availability set. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: any}>;
}

/**
 * The set of arguments for constructing a AvailabilitySet resource.
 */
export interface AvailabilitySetArgs {
    /**
     * Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
     */
    readonly location: pulumi.Input<string>;
    /**
     * Specifies whether the availability set is managed or not. Possible values are `true` (to specify aligned) or `false` (to specify classic). Default is `false`.
     */
    readonly managed?: pulumi.Input<boolean>;
    /**
     * Specifies the name of the availability set. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Specifies the number of fault domains that are used. Defaults to 3.
     */
    readonly platformFaultDomainCount?: pulumi.Input<number>;
    /**
     * Specifies the number of update domains that are used. Defaults to 5.
     */
    readonly platformUpdateDomainCount?: pulumi.Input<number>;
    /**
     * The name of the resource group in which to create the availability set. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: any}>;
}
