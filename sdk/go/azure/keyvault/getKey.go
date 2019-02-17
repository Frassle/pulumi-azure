// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package keyvault

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Use this data source to access information about an existing Key Vault Key.
// 
// > **Note:** All arguments including the secret value will be stored in the raw state as plain-text.
// [Read more about sensitive data in state](https://www.terraform.io/docs/state/sensitive-data.html).
func LookupKey(ctx *pulumi.Context, args *GetKeyArgs) (*GetKeyResult, error) {
	inputs := make(map[string]interface{})
	if args != nil {
		inputs["keyVaultId"] = args.KeyVaultId
		inputs["name"] = args.Name
		inputs["vaultUri"] = args.VaultUri
	}
	outputs, err := ctx.Invoke("azure:keyvault/getKey:getKey", inputs)
	if err != nil {
		return nil, err
	}
	return &GetKeyResult{
		E: outputs["e"],
		KeyOpts: outputs["keyOpts"],
		KeySize: outputs["keySize"],
		KeyType: outputs["keyType"],
		KeyVaultId: outputs["keyVaultId"],
		N: outputs["n"],
		Tags: outputs["tags"],
		VaultUri: outputs["vaultUri"],
		Version: outputs["version"],
		Id: outputs["id"],
	}, nil
}

// A collection of arguments for invoking getKey.
type GetKeyArgs struct {
	KeyVaultId interface{}
	// Specifies the name of the Key Vault Key.
	Name interface{}
	// Specifies the ID of the Key Vault Key Vault instance where the Key resides, available on the `azurerm_key_vault` Data Source / Resource.
	VaultUri interface{}
}

// A collection of values returned by getKey.
type GetKeyResult struct {
	// The RSA public exponent of this Key Vault Key.
	E interface{}
	// A list of JSON web key operations assigned to this Key Vault Key
	KeyOpts interface{}
	// Specifies the Size of this Key Vault Key.
	KeySize interface{}
	// Specifies the Key Type of this Key Vault Key
	KeyType interface{}
	KeyVaultId interface{}
	// The RSA modulus of this Key Vault Key.
	N interface{}
	// A mapping of tags assigned to this Key Vault Key.
	Tags interface{}
	VaultUri interface{}
	// The current version of the Key Vault Key.
	Version interface{}
	// id is the provider-assigned unique ID for this managed resource.
	Id interface{}
}
