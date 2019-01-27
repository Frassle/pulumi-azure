// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Use this data source to access information about all the Subscriptions currently available.
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const azurerm_subscriptions_available = pulumi.output(azure.core.getSubscriptions({}));
 * 
 * export const availableSubscriptions = azurerm_subscriptions_available.apply(__arg0 => __arg0.subscriptions);
 * export const firstAvailableSubscriptionDisplayName = azurerm_subscriptions_available.apply(__arg0 => __arg0.subscriptions[0].displayName);
 * ```
 */
export function getSubscriptions(args?: GetSubscriptionsArgs, opts?: pulumi.InvokeOptions): Promise<GetSubscriptionsResult> {
    args = args || {};
    return pulumi.runtime.invoke("azure:core/getSubscriptions:getSubscriptions", {
        "displayNameContains": args.displayNameContains,
        "displayNamePrefix": args.displayNamePrefix,
    }, opts);
}

/**
 * A collection of arguments for invoking getSubscriptions.
 */
export interface GetSubscriptionsArgs {
    /**
     * A case-insensitive value which must be contained within the `display_name` field, used to filter the results
     */
    readonly displayNameContains?: string;
    /**
     * A case-insensitive prefix which can be used to filter on the `display_name` field
     */
    readonly displayNamePrefix?: string;
}

/**
 * A collection of values returned by getSubscriptions.
 */
export interface GetSubscriptionsResult {
    /**
     * One or more `subscription` blocks as defined below.
     */
    readonly subscriptions: { displayName: string, locationPlacementId: string, quotaId: string, spendingLimit: string, state: string, subscriptionId: string }[];
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
