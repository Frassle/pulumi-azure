// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";

/**
 * Manages a Automation Credential.
 */
export class Credential extends pulumi.CustomResource {
    /**
     * Get an existing Credential resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: CredentialState): Credential {
        return new Credential(name, <any>state, { id });
    }

    /**
     * The name of the automation account in which the Credential is created. Changing this forces a new resource to be created.
     */
    public readonly accountName: pulumi.Output<string>;
    /**
     * The description associated with this Automation Credential.
     */
    public readonly description: pulumi.Output<string | undefined>;
    /**
     * Specifies the name of the Credential. Changing this forces a new resource to be created.
     */
    public readonly name: pulumi.Output<string>;
    /**
     * The password associated with this Automation Credential.
     */
    public readonly password: pulumi.Output<string>;
    /**
     * The name of the resource group in which the Credential is created. Changing this forces a new resource to be created.
     */
    public readonly resourceGroupName: pulumi.Output<string>;
    /**
     * The username associated with this Automation Credential.
     */
    public readonly username: pulumi.Output<string>;

    /**
     * Create a Credential resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: CredentialArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: CredentialArgs | CredentialState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: CredentialState = argsOrState as CredentialState | undefined;
            inputs["accountName"] = state ? state.accountName : undefined;
            inputs["description"] = state ? state.description : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["password"] = state ? state.password : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["username"] = state ? state.username : undefined;
        } else {
            const args = argsOrState as CredentialArgs | undefined;
            if (!args || args.accountName === undefined) {
                throw new Error("Missing required property 'accountName'");
            }
            if (!args || args.password === undefined) {
                throw new Error("Missing required property 'password'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.username === undefined) {
                throw new Error("Missing required property 'username'");
            }
            inputs["accountName"] = args ? args.accountName : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["password"] = args ? args.password : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["username"] = args ? args.username : undefined;
        }
        super("azure:automation/credential:Credential", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Credential resources.
 */
export interface CredentialState {
    /**
     * The name of the automation account in which the Credential is created. Changing this forces a new resource to be created.
     */
    readonly accountName?: pulumi.Input<string>;
    /**
     * The description associated with this Automation Credential.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * Specifies the name of the Credential. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The password associated with this Automation Credential.
     */
    readonly password?: pulumi.Input<string>;
    /**
     * The name of the resource group in which the Credential is created. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
    /**
     * The username associated with this Automation Credential.
     */
    readonly username?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Credential resource.
 */
export interface CredentialArgs {
    /**
     * The name of the automation account in which the Credential is created. Changing this forces a new resource to be created.
     */
    readonly accountName: pulumi.Input<string>;
    /**
     * The description associated with this Automation Credential.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * Specifies the name of the Credential. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The password associated with this Automation Credential.
     */
    readonly password: pulumi.Input<string>;
    /**
     * The name of the resource group in which the Credential is created. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The username associated with this Automation Credential.
     */
    readonly username: pulumi.Input<string>;
}
