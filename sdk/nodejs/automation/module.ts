// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

export class Module extends pulumi.CustomResource {
    /**
     * Get an existing Module resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ModuleState, opts?: pulumi.CustomResourceOptions): Module {
        return new Module(name, <any>state, { ...opts, id: id });
    }

    public readonly automationAccountName: pulumi.Output<string>;
    public readonly moduleLink: pulumi.Output<{ hash?: { algorithm: string, value: string }, uri: string }>;
    public readonly name: pulumi.Output<string>;
    public readonly resourceGroupName: pulumi.Output<string>;

    /**
     * Create a Module resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ModuleArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ModuleArgs | ModuleState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: ModuleState = argsOrState as ModuleState | undefined;
            inputs["automationAccountName"] = state ? state.automationAccountName : undefined;
            inputs["moduleLink"] = state ? state.moduleLink : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
        } else {
            const args = argsOrState as ModuleArgs | undefined;
            if (!args || args.automationAccountName === undefined) {
                throw new Error("Missing required property 'automationAccountName'");
            }
            if (!args || args.moduleLink === undefined) {
                throw new Error("Missing required property 'moduleLink'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["automationAccountName"] = args ? args.automationAccountName : undefined;
            inputs["moduleLink"] = args ? args.moduleLink : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
        }
        super("azure:automation/module:Module", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Module resources.
 */
export interface ModuleState {
    readonly automationAccountName?: pulumi.Input<string>;
    readonly moduleLink?: pulumi.Input<{ hash?: pulumi.Input<{ algorithm: pulumi.Input<string>, value: pulumi.Input<string> }>, uri: pulumi.Input<string> }>;
    readonly name?: pulumi.Input<string>;
    readonly resourceGroupName?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Module resource.
 */
export interface ModuleArgs {
    readonly automationAccountName: pulumi.Input<string>;
    readonly moduleLink: pulumi.Input<{ hash?: pulumi.Input<{ algorithm: pulumi.Input<string>, value: pulumi.Input<string> }>, uri: pulumi.Input<string> }>;
    readonly name?: pulumi.Input<string>;
    readonly resourceGroupName: pulumi.Input<string>;
}
