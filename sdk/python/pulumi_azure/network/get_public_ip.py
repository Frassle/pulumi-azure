# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import pulumi
import pulumi.runtime
from .. import utilities, tables

class GetPublicIPResult(object):
    """
    A collection of values returned by getPublicIP.
    """
    def __init__(__self__, allocation_method=None, domain_name_label=None, fqdn=None, idle_timeout_in_minutes=None, ip_address=None, ip_version=None, location=None, reverse_fqdn=None, sku=None, tags=None, zones=None, id=None):
        if allocation_method and not isinstance(allocation_method, str):
            raise TypeError('Expected argument allocation_method to be a str')
        __self__.allocation_method = allocation_method
        if domain_name_label and not isinstance(domain_name_label, str):
            raise TypeError('Expected argument domain_name_label to be a str')
        __self__.domain_name_label = domain_name_label
        """
        The label for the Domain Name.
        """
        if fqdn and not isinstance(fqdn, str):
            raise TypeError('Expected argument fqdn to be a str')
        __self__.fqdn = fqdn
        """
        Fully qualified domain name of the A DNS record associated with the public IP. This is the concatenation of the domainNameLabel and the regionalized DNS zone.
        """
        if idle_timeout_in_minutes and not isinstance(idle_timeout_in_minutes, int):
            raise TypeError('Expected argument idle_timeout_in_minutes to be a int')
        __self__.idle_timeout_in_minutes = idle_timeout_in_minutes
        """
        Specifies the timeout for the TCP idle connection.
        """
        if ip_address and not isinstance(ip_address, str):
            raise TypeError('Expected argument ip_address to be a str')
        __self__.ip_address = ip_address
        """
        The IP address value that was allocated.
        """
        if ip_version and not isinstance(ip_version, str):
            raise TypeError('Expected argument ip_version to be a str')
        __self__.ip_version = ip_version
        """
        The IP version being used, for example `IPv4` or `IPv6`.
        """
        if location and not isinstance(location, str):
            raise TypeError('Expected argument location to be a str')
        __self__.location = location
        if reverse_fqdn and not isinstance(reverse_fqdn, str):
            raise TypeError('Expected argument reverse_fqdn to be a str')
        __self__.reverse_fqdn = reverse_fqdn
        if sku and not isinstance(sku, str):
            raise TypeError('Expected argument sku to be a str')
        __self__.sku = sku
        if tags and not isinstance(tags, dict):
            raise TypeError('Expected argument tags to be a dict')
        __self__.tags = tags
        """
        A mapping of tags to assigned to the resource.
        """
        if zones and not isinstance(zones, list):
            raise TypeError('Expected argument zones to be a list')
        __self__.zones = zones
        if id and not isinstance(id, str):
            raise TypeError('Expected argument id to be a str')
        __self__.id = id
        """
        id is the provider-assigned unique ID for this managed resource.
        """

async def get_public_ip(name=None, resource_group_name=None, tags=None, zones=None):
    """
    Use this data source to access information about an existing Public IP Address.
    """
    __args__ = dict()

    __args__['name'] = name
    __args__['resourceGroupName'] = resource_group_name
    __args__['tags'] = tags
    __args__['zones'] = zones
    __ret__ = await pulumi.runtime.invoke('azure:network/getPublicIP:getPublicIP', __args__)

    return GetPublicIPResult(
        allocation_method=__ret__.get('allocationMethod'),
        domain_name_label=__ret__.get('domainNameLabel'),
        fqdn=__ret__.get('fqdn'),
        idle_timeout_in_minutes=__ret__.get('idleTimeoutInMinutes'),
        ip_address=__ret__.get('ipAddress'),
        ip_version=__ret__.get('ipVersion'),
        location=__ret__.get('location'),
        reverse_fqdn=__ret__.get('reverseFqdn'),
        sku=__ret__.get('sku'),
        tags=__ret__.get('tags'),
        zones=__ret__.get('zones'),
        id=__ret__.get('id'))
