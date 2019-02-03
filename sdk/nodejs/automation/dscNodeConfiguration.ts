// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

export class DscNodeConfiguration extends pulumi.CustomResource {
    /**
     * Get an existing DscNodeConfiguration resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DscNodeConfigurationState, opts?: pulumi.CustomResourceOptions): DscNodeConfiguration {
        return new DscNodeConfiguration(name, <any>state, { ...opts, id: id });
    }

    public readonly automationAccountName: pulumi.Output<string>;
    public /*out*/ readonly configurationName: pulumi.Output<string>;
    public readonly contentEmbedded: pulumi.Output<string>;
    public readonly name: pulumi.Output<string>;
    public readonly resourceGroupName: pulumi.Output<string>;

    /**
     * Create a DscNodeConfiguration resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DscNodeConfigurationArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DscNodeConfigurationArgs | DscNodeConfigurationState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: DscNodeConfigurationState = argsOrState as DscNodeConfigurationState | undefined;
            inputs["automationAccountName"] = state ? state.automationAccountName : undefined;
            inputs["configurationName"] = state ? state.configurationName : undefined;
            inputs["contentEmbedded"] = state ? state.contentEmbedded : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
        } else {
            const args = argsOrState as DscNodeConfigurationArgs | undefined;
            if (!args || args.automationAccountName === undefined) {
                throw new Error("Missing required property 'automationAccountName'");
            }
            if (!args || args.contentEmbedded === undefined) {
                throw new Error("Missing required property 'contentEmbedded'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["automationAccountName"] = args ? args.automationAccountName : undefined;
            inputs["contentEmbedded"] = args ? args.contentEmbedded : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["configurationName"] = undefined /*out*/;
        }
        super("azure:automation/dscNodeConfiguration:DscNodeConfiguration", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering DscNodeConfiguration resources.
 */
export interface DscNodeConfigurationState {
    readonly automationAccountName?: pulumi.Input<string>;
    readonly configurationName?: pulumi.Input<string>;
    readonly contentEmbedded?: pulumi.Input<string>;
    readonly name?: pulumi.Input<string>;
    readonly resourceGroupName?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a DscNodeConfiguration resource.
 */
export interface DscNodeConfigurationArgs {
    readonly automationAccountName: pulumi.Input<string>;
    readonly contentEmbedded: pulumi.Input<string>;
    readonly name?: pulumi.Input<string>;
    readonly resourceGroupName: pulumi.Input<string>;
}
