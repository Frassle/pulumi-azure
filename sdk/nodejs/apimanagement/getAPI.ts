// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Use this data source to access information about an existing API Management Service.
 */
export function getAPI(args: GetAPIArgs, opts?: pulumi.InvokeOptions): Promise<GetAPIResult> {
    return pulumi.runtime.invoke("azure:apimanagement/getAPI:getAPI", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

/**
 * A collection of arguments for invoking getAPI.
 */
export interface GetAPIArgs {
    /**
     * The name of the API Management service.
     */
    readonly name: string;
    /**
     * The Name of the Resource Group in which the API Management Service exists.
     */
    readonly resourceGroupName: string;
}

/**
 * A collection of values returned by getAPI.
 */
export interface GetAPIResult {
    /**
     * One or more `additional_location` blocks as defined below
     */
    readonly additionalLocations: { gatewayRegionalUrl: string, location: string, publicIpAddresses: string[] }[];
    /**
     * Gateway URL of the API Management service in the Region.
     */
    readonly gatewayRegionalUrl: string;
    /**
     * The URL for the API Management Service's Gateway.
     */
    readonly gatewayUrl: string;
    /**
     * A `hostname_configuration` block as defined below.
     */
    readonly hostnameConfigurations: { managements: { hostName: string, keyVaultId: string, negotiateClientCertificate: boolean }[], portals: { hostName: string, keyVaultId: string, negotiateClientCertificate: boolean }[], proxies: { defaultSslBinding: boolean, hostName: string, keyVaultId: string, negotiateClientCertificate: boolean }[], scms: { hostName: string, keyVaultId: string, negotiateClientCertificate: boolean }[] }[];
    /**
     * The location name of the additional region among Azure Data center regions.
     */
    readonly location: string;
    /**
     * The URL for the Management API.
     */
    readonly managementApiUrl: string;
    /**
     * The email address from which the notification will be sent.
     */
    readonly notificationSenderEmail: string;
    /**
     * The URL of the Publisher Portal.
     */
    readonly portalUrl: string;
    /**
     * Public Static Load Balanced IP addresses of the API Management service in the additional location. Available only for Basic, Standard and Premium SKU.
     */
    readonly publicIpAddresses: string[];
    /**
     * The email of Publisher/Company of the API Management Service.
     */
    readonly publisherEmail: string;
    /**
     * The name of the Publisher/Company of the API Management Service.
     */
    readonly publisherName: string;
    /**
     * The SCM (Source Code Management) endpoint.
     */
    readonly scmUrl: string;
    /**
     * A `sku` block as documented below.
     */
    readonly sku: { capacity: number, name: string };
    /**
     * A mapping of tags assigned to the resource.
     */
    readonly tags: {[key: string]: any};
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
