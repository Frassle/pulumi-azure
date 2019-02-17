// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Use this data source to access information about a built-in Role Definition. To access information about a custom Role Definition, please see the `azurerm_role_definition` data source instead.
 * 
 * > **NOTE:** The this datasource has been deprecated in favour of `azurerm_role_definition` that now can look up role definitions by name. As such this data source will be removed in version 2.0 of the AzureRM Provider.
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const contributor = pulumi.output(azure.role.getBuiltinRoleDefinition({
 *     name: "Contributor",
 * }));
 * 
 * export const contributorRoleDefinitionId = contributor.apply(contributor => contributor.id);
 * ```
 */
export function getBuiltinRoleDefinition(args: GetBuiltinRoleDefinitionArgs, opts?: pulumi.InvokeOptions): Promise<GetBuiltinRoleDefinitionResult> {
    return pulumi.runtime.invoke("azure:role/getBuiltinRoleDefinition:getBuiltinRoleDefinition", {
        "name": args.name,
    }, opts);
}

/**
 * A collection of arguments for invoking getBuiltinRoleDefinition.
 */
export interface GetBuiltinRoleDefinitionArgs {
    /**
     * Specifies the name of the built-in Role Definition. Possible values are: `Contributor`, `Owner`, `Reader` and `VirtualMachineContributor`.
     */
    readonly name: string;
}

/**
 * A collection of values returned by getBuiltinRoleDefinition.
 */
export interface GetBuiltinRoleDefinitionResult {
    /**
     * One or more assignable scopes for this Role Definition, such as `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333`, `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup`, or `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM`.
     */
    readonly assignableScopes: string[];
    /**
     * the Description of the built-in Role.
     */
    readonly description: string;
    /**
     * a `permissions` block as documented below.
     */
    readonly permissions: { actions: string[], dataActions: string[], notActions: string[], notDataActions: string[] }[];
    /**
     * the Type of the Role.
     */
    readonly type: string;
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
