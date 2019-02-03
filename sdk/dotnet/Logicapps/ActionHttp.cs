// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Logicapps {

	/// <summary>
	/// The set of arguments for constructing a ActionHttp resource.
	/// </summary>
	public struct ActionHttpArgs {
		/// <summary>
		/// Specifies the HTTP Body that should be sent to the `uri` when this HTTP Action is triggered.
		/// </summary>
		public Pulumi.IO<string> Body { get; set; }

		/// <summary>
		/// Specifies a Map of Key-Value Pairs that should be sent to the `uri` when this HTTP Action is triggered.
		/// </summary>
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Headers { get; set; }

		/// <summary>
		/// Specifies the ID of the Logic App Workflow. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> LogicAppId { get; set; }

		/// <summary>
		/// Specifies the HTTP Method which should be used for this HTTP Action. Possible values include `DELETE`, `GET`, `PATCH`, `POST` and `PUT`.
		/// </summary>
		public Pulumi.IO<string> Method { get; set; }

		/// <summary>
		/// Specifies the name of the HTTP Action to be created within the Logic App Workflow. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// Specifies the URI which will be called when this HTTP Action is triggered.
		/// </summary>
		public Pulumi.IO<string> Uri { get; set; }

	} // ActionHttpArgs

	/// <summary>
	/// Manages an HTTP Action within a Logic App Workflow
	/// </summary>
	public class ActionHttp : Pulumi.CustomResource {
		/// <summary>
		/// Specifies the HTTP Body that should be sent to the `uri` when this HTTP Action is triggered.
		/// </summary>
		public Pulumi.IO<string> Body { get; set; }

		/// <summary>
		/// Specifies a Map of Key-Value Pairs that should be sent to the `uri` when this HTTP Action is triggered.
		/// </summary>
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Headers { get; set; }

		/// <summary>
		/// Specifies the ID of the Logic App Workflow. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> LogicAppId { get; set; }

		/// <summary>
		/// Specifies the HTTP Method which should be used for this HTTP Action. Possible values include `DELETE`, `GET`, `PATCH`, `POST` and `PUT`.
		/// </summary>
		public Pulumi.IO<string> Method { get; set; }

		/// <summary>
		/// Specifies the name of the HTTP Action to be created within the Logic App Workflow. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// Specifies the URI which will be called when this HTTP Action is triggered.
		/// </summary>
		public Pulumi.IO<string> Uri { get; set; }

		public ActionHttp(string name, ActionHttpArgs args, Pulumi.ResourceOptions opts = default(Pulumi.ResourceOptions))
			: base("azure:logicapps/actionHttp:ActionHttp", name, SerialiseArgs(args), opts) {
			Body = base.Outputs["body"].Select(item => Protobuf.ToString(item));
			Headers = base.Outputs["headers"].Select(item => Protobuf.ToMap(item));
			LogicAppId = base.Outputs["logicAppId"].Select(item => Protobuf.ToString(item));
			Method = base.Outputs["method"].Select(item => Protobuf.ToString(item));
			Name = base.Outputs["name"].Select(item => Protobuf.ToString(item));
			Uri = base.Outputs["uri"].Select(item => Protobuf.ToString(item));
		} // ctor

		private static Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>> SerialiseArgs(ActionHttpArgs args) {
			var props = new Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>();
			props["body"] = Protobuf.ToProtobuf(args.Body);
			props["headers"] = Protobuf.ToProtobuf(args.Headers);
			props["logicAppId"] = Protobuf.ToProtobuf(args.LogicAppId);
			props["method"] = Protobuf.ToProtobuf(args.Method);
			props["name"] = Protobuf.ToProtobuf(args.Name);
			props["uri"] = Protobuf.ToProtobuf(args.Uri);
			return props;
		} // SerialiseArgs

	} // ActionHttp
} // Pulumi.Azure.Logicapps
