// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

export class ActiveDirectoryAdministrator extends pulumi.CustomResource {
    /**
     * Get an existing ActiveDirectoryAdministrator resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ActiveDirectoryAdministratorState, opts?: pulumi.CustomResourceOptions): ActiveDirectoryAdministrator {
        return new ActiveDirectoryAdministrator(name, <any>state, { ...opts, id: id });
    }

    public readonly login: pulumi.Output<string>;
    public readonly objectId: pulumi.Output<string>;
    public readonly resourceGroupName: pulumi.Output<string>;
    public readonly serverName: pulumi.Output<string>;
    public readonly tenantId: pulumi.Output<string>;

    /**
     * Create a ActiveDirectoryAdministrator resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ActiveDirectoryAdministratorArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ActiveDirectoryAdministratorArgs | ActiveDirectoryAdministratorState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: ActiveDirectoryAdministratorState = argsOrState as ActiveDirectoryAdministratorState | undefined;
            inputs["login"] = state ? state.login : undefined;
            inputs["objectId"] = state ? state.objectId : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["serverName"] = state ? state.serverName : undefined;
            inputs["tenantId"] = state ? state.tenantId : undefined;
        } else {
            const args = argsOrState as ActiveDirectoryAdministratorArgs | undefined;
            if (!args || args.login === undefined) {
                throw new Error("Missing required property 'login'");
            }
            if (!args || args.objectId === undefined) {
                throw new Error("Missing required property 'objectId'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.serverName === undefined) {
                throw new Error("Missing required property 'serverName'");
            }
            if (!args || args.tenantId === undefined) {
                throw new Error("Missing required property 'tenantId'");
            }
            inputs["login"] = args ? args.login : undefined;
            inputs["objectId"] = args ? args.objectId : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["serverName"] = args ? args.serverName : undefined;
            inputs["tenantId"] = args ? args.tenantId : undefined;
        }
        super("azure:sql/activeDirectoryAdministrator:ActiveDirectoryAdministrator", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ActiveDirectoryAdministrator resources.
 */
export interface ActiveDirectoryAdministratorState {
    readonly login?: pulumi.Input<string>;
    readonly objectId?: pulumi.Input<string>;
    readonly resourceGroupName?: pulumi.Input<string>;
    readonly serverName?: pulumi.Input<string>;
    readonly tenantId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ActiveDirectoryAdministrator resource.
 */
export interface ActiveDirectoryAdministratorArgs {
    readonly login: pulumi.Input<string>;
    readonly objectId: pulumi.Input<string>;
    readonly resourceGroupName: pulumi.Input<string>;
    readonly serverName: pulumi.Input<string>;
    readonly tenantId: pulumi.Input<string>;
}
