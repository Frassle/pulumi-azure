# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime
from .. import utilities, tables

class NatRule(pulumi.CustomResource):
    """
    Manages a Load Balancer NAT Rule.
    
    ~> **NOTE** When using this resource, the Load Balancer needs to have a FrontEnd IP Configuration Attached
    """
    def __init__(__self__, __name__, __opts__=None, backend_port=None, enable_floating_ip=None, frontend_ip_configuration_name=None, frontend_port=None, loadbalancer_id=None, location=None, name=None, protocol=None, resource_group_name=None):
        """Create a NatRule resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, str):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if not backend_port:
            raise TypeError('Missing required property backend_port')
        __props__['backend_port'] = backend_port

        __props__['enable_floating_ip'] = enable_floating_ip

        if not frontend_ip_configuration_name:
            raise TypeError('Missing required property frontend_ip_configuration_name')
        __props__['frontend_ip_configuration_name'] = frontend_ip_configuration_name

        if not frontend_port:
            raise TypeError('Missing required property frontend_port')
        __props__['frontend_port'] = frontend_port

        if not loadbalancer_id:
            raise TypeError('Missing required property loadbalancer_id')
        __props__['loadbalancer_id'] = loadbalancer_id

        __props__['location'] = location

        __props__['name'] = name

        if not protocol:
            raise TypeError('Missing required property protocol')
        __props__['protocol'] = protocol

        if not resource_group_name:
            raise TypeError('Missing required property resource_group_name')
        __props__['resource_group_name'] = resource_group_name

        __props__['backend_ip_configuration_id'] = None
        __props__['frontend_ip_configuration_id'] = None

        super(NatRule, __self__).__init__(
            'azure:lb/natRule:NatRule',
            __name__,
            __props__,
            __opts__)


    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

