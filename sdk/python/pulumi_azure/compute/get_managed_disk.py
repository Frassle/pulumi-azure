# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class GetManagedDiskResult(object):
    """
    A collection of values returned by getManagedDisk.
    """
    def __init__(__self__, disk_size_gb=None, os_type=None, source_resource_id=None, source_uri=None, storage_account_type=None, tags=None, zones=None):
        if disk_size_gb and not isinstance(disk_size_gb, int):
            raise TypeError('Expected argument disk_size_gb to be a int')
        __self__.disk_size_gb = disk_size_gb
        """
        The size of the managed disk in gigabytes.
        """
        if os_type and not isinstance(os_type, basestring):
            raise TypeError('Expected argument os_type to be a basestring')
        __self__.os_type = os_type
        """
        The operating system for managed disk. Valid values are `Linux` or `Windows`
        """
        if source_resource_id and not isinstance(source_resource_id, basestring):
            raise TypeError('Expected argument source_resource_id to be a basestring')
        __self__.source_resource_id = source_resource_id
        """
        ID of an existing managed disk that the current resource was created from.
        """
        if source_uri and not isinstance(source_uri, basestring):
            raise TypeError('Expected argument source_uri to be a basestring')
        __self__.source_uri = source_uri
        """
        The source URI for the managed disk
        """
        if storage_account_type and not isinstance(storage_account_type, basestring):
            raise TypeError('Expected argument storage_account_type to be a basestring')
        __self__.storage_account_type = storage_account_type
        """
        The storage account type for the managed disk.
        """
        if tags and not isinstance(tags, dict):
            raise TypeError('Expected argument tags to be a dict')
        __self__.tags = tags
        """
        A mapping of tags assigned to the resource.
        """
        if zones and not isinstance(zones, list):
            raise TypeError('Expected argument zones to be a list')
        __self__.zones = zones
        """
        (Optional) A collection containing the availability zone the managed disk is allocated in.
        """

def get_managed_disk(name=None, resource_group_name=None, tags=None, zones=None):
    """
    Use this data source to access the properties of an existing Azure Managed Disk.
    """
    __args__ = dict()

    __args__['name'] = name
    __args__['resourceGroupName'] = resource_group_name
    __args__['tags'] = tags
    __args__['zones'] = zones
    __ret__ = pulumi.runtime.invoke('azure:compute/getManagedDisk:getManagedDisk', __args__)

    return GetManagedDiskResult(
        disk_size_gb=__ret__.get('diskSizeGb'),
        os_type=__ret__.get('osType'),
        source_resource_id=__ret__.get('sourceResourceId'),
        source_uri=__ret__.get('sourceUri'),
        storage_account_type=__ret__.get('storageAccountType'),
        tags=__ret__.get('tags'),
        zones=__ret__.get('zones'))