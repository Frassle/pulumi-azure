// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package containerservice

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Manages a Managed Kubernetes Cluster (also known as AKS / Azure Kubernetes Service)
// 
// > **Note:** All arguments including the client secret will be stored in the raw state as plain-text. [Read more about sensitive data in state](https://www.terraform.io/docs/state/sensitive-data.html).
type KubernetesCluster struct {
	s *pulumi.ResourceState
}

// NewKubernetesCluster registers a new resource with the given unique name, arguments, and options.
func NewKubernetesCluster(ctx *pulumi.Context,
	name string, args *KubernetesClusterArgs, opts ...pulumi.ResourceOpt) (*KubernetesCluster, error) {
	if args == nil || args.AgentPoolProfile == nil {
		return nil, errors.New("missing required argument 'AgentPoolProfile'")
	}
	if args == nil || args.DnsPrefix == nil {
		return nil, errors.New("missing required argument 'DnsPrefix'")
	}
	if args == nil || args.Location == nil {
		return nil, errors.New("missing required argument 'Location'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.ServicePrincipal == nil {
		return nil, errors.New("missing required argument 'ServicePrincipal'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["addonProfile"] = nil
		inputs["agentPoolProfile"] = nil
		inputs["dnsPrefix"] = nil
		inputs["kubernetesVersion"] = nil
		inputs["linuxProfile"] = nil
		inputs["location"] = nil
		inputs["name"] = nil
		inputs["networkProfile"] = nil
		inputs["resourceGroupName"] = nil
		inputs["roleBasedAccessControl"] = nil
		inputs["servicePrincipal"] = nil
		inputs["tags"] = nil
	} else {
		inputs["addonProfile"] = args.AddonProfile
		inputs["agentPoolProfile"] = args.AgentPoolProfile
		inputs["dnsPrefix"] = args.DnsPrefix
		inputs["kubernetesVersion"] = args.KubernetesVersion
		inputs["linuxProfile"] = args.LinuxProfile
		inputs["location"] = args.Location
		inputs["name"] = args.Name
		inputs["networkProfile"] = args.NetworkProfile
		inputs["resourceGroupName"] = args.ResourceGroupName
		inputs["roleBasedAccessControl"] = args.RoleBasedAccessControl
		inputs["servicePrincipal"] = args.ServicePrincipal
		inputs["tags"] = args.Tags
	}
	inputs["fqdn"] = nil
	inputs["kubeAdminConfig"] = nil
	inputs["kubeAdminConfigRaw"] = nil
	inputs["kubeConfig"] = nil
	inputs["kubeConfigRaw"] = nil
	inputs["nodeResourceGroup"] = nil
	s, err := ctx.RegisterResource("azure:containerservice/kubernetesCluster:KubernetesCluster", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &KubernetesCluster{s: s}, nil
}

// GetKubernetesCluster gets an existing KubernetesCluster resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetKubernetesCluster(ctx *pulumi.Context,
	name string, id pulumi.ID, state *KubernetesClusterState, opts ...pulumi.ResourceOpt) (*KubernetesCluster, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["addonProfile"] = state.AddonProfile
		inputs["agentPoolProfile"] = state.AgentPoolProfile
		inputs["dnsPrefix"] = state.DnsPrefix
		inputs["fqdn"] = state.Fqdn
		inputs["kubeAdminConfig"] = state.KubeAdminConfig
		inputs["kubeAdminConfigRaw"] = state.KubeAdminConfigRaw
		inputs["kubeConfig"] = state.KubeConfig
		inputs["kubeConfigRaw"] = state.KubeConfigRaw
		inputs["kubernetesVersion"] = state.KubernetesVersion
		inputs["linuxProfile"] = state.LinuxProfile
		inputs["location"] = state.Location
		inputs["name"] = state.Name
		inputs["networkProfile"] = state.NetworkProfile
		inputs["nodeResourceGroup"] = state.NodeResourceGroup
		inputs["resourceGroupName"] = state.ResourceGroupName
		inputs["roleBasedAccessControl"] = state.RoleBasedAccessControl
		inputs["servicePrincipal"] = state.ServicePrincipal
		inputs["tags"] = state.Tags
	}
	s, err := ctx.ReadResource("azure:containerservice/kubernetesCluster:KubernetesCluster", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &KubernetesCluster{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *KubernetesCluster) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *KubernetesCluster) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// A `addon_profile` block.
func (r *KubernetesCluster) AddonProfile() *pulumi.Output {
	return r.s.State["addonProfile"]
}

// One or more `agent_pool_profile` blocks as documented below.
func (r *KubernetesCluster) AgentPoolProfile() *pulumi.Output {
	return r.s.State["agentPoolProfile"]
}

// DNS prefix specified when creating the managed cluster.
func (r *KubernetesCluster) DnsPrefix() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["dnsPrefix"])
}

// The FQDN of the Azure Kubernetes Managed Cluster.
func (r *KubernetesCluster) Fqdn() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["fqdn"])
}

// A `kube_admin_config` block as defined below. This is only available when Role Based Access Control with Azure Active Directory is enabled.
func (r *KubernetesCluster) KubeAdminConfig() *pulumi.Output {
	return r.s.State["kubeAdminConfig"]
}

// Raw Kubernetes config for the admin account to be used by [kubectl](https://kubernetes.io/docs/reference/kubectl/overview/) and other compatible tools. This is only available when Role Based Access Control with Azure Active Directory is enabled.
func (r *KubernetesCluster) KubeAdminConfigRaw() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["kubeAdminConfigRaw"])
}

// A `kube_config` block as defined below.
func (r *KubernetesCluster) KubeConfig() *pulumi.Output {
	return r.s.State["kubeConfig"]
}

// Raw Kubernetes config to be used by [kubectl](https://kubernetes.io/docs/reference/kubectl/overview/) and other compatible tools
func (r *KubernetesCluster) KubeConfigRaw() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["kubeConfigRaw"])
}

// Version of Kubernetes specified when creating the AKS managed cluster. If not specified, the latest recommended version will be used at provisioning time (but won't auto-upgrade).
func (r *KubernetesCluster) KubernetesVersion() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["kubernetesVersion"])
}

// A `linux_profile` block.
func (r *KubernetesCluster) LinuxProfile() *pulumi.Output {
	return r.s.State["linuxProfile"]
}

// The location where the Managed Kubernetes Cluster should be created. Changing this forces a new resource to be created.
func (r *KubernetesCluster) Location() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["location"])
}

// The name of the Managed Kubernetes Cluster to create. Changing this forces a new resource to be created.
func (r *KubernetesCluster) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// A `network_profile` block.
func (r *KubernetesCluster) NetworkProfile() *pulumi.Output {
	return r.s.State["networkProfile"]
}

// The auto-generated Resource Group which contains the resources for this Managed Kubernetes Cluster.
func (r *KubernetesCluster) NodeResourceGroup() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["nodeResourceGroup"])
}

// Specifies the Resource Group where the Managed Kubernetes Cluster should exist. Changing this forces a new resource to be created.
func (r *KubernetesCluster) ResourceGroupName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["resourceGroupName"])
}

// A `role_based_access_control` block. Changing this forces a new resource to be created.
func (r *KubernetesCluster) RoleBasedAccessControl() *pulumi.Output {
	return r.s.State["roleBasedAccessControl"]
}

// A `service_principal` block as documented below.
func (r *KubernetesCluster) ServicePrincipal() *pulumi.Output {
	return r.s.State["servicePrincipal"]
}

// A mapping of tags to assign to the resource.
func (r *KubernetesCluster) Tags() *pulumi.MapOutput {
	return (*pulumi.MapOutput)(r.s.State["tags"])
}

// Input properties used for looking up and filtering KubernetesCluster resources.
type KubernetesClusterState struct {
	// A `addon_profile` block.
	AddonProfile interface{}
	// One or more `agent_pool_profile` blocks as documented below.
	AgentPoolProfile interface{}
	// DNS prefix specified when creating the managed cluster.
	DnsPrefix interface{}
	// The FQDN of the Azure Kubernetes Managed Cluster.
	Fqdn interface{}
	// A `kube_admin_config` block as defined below. This is only available when Role Based Access Control with Azure Active Directory is enabled.
	KubeAdminConfig interface{}
	// Raw Kubernetes config for the admin account to be used by [kubectl](https://kubernetes.io/docs/reference/kubectl/overview/) and other compatible tools. This is only available when Role Based Access Control with Azure Active Directory is enabled.
	KubeAdminConfigRaw interface{}
	// A `kube_config` block as defined below.
	KubeConfig interface{}
	// Raw Kubernetes config to be used by [kubectl](https://kubernetes.io/docs/reference/kubectl/overview/) and other compatible tools
	KubeConfigRaw interface{}
	// Version of Kubernetes specified when creating the AKS managed cluster. If not specified, the latest recommended version will be used at provisioning time (but won't auto-upgrade).
	KubernetesVersion interface{}
	// A `linux_profile` block.
	LinuxProfile interface{}
	// The location where the Managed Kubernetes Cluster should be created. Changing this forces a new resource to be created.
	Location interface{}
	// The name of the Managed Kubernetes Cluster to create. Changing this forces a new resource to be created.
	Name interface{}
	// A `network_profile` block.
	NetworkProfile interface{}
	// The auto-generated Resource Group which contains the resources for this Managed Kubernetes Cluster.
	NodeResourceGroup interface{}
	// Specifies the Resource Group where the Managed Kubernetes Cluster should exist. Changing this forces a new resource to be created.
	ResourceGroupName interface{}
	// A `role_based_access_control` block. Changing this forces a new resource to be created.
	RoleBasedAccessControl interface{}
	// A `service_principal` block as documented below.
	ServicePrincipal interface{}
	// A mapping of tags to assign to the resource.
	Tags interface{}
}

// The set of arguments for constructing a KubernetesCluster resource.
type KubernetesClusterArgs struct {
	// A `addon_profile` block.
	AddonProfile interface{}
	// One or more `agent_pool_profile` blocks as documented below.
	AgentPoolProfile interface{}
	// DNS prefix specified when creating the managed cluster.
	DnsPrefix interface{}
	// Version of Kubernetes specified when creating the AKS managed cluster. If not specified, the latest recommended version will be used at provisioning time (but won't auto-upgrade).
	KubernetesVersion interface{}
	// A `linux_profile` block.
	LinuxProfile interface{}
	// The location where the Managed Kubernetes Cluster should be created. Changing this forces a new resource to be created.
	Location interface{}
	// The name of the Managed Kubernetes Cluster to create. Changing this forces a new resource to be created.
	Name interface{}
	// A `network_profile` block.
	NetworkProfile interface{}
	// Specifies the Resource Group where the Managed Kubernetes Cluster should exist. Changing this forces a new resource to be created.
	ResourceGroupName interface{}
	// A `role_based_access_control` block. Changing this forces a new resource to be created.
	RoleBasedAccessControl interface{}
	// A `service_principal` block as documented below.
	ServicePrincipal interface{}
	// A mapping of tags to assign to the resource.
	Tags interface{}
}
