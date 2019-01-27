# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import pulumi
import pulumi.runtime
from .. import utilities, tables

class GetSubscriptionResult(object):
    """
    A collection of values returned by getSubscription.
    """
    def __init__(__self__, display_name=None, location_placement_id=None, quota_id=None, spending_limit=None, state=None, subscription_id=None, id=None):
        if display_name and not isinstance(display_name, str):
            raise TypeError('Expected argument display_name to be a str')
        __self__.display_name = display_name
        """
        The subscription display name.
        """
        if location_placement_id and not isinstance(location_placement_id, str):
            raise TypeError('Expected argument location_placement_id to be a str')
        __self__.location_placement_id = location_placement_id
        """
        The subscription location placement ID.
        """
        if quota_id and not isinstance(quota_id, str):
            raise TypeError('Expected argument quota_id to be a str')
        __self__.quota_id = quota_id
        """
        The subscription quota ID.
        """
        if spending_limit and not isinstance(spending_limit, str):
            raise TypeError('Expected argument spending_limit to be a str')
        __self__.spending_limit = spending_limit
        """
        The subscription spending limit.
        """
        if state and not isinstance(state, str):
            raise TypeError('Expected argument state to be a str')
        __self__.state = state
        """
        The subscription state. Possible values are Enabled, Warned, PastDue, Disabled, and Deleted.
        """
        if subscription_id and not isinstance(subscription_id, str):
            raise TypeError('Expected argument subscription_id to be a str')
        __self__.subscription_id = subscription_id
        if id and not isinstance(id, str):
            raise TypeError('Expected argument id to be a str')
        __self__.id = id
        """
        id is the provider-assigned unique ID for this managed resource.
        """

async def get_subscription(subscription_id=None):
    """
    Use this data source to access information about an existing Subscription.
    """
    __args__ = dict()

    __args__['subscriptionId'] = subscription_id
    __ret__ = await pulumi.runtime.invoke('azure:core/getSubscription:getSubscription', __args__)

    return GetSubscriptionResult(
        display_name=__ret__.get('displayName'),
        location_placement_id=__ret__.get('locationPlacementId'),
        quota_id=__ret__.get('quotaId'),
        spending_limit=__ret__.get('spendingLimit'),
        state=__ret__.get('state'),
        subscription_id=__ret__.get('subscriptionId'),
        id=__ret__.get('id'))
