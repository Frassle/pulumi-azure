// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Use this data source to access information about an existing Container Registry.
 */
export function getRegistry(args: GetRegistryArgs, opts?: pulumi.InvokeOptions): Promise<GetRegistryResult> {
    return pulumi.runtime.invoke("azure:containerservice/getRegistry:getRegistry", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

/**
 * A collection of arguments for invoking getRegistry.
 */
export interface GetRegistryArgs {
    /**
     * The name of the Container Registry.
     */
    readonly name: string;
    /**
     * The Name of the Resource Group where this Container Registry exists.
     */
    readonly resourceGroupName: string;
}

/**
 * A collection of values returned by getRegistry.
 */
export interface GetRegistryResult {
    /**
     * Is the Administrator account enabled for this Container Registry.
     */
    readonly adminEnabled: boolean;
    /**
     * The Password associated with the Container Registry Admin account - if the admin account is enabled.
     */
    readonly adminPassword: string;
    /**
     * The Username associated with the Container Registry Admin account - if the admin account is enabled.
     */
    readonly adminUsername: string;
    /**
     * The Azure Region in which this Container Registry exists.
     */
    readonly location: string;
    /**
     * The URL that can be used to log into the container registry.
     */
    readonly loginServer: string;
    /**
     * The SKU of this Container Registry, such as `Basic`.
     */
    readonly sku: string;
    /**
     * The ID of the Storage Account used for this Container Registry. This is only returned for `Classic` SKU's.
     */
    readonly storageAccountId: string;
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
