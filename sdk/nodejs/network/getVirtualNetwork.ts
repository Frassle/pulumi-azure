// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

export function getVirtualNetwork(args: GetVirtualNetworkArgs, opts?: pulumi.InvokeOptions): Promise<GetVirtualNetworkResult> {
    return pulumi.runtime.invoke("azure:network/getVirtualNetwork:getVirtualNetwork", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

/**
 * A collection of arguments for invoking getVirtualNetwork.
 */
export interface GetVirtualNetworkArgs {
    readonly name: string;
    readonly resourceGroupName: string;
}

/**
 * A collection of values returned by getVirtualNetwork.
 */
export interface GetVirtualNetworkResult {
    readonly addressSpaces: string[];
    readonly dnsServers: string[];
    readonly subnets: string[];
    readonly vnetPeerings: {[key: string]: any};
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
