# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import pulumi
import pulumi.runtime
from .. import utilities, tables

class Contact(pulumi.CustomResource):
    alert_notifications: pulumi.Output[bool]
    """
    Whether to send security alerts notifications to the security contact.
    """
    alerts_to_admins: pulumi.Output[bool]
    """
    Whether to send security alerts notifications to subscription admins.
    """
    email: pulumi.Output[str]
    """
    The email of the Security Center Contact.
    """
    phone: pulumi.Output[str]
    """
    The phone number of the Security Center Contact.
    """
    def __init__(__self__, __name__, __opts__=None, alert_notifications=None, alerts_to_admins=None, email=None, phone=None):
        """
        Manages the subscription's Security Center Contact.
        
        > **NOTE:** Owner access permission is required. 
        
        
        :param str __name__: The name of the resource.
        :param pulumi.ResourceOptions __opts__: Options for the resource.
        :param pulumi.Input[bool] alert_notifications: Whether to send security alerts notifications to the security contact.
        :param pulumi.Input[bool] alerts_to_admins: Whether to send security alerts notifications to subscription admins.
        :param pulumi.Input[str] email: The email of the Security Center Contact.
        :param pulumi.Input[str] phone: The phone number of the Security Center Contact.
        """
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, str):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if not alert_notifications:
            raise TypeError('Missing required property alert_notifications')
        __props__['alert_notifications'] = alert_notifications

        if not alerts_to_admins:
            raise TypeError('Missing required property alerts_to_admins')
        __props__['alerts_to_admins'] = alerts_to_admins

        if not email:
            raise TypeError('Missing required property email')
        __props__['email'] = email

        if not phone:
            raise TypeError('Missing required property phone')
        __props__['phone'] = phone

        super(Contact, __self__).__init__(
            'azure:securitycenter/contact:Contact',
            __name__,
            __props__,
            __opts__)


    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

