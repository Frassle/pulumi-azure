# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from .. import utilities, tables

class GetVirtualMachineResult(object):
    """
    A collection of values returned by getVirtualMachine.
    """
    def __init__(__self__, id=None):
        if id and not isinstance(id, str):
            raise TypeError('Expected argument id to be a str')
        __self__.id = id
        """
        id is the provider-assigned unique ID for this managed resource.
        """

async def get_virtual_machine(name=None, resource_group_name=None):
    """
    Use this data source to access information about an existing Virtual Machine.
    """
    __args__ = dict()

    __args__['name'] = name
    __args__['resourceGroupName'] = resource_group_name
    __ret__ = await pulumi.runtime.invoke('azure:compute/getVirtualMachine:getVirtualMachine', __args__)

    return GetVirtualMachineResult(
        id=__ret__.get('id'))
