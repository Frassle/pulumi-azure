// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package appservice

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Use this data source to access information about an existing App Service.
func LookupAppService(ctx *pulumi.Context, args *GetAppServiceArgs) (*GetAppServiceResult, error) {
	inputs := make(map[string]interface{})
	if args != nil {
		inputs["name"] = args.Name
		inputs["resourceGroupName"] = args.ResourceGroupName
		inputs["siteConfig"] = args.SiteConfig
	}
	outputs, err := ctx.Invoke("azure:appservice/getAppService:getAppService", inputs)
	if err != nil {
		return nil, err
	}
	return &GetAppServiceResult{
		AppServicePlanId: outputs["appServicePlanId"],
		AppSettings: outputs["appSettings"],
		ClientAffinityEnabled: outputs["clientAffinityEnabled"],
		ConnectionStrings: outputs["connectionStrings"],
		DefaultSiteHostname: outputs["defaultSiteHostname"],
		Enabled: outputs["enabled"],
		HttpsOnly: outputs["httpsOnly"],
		Location: outputs["location"],
		OutboundIpAddresses: outputs["outboundIpAddresses"],
		PossibleOutboundIpAddresses: outputs["possibleOutboundIpAddresses"],
		SiteConfig: outputs["siteConfig"],
		SiteCredentials: outputs["siteCredentials"],
		SourceControls: outputs["sourceControls"],
		Tags: outputs["tags"],
		Id: outputs["id"],
	}, nil
}

// A collection of arguments for invoking getAppService.
type GetAppServiceArgs struct {
	// The name of the App Service.
	Name interface{}
	// The Name of the Resource Group where the App Service exists.
	ResourceGroupName interface{}
	SiteConfig interface{}
}

// A collection of values returned by getAppService.
type GetAppServiceResult struct {
	// The ID of the App Service Plan within which the App Service exists.
	AppServicePlanId interface{}
	// A key-value pair of App Settings for the App Service.
	AppSettings interface{}
	// Does the App Service send session affinity cookies, which route client requests in the same session to the same instance?
	ClientAffinityEnabled interface{}
	// An `connection_string` block as defined below.
	ConnectionStrings interface{}
	DefaultSiteHostname interface{}
	// Is the App Service Enabled?
	Enabled interface{}
	// Can the App Service only be accessed via HTTPS?
	HttpsOnly interface{}
	// The Azure location where the App Service exists.
	Location interface{}
	// A comma separated list of outbound IP addresses - such as `52.23.25.3,52.143.43.12`
	OutboundIpAddresses interface{}
	// A comma separated list of outbound IP addresses - such as `52.23.25.3,52.143.43.12,52.143.43.17` - not all of which are necessarily in use. Superset of `outbound_ip_addresses`.
	PossibleOutboundIpAddresses interface{}
	// A `site_config` block as defined below.
	SiteConfig interface{}
	SiteCredentials interface{}
	SourceControls interface{}
	// A mapping of tags to assign to the resource.
	Tags interface{}
	// id is the provider-assigned unique ID for this managed resource.
	Id interface{}
}
