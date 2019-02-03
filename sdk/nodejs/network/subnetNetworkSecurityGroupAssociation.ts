// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

export class SubnetNetworkSecurityGroupAssociation extends pulumi.CustomResource {
    /**
     * Get an existing SubnetNetworkSecurityGroupAssociation resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: SubnetNetworkSecurityGroupAssociationState, opts?: pulumi.CustomResourceOptions): SubnetNetworkSecurityGroupAssociation {
        return new SubnetNetworkSecurityGroupAssociation(name, <any>state, { ...opts, id: id });
    }

    public readonly networkSecurityGroupId: pulumi.Output<string>;
    public readonly subnetId: pulumi.Output<string>;

    /**
     * Create a SubnetNetworkSecurityGroupAssociation resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SubnetNetworkSecurityGroupAssociationArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: SubnetNetworkSecurityGroupAssociationArgs | SubnetNetworkSecurityGroupAssociationState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: SubnetNetworkSecurityGroupAssociationState = argsOrState as SubnetNetworkSecurityGroupAssociationState | undefined;
            inputs["networkSecurityGroupId"] = state ? state.networkSecurityGroupId : undefined;
            inputs["subnetId"] = state ? state.subnetId : undefined;
        } else {
            const args = argsOrState as SubnetNetworkSecurityGroupAssociationArgs | undefined;
            if (!args || args.networkSecurityGroupId === undefined) {
                throw new Error("Missing required property 'networkSecurityGroupId'");
            }
            if (!args || args.subnetId === undefined) {
                throw new Error("Missing required property 'subnetId'");
            }
            inputs["networkSecurityGroupId"] = args ? args.networkSecurityGroupId : undefined;
            inputs["subnetId"] = args ? args.subnetId : undefined;
        }
        super("azure:network/subnetNetworkSecurityGroupAssociation:SubnetNetworkSecurityGroupAssociation", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering SubnetNetworkSecurityGroupAssociation resources.
 */
export interface SubnetNetworkSecurityGroupAssociationState {
    readonly networkSecurityGroupId?: pulumi.Input<string>;
    readonly subnetId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a SubnetNetworkSecurityGroupAssociation resource.
 */
export interface SubnetNetworkSecurityGroupAssociationArgs {
    readonly networkSecurityGroupId: pulumi.Input<string>;
    readonly subnetId: pulumi.Input<string>;
}
