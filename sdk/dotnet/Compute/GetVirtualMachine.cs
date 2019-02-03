// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Compute {

	/// <summary>
	/// A collection of arguments for invoking getVirtualMachine.
	/// </summary>
	public struct GetVirtualMachineArgs {
		/// <summary>
		/// Specifies the name of the Virtual Machine.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Specifies the name of the resource group the Virtual Machine is located in.
		/// </summary>
		public string ResourceGroupName { get; set; }

	} // GetVirtualMachineArgs

	/// <summary>
	/// A collection of values returned by getVirtualMachine.
	/// </summary>
	public struct GetVirtualMachineResult {
		/// <summary>
		/// id is the provider-assigned unique ID for this managed resource.
		/// </summary>
		public string Id { get; set; }

	} // GetVirtualMachineResult

	public static partial class ComputeModule {
		/// <summary>
		/// Use this data source to access information about an existing Virtual Machine.
		/// </summary>
		public static System.Threading.Tasks.Task<GetVirtualMachineResult> GetVirtualMachine(GetVirtualMachineArgs args, Pulumi.InvokeOptions opts = default(Pulumi.InvokeOptions)) {
			var invokeArgs = new Google.Protobuf.WellKnownTypes.Struct();
			invokeArgs.Fields["name"] = Protobuf.ToProtobuf(args.Name);
			invokeArgs.Fields["resourceGroupName"] = Protobuf.ToProtobuf(args.ResourceGroupName);

			var task = Pulumi.Runtime.InvokeAsync("azure:compute/getVirtualMachine:getVirtualMachine", invokeArgs, opts);

			return task.ContinueWith(response => {
				var protobuf = response.Result;
				var result = new GetVirtualMachineResult();
				if (protobuf.Fields.ContainsKey("id")) {
					result.Id = Protobuf.ToString(protobuf.Fields["id"]);
				}
				return result;
			});
		} // GetVirtualMachine

	} // ComputeModule
} // Pulumi.Azure.Compute
