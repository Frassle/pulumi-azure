// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Use this data source to access information about an existing Key Vault Key.
 * 
 * > **Note:** All arguments including the secret value will be stored in the raw state as plain-text.
 * [Read more about sensitive data in state](https://www.terraform.io/docs/state/sensitive-data.html).
 */
export function getKey(args: GetKeyArgs, opts?: pulumi.InvokeOptions): Promise<GetKeyResult> {
    return pulumi.runtime.invoke("azure:keyvault/getKey:getKey", {
        "name": args.name,
        "vaultUri": args.vaultUri,
    }, opts);
}

/**
 * A collection of arguments for invoking getKey.
 */
export interface GetKeyArgs {
    /**
     * Specifies the name of the Key Vault Key.
     */
    readonly name: string;
    /**
     * Specifies the URI used to access the Key Vault instance, available on the `azurerm_key_vault` Data Source / Resource.
     */
    readonly vaultUri: string;
}

/**
 * A collection of values returned by getKey.
 */
export interface GetKeyResult {
    /**
     * The RSA public exponent of this Key Vault Key.
     */
    readonly e: string;
    /**
     * A list of JSON web key operations assigned to this Key Vault Key
     */
    readonly keyOpts: string[];
    /**
     * Specifies the Size of this Key Vault Key.
     */
    readonly keySize: number;
    /**
     * Specifies the Key Type of this Key Vault Key
     */
    readonly keyType: string;
    /**
     * The RSA modulus of this Key Vault Key.
     */
    readonly n: string;
    /**
     * A mapping of tags assigned to this Key Vault Key.
     */
    readonly tags: {[key: string]: any};
    /**
     * The current version of the Key Vault Key.
     */
    readonly version: string;
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
