# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class KubernetesCluster(pulumi.CustomResource):
    """
    Manages a managed Kubernetes Cluster (AKS)
    
    ~> **Note:** All arguments including the client secret will be stored in the raw state as plain-text.
    [Read more about sensitive data in state](/docs/state/sensitive-data.html).
    """
    def __init__(__self__, __name__, __opts__=None, addon_profile=None, agent_pool_profile=None, dns_prefix=None, kubernetes_version=None, linux_profile=None, location=None, name=None, network_profile=None, resource_group_name=None, service_principal=None, tags=None):
        """Create a KubernetesCluster resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, basestring):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if addon_profile and not isinstance(addon_profile, dict):
            raise TypeError('Expected property addon_profile to be a dict')
        __self__.addon_profile = addon_profile
        """
        A `addon_profile` block.
        """
        __props__['addonProfile'] = addon_profile

        if not agent_pool_profile:
            raise TypeError('Missing required property agent_pool_profile')
        elif not isinstance(agent_pool_profile, dict):
            raise TypeError('Expected property agent_pool_profile to be a dict')
        __self__.agent_pool_profile = agent_pool_profile
        """
        One or more Agent Pool Profile's block as documented below.
        """
        __props__['agentPoolProfile'] = agent_pool_profile

        if not dns_prefix:
            raise TypeError('Missing required property dns_prefix')
        elif not isinstance(dns_prefix, basestring):
            raise TypeError('Expected property dns_prefix to be a basestring')
        __self__.dns_prefix = dns_prefix
        """
        DNS prefix specified when creating the managed cluster.
        """
        __props__['dnsPrefix'] = dns_prefix

        if kubernetes_version and not isinstance(kubernetes_version, basestring):
            raise TypeError('Expected property kubernetes_version to be a basestring')
        __self__.kubernetes_version = kubernetes_version
        """
        Version of Kubernetes specified when creating the AKS managed cluster. If not specified, the latest recommended version will be used at provisioning time (but won't auto-upgrade).
        """
        __props__['kubernetesVersion'] = kubernetes_version

        if not linux_profile:
            raise TypeError('Missing required property linux_profile')
        elif not isinstance(linux_profile, dict):
            raise TypeError('Expected property linux_profile to be a dict')
        __self__.linux_profile = linux_profile
        """
        A Linux Profile block as documented below.
        """
        __props__['linuxProfile'] = linux_profile

        if not location:
            raise TypeError('Missing required property location')
        elif not isinstance(location, basestring):
            raise TypeError('Expected property location to be a basestring')
        __self__.location = location
        """
        The location where the AKS Managed Cluster instance should be created. Changing this forces a new resource to be created.
        """
        __props__['location'] = location

        if name and not isinstance(name, basestring):
            raise TypeError('Expected property name to be a basestring')
        __self__.name = name
        """
        Unique name of the Agent Pool Profile in the context of the Subscription and Resource Group. Changing this forces a new resource to be created.
        """
        __props__['name'] = name

        if network_profile and not isinstance(network_profile, dict):
            raise TypeError('Expected property network_profile to be a dict')
        __self__.network_profile = network_profile
        """
        A Network Profile block as documented below.
        """
        __props__['networkProfile'] = network_profile

        if not resource_group_name:
            raise TypeError('Missing required property resource_group_name')
        elif not isinstance(resource_group_name, basestring):
            raise TypeError('Expected property resource_group_name to be a basestring')
        __self__.resource_group_name = resource_group_name
        """
        Specifies the resource group where the resource exists. Changing this forces a new resource to be created.
        """
        __props__['resourceGroupName'] = resource_group_name

        if not service_principal:
            raise TypeError('Missing required property service_principal')
        elif not isinstance(service_principal, dict):
            raise TypeError('Expected property service_principal to be a dict')
        __self__.service_principal = service_principal
        """
        A Service Principal block as documented below.
        """
        __props__['servicePrincipal'] = service_principal

        if tags and not isinstance(tags, dict):
            raise TypeError('Expected property tags to be a dict')
        __self__.tags = tags
        """
        A mapping of tags to assign to the resource.
        """
        __props__['tags'] = tags

        __self__.fqdn = pulumi.runtime.UNKNOWN
        """
        The FQDN of the Azure Kubernetes Managed Cluster.
        """
        __self__.kube_config = pulumi.runtime.UNKNOWN
        """
        A `kube_config` block as defined below.
        """
        __self__.kube_config_raw = pulumi.runtime.UNKNOWN
        """
        Raw Kubernetes config to be used by
        [kubectl](https://kubernetes.io/docs/reference/kubectl/overview/) and
        other compatible tools
        """
        __self__.node_resource_group = pulumi.runtime.UNKNOWN
        """
        Auto-generated Resource Group containing AKS Cluster resources.
        """

        super(KubernetesCluster, __self__).__init__(
            'azure:containerservice/kubernetesCluster:KubernetesCluster',
            __name__,
            __props__,
            __opts__)

    def set_outputs(self, outs):
        if 'addonProfile' in outs:
            self.addon_profile = outs['addonProfile']
        if 'agentPoolProfile' in outs:
            self.agent_pool_profile = outs['agentPoolProfile']
        if 'dnsPrefix' in outs:
            self.dns_prefix = outs['dnsPrefix']
        if 'fqdn' in outs:
            self.fqdn = outs['fqdn']
        if 'kubeConfig' in outs:
            self.kube_config = outs['kubeConfig']
        if 'kubeConfigRaw' in outs:
            self.kube_config_raw = outs['kubeConfigRaw']
        if 'kubernetesVersion' in outs:
            self.kubernetes_version = outs['kubernetesVersion']
        if 'linuxProfile' in outs:
            self.linux_profile = outs['linuxProfile']
        if 'location' in outs:
            self.location = outs['location']
        if 'name' in outs:
            self.name = outs['name']
        if 'networkProfile' in outs:
            self.network_profile = outs['networkProfile']
        if 'nodeResourceGroup' in outs:
            self.node_resource_group = outs['nodeResourceGroup']
        if 'resourceGroupName' in outs:
            self.resource_group_name = outs['resourceGroupName']
        if 'servicePrincipal' in outs:
            self.service_principal = outs['servicePrincipal']
        if 'tags' in outs:
            self.tags = outs['tags']
