// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Linq;

namespace Pulumi.Azure.Keyvault {

	public sealed class CertifiateArgsCertificate : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> Contents { get; set; }
		public Pulumi.IO<string> Password { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("contents", Protobuf.ToProtobuf(Contents)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("password", Protobuf.ToProtobuf(Password)));
		} // ToProtobuf

	} // CertifiateArgsCertificate

	public sealed class CertifiateArgsCertificatePolicyArgsIssuerParameter : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> Name { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("name", Protobuf.ToProtobuf(Name)));
		} // ToProtobuf

	} // CertifiateArgsCertificatePolicyArgsIssuerParameter

	public sealed class CertifiateArgsCertificatePolicyArgsKeyProperty : Pulumi.IIOProtobuf {
		public Pulumi.IO<bool> Exportable { get; set; }
		public Pulumi.IO<int> KeySize { get; set; }
		public Pulumi.IO<string> KeyType { get; set; }
		public Pulumi.IO<bool> ReuseKey { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("exportable", Protobuf.ToProtobuf(Exportable)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("key_size", Protobuf.ToProtobuf(KeySize)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("key_type", Protobuf.ToProtobuf(KeyType)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("reuse_key", Protobuf.ToProtobuf(ReuseKey)));
		} // ToProtobuf

	} // CertifiateArgsCertificatePolicyArgsKeyProperty

	public sealed class CertifiateArgsCertificatePolicyArgsLifetimeActionArgsAction : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> ActionType { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("action_type", Protobuf.ToProtobuf(ActionType)));
		} // ToProtobuf

	} // CertifiateArgsCertificatePolicyArgsLifetimeActionArgsAction

	public sealed class CertifiateArgsCertificatePolicyArgsLifetimeActionArgsTrigger : Pulumi.IIOProtobuf {
		public Pulumi.IO<int> DaysBeforeExpiry { get; set; }
		public Pulumi.IO<int> LifetimePercentage { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("days_before_expiry", Protobuf.ToProtobuf(DaysBeforeExpiry)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("lifetime_percentage", Protobuf.ToProtobuf(LifetimePercentage)));
		} // ToProtobuf

	} // CertifiateArgsCertificatePolicyArgsLifetimeActionArgsTrigger

	public sealed class CertifiateArgsCertificatePolicyArgsLifetimeAction : Pulumi.IIOProtobuf {
		public Pulumi.IO<CertifiateArgsCertificatePolicyArgsLifetimeActionArgsAction> Action { get; set; }
		public Pulumi.IO<CertifiateArgsCertificatePolicyArgsLifetimeActionArgsTrigger> Trigger { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("action", Protobuf.ToProtobuf(Action)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("trigger", Protobuf.ToProtobuf(Trigger)));
		} // ToProtobuf

	} // CertifiateArgsCertificatePolicyArgsLifetimeAction

	public sealed class CertifiateArgsCertificatePolicyArgsSecretProperty : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> ContentType { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("content_type", Protobuf.ToProtobuf(ContentType)));
		} // ToProtobuf

	} // CertifiateArgsCertificatePolicyArgsSecretProperty

	public sealed class CertifiateArgsCertificatePolicyArgsX509CertificatePropertyArgsSubjectAlternativeName : Pulumi.IIOProtobuf {
		public Pulumi.IO<Pulumi.IO<string>[]> DnsNames { get; set; }
		public Pulumi.IO<Pulumi.IO<string>[]> Emails { get; set; }
		public Pulumi.IO<Pulumi.IO<string>[]> Upns { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("dns_names", Protobuf.ToProtobuf(DnsNames, item => Protobuf.ToProtobuf(item))),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("emails", Protobuf.ToProtobuf(Emails, item => Protobuf.ToProtobuf(item))),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("upns", Protobuf.ToProtobuf(Upns, item => Protobuf.ToProtobuf(item))));
		} // ToProtobuf

	} // CertifiateArgsCertificatePolicyArgsX509CertificatePropertyArgsSubjectAlternativeName

	public sealed class CertifiateArgsCertificatePolicyArgsX509CertificateProperty : Pulumi.IIOProtobuf {
		public Pulumi.IO<Pulumi.IO<string>[]> ExtendedKeyUsage { get; set; }
		public Pulumi.IO<Pulumi.IO<string>[]> KeyUsage { get; set; }
		public Pulumi.IO<string> Subject { get; set; }
		public Pulumi.IO<CertifiateArgsCertificatePolicyArgsX509CertificatePropertyArgsSubjectAlternativeName> SubjectAlternativeNames { get; set; }
		public Pulumi.IO<int> ValidityInMonths { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("extended_key_usage", Protobuf.ToProtobuf(ExtendedKeyUsage, item => Protobuf.ToProtobuf(item))),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("key_usage", Protobuf.ToProtobuf(KeyUsage, item => Protobuf.ToProtobuf(item))),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("subject", Protobuf.ToProtobuf(Subject)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("subject_alternative_names", Protobuf.ToProtobuf(SubjectAlternativeNames)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("validity_in_months", Protobuf.ToProtobuf(ValidityInMonths)));
		} // ToProtobuf

	} // CertifiateArgsCertificatePolicyArgsX509CertificateProperty

	public sealed class CertifiateArgsCertificatePolicy : Pulumi.IIOProtobuf {
		public Pulumi.IO<CertifiateArgsCertificatePolicyArgsIssuerParameter> IssuerParameters { get; set; }
		public Pulumi.IO<CertifiateArgsCertificatePolicyArgsKeyProperty> KeyProperties { get; set; }
		public Pulumi.IO<Pulumi.IO<CertifiateArgsCertificatePolicyArgsLifetimeAction>[]> LifetimeAction { get; set; }
		public Pulumi.IO<CertifiateArgsCertificatePolicyArgsSecretProperty> SecretProperties { get; set; }
		public Pulumi.IO<CertifiateArgsCertificatePolicyArgsX509CertificateProperty> X509CertificateProperties { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("issuer_parameters", Protobuf.ToProtobuf(IssuerParameters)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("key_properties", Protobuf.ToProtobuf(KeyProperties)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("lifetime_action", Protobuf.ToProtobuf(LifetimeAction, item => Protobuf.ToProtobuf(item))),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("secret_properties", Protobuf.ToProtobuf(SecretProperties)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("x509_certificate_properties", Protobuf.ToProtobuf(X509CertificateProperties)));
		} // ToProtobuf

	} // CertifiateArgsCertificatePolicy

	public sealed class CertifiateCertificate : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> Contents { get; set; }
		public Pulumi.IO<string> Password { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("contents", Protobuf.ToProtobuf(Contents)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("password", Protobuf.ToProtobuf(Password)));
		} // ToProtobuf

		public static CertifiateCertificate FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new CertifiateCertificate();
				if (obj.Fields.ContainsKey("contents")) {
					result.Contents = Protobuf.ToString(obj.Fields["contents"]);
				}
				if (obj.Fields.ContainsKey("password")) {
					result.Password = Protobuf.ToString(obj.Fields["password"]);
				}
			return result;
		} // FromProtobuf

	} // CertifiateCertificate

	public sealed class CertifiateCertificatePolicyIssuerParameter : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> Name { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("name", Protobuf.ToProtobuf(Name)));
		} // ToProtobuf

		public static CertifiateCertificatePolicyIssuerParameter FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new CertifiateCertificatePolicyIssuerParameter();
				if (obj.Fields.ContainsKey("name")) {
					result.Name = Protobuf.ToString(obj.Fields["name"]);
				}
			return result;
		} // FromProtobuf

	} // CertifiateCertificatePolicyIssuerParameter

	public sealed class CertifiateCertificatePolicyKeyProperty : Pulumi.IIOProtobuf {
		public Pulumi.IO<bool> Exportable { get; set; }
		public Pulumi.IO<int> KeySize { get; set; }
		public Pulumi.IO<string> KeyType { get; set; }
		public Pulumi.IO<bool> ReuseKey { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("exportable", Protobuf.ToProtobuf(Exportable)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("key_size", Protobuf.ToProtobuf(KeySize)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("key_type", Protobuf.ToProtobuf(KeyType)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("reuse_key", Protobuf.ToProtobuf(ReuseKey)));
		} // ToProtobuf

		public static CertifiateCertificatePolicyKeyProperty FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new CertifiateCertificatePolicyKeyProperty();
				if (obj.Fields.ContainsKey("exportable")) {
					result.Exportable = Protobuf.ToBool(obj.Fields["exportable"]);
				}
				if (obj.Fields.ContainsKey("key_size")) {
					result.KeySize = Protobuf.ToInt(obj.Fields["key_size"]);
				}
				if (obj.Fields.ContainsKey("key_type")) {
					result.KeyType = Protobuf.ToString(obj.Fields["key_type"]);
				}
				if (obj.Fields.ContainsKey("reuse_key")) {
					result.ReuseKey = Protobuf.ToBool(obj.Fields["reuse_key"]);
				}
			return result;
		} // FromProtobuf

	} // CertifiateCertificatePolicyKeyProperty

	public sealed class CertifiateCertificatePolicyLifetimeActionAction : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> ActionType { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("action_type", Protobuf.ToProtobuf(ActionType)));
		} // ToProtobuf

		public static CertifiateCertificatePolicyLifetimeActionAction FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new CertifiateCertificatePolicyLifetimeActionAction();
				if (obj.Fields.ContainsKey("action_type")) {
					result.ActionType = Protobuf.ToString(obj.Fields["action_type"]);
				}
			return result;
		} // FromProtobuf

	} // CertifiateCertificatePolicyLifetimeActionAction

	public sealed class CertifiateCertificatePolicyLifetimeActionTrigger : Pulumi.IIOProtobuf {
		public Pulumi.IO<int> DaysBeforeExpiry { get; set; }
		public Pulumi.IO<int> LifetimePercentage { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("days_before_expiry", Protobuf.ToProtobuf(DaysBeforeExpiry)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("lifetime_percentage", Protobuf.ToProtobuf(LifetimePercentage)));
		} // ToProtobuf

		public static CertifiateCertificatePolicyLifetimeActionTrigger FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new CertifiateCertificatePolicyLifetimeActionTrigger();
				if (obj.Fields.ContainsKey("days_before_expiry")) {
					result.DaysBeforeExpiry = Protobuf.ToInt(obj.Fields["days_before_expiry"]);
				}
				if (obj.Fields.ContainsKey("lifetime_percentage")) {
					result.LifetimePercentage = Protobuf.ToInt(obj.Fields["lifetime_percentage"]);
				}
			return result;
		} // FromProtobuf

	} // CertifiateCertificatePolicyLifetimeActionTrigger

	public sealed class CertifiateCertificatePolicyLifetimeAction : Pulumi.IIOProtobuf {
		public Pulumi.IO<CertifiateCertificatePolicyLifetimeActionAction> Action { get; set; }
		public Pulumi.IO<CertifiateCertificatePolicyLifetimeActionTrigger> Trigger { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("action", Protobuf.ToProtobuf(Action)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("trigger", Protobuf.ToProtobuf(Trigger)));
		} // ToProtobuf

		public static CertifiateCertificatePolicyLifetimeAction FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new CertifiateCertificatePolicyLifetimeAction();
				if (obj.Fields.ContainsKey("action")) {
					result.Action = CertifiateCertificatePolicyLifetimeActionAction.FromProtobuf(obj.Fields["action"]);
				}
				if (obj.Fields.ContainsKey("trigger")) {
					result.Trigger = CertifiateCertificatePolicyLifetimeActionTrigger.FromProtobuf(obj.Fields["trigger"]);
				}
			return result;
		} // FromProtobuf

	} // CertifiateCertificatePolicyLifetimeAction

	public sealed class CertifiateCertificatePolicySecretProperty : Pulumi.IIOProtobuf {
		public Pulumi.IO<string> ContentType { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("content_type", Protobuf.ToProtobuf(ContentType)));
		} // ToProtobuf

		public static CertifiateCertificatePolicySecretProperty FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new CertifiateCertificatePolicySecretProperty();
				if (obj.Fields.ContainsKey("content_type")) {
					result.ContentType = Protobuf.ToString(obj.Fields["content_type"]);
				}
			return result;
		} // FromProtobuf

	} // CertifiateCertificatePolicySecretProperty

	public sealed class CertifiateCertificatePolicyX509CertificatePropertySubjectAlternativeName : Pulumi.IIOProtobuf {
		public Pulumi.IO<string[]> DnsNames { get; set; }
		public Pulumi.IO<string[]> Emails { get; set; }
		public Pulumi.IO<string[]> Upns { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("dns_names", Protobuf.ToProtobuf(DnsNames, item => Protobuf.ToProtobuf(item))),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("emails", Protobuf.ToProtobuf(Emails, item => Protobuf.ToProtobuf(item))),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("upns", Protobuf.ToProtobuf(Upns, item => Protobuf.ToProtobuf(item))));
		} // ToProtobuf

		public static CertifiateCertificatePolicyX509CertificatePropertySubjectAlternativeName FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new CertifiateCertificatePolicyX509CertificatePropertySubjectAlternativeName();
				if (obj.Fields.ContainsKey("dns_names")) {
					result.DnsNames = Protobuf.ToList(obj.Fields["dns_names"], item => Protobuf.ToString(item));
				}
				if (obj.Fields.ContainsKey("emails")) {
					result.Emails = Protobuf.ToList(obj.Fields["emails"], item => Protobuf.ToString(item));
				}
				if (obj.Fields.ContainsKey("upns")) {
					result.Upns = Protobuf.ToList(obj.Fields["upns"], item => Protobuf.ToString(item));
				}
			return result;
		} // FromProtobuf

	} // CertifiateCertificatePolicyX509CertificatePropertySubjectAlternativeName

	public sealed class CertifiateCertificatePolicyX509CertificateProperty : Pulumi.IIOProtobuf {
		public Pulumi.IO<string[]> ExtendedKeyUsage { get; set; }
		public Pulumi.IO<string[]> KeyUsage { get; set; }
		public Pulumi.IO<string> Subject { get; set; }
		public Pulumi.IO<CertifiateCertificatePolicyX509CertificatePropertySubjectAlternativeName> SubjectAlternativeNames { get; set; }
		public Pulumi.IO<int> ValidityInMonths { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("extended_key_usage", Protobuf.ToProtobuf(ExtendedKeyUsage, item => Protobuf.ToProtobuf(item))),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("key_usage", Protobuf.ToProtobuf(KeyUsage, item => Protobuf.ToProtobuf(item))),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("subject", Protobuf.ToProtobuf(Subject)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("subject_alternative_names", Protobuf.ToProtobuf(SubjectAlternativeNames)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("validity_in_months", Protobuf.ToProtobuf(ValidityInMonths)));
		} // ToProtobuf

		public static CertifiateCertificatePolicyX509CertificateProperty FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new CertifiateCertificatePolicyX509CertificateProperty();
				if (obj.Fields.ContainsKey("extended_key_usage")) {
					result.ExtendedKeyUsage = Protobuf.ToList(obj.Fields["extended_key_usage"], item => Protobuf.ToString(item));
				}
				if (obj.Fields.ContainsKey("key_usage")) {
					result.KeyUsage = Protobuf.ToList(obj.Fields["key_usage"], item => Protobuf.ToString(item));
				}
				if (obj.Fields.ContainsKey("subject")) {
					result.Subject = Protobuf.ToString(obj.Fields["subject"]);
				}
				if (obj.Fields.ContainsKey("subject_alternative_names")) {
					result.SubjectAlternativeNames = CertifiateCertificatePolicyX509CertificatePropertySubjectAlternativeName.FromProtobuf(obj.Fields["subject_alternative_names"]);
				}
				if (obj.Fields.ContainsKey("validity_in_months")) {
					result.ValidityInMonths = Protobuf.ToInt(obj.Fields["validity_in_months"]);
				}
			return result;
		} // FromProtobuf

	} // CertifiateCertificatePolicyX509CertificateProperty

	public sealed class CertifiateCertificatePolicy : Pulumi.IIOProtobuf {
		public Pulumi.IO<CertifiateCertificatePolicyIssuerParameter> IssuerParameters { get; set; }
		public Pulumi.IO<CertifiateCertificatePolicyKeyProperty> KeyProperties { get; set; }
		public Pulumi.IO<CertifiateCertificatePolicyLifetimeAction[]> LifetimeAction { get; set; }
		public Pulumi.IO<CertifiateCertificatePolicySecretProperty> SecretProperties { get; set; }
		public Pulumi.IO<CertifiateCertificatePolicyX509CertificateProperty> X509CertificateProperties { get; set; }

		public Pulumi.IO<Google.Protobuf.WellKnownTypes.Value> ToProtobuf() {
			return Protobuf.ToProtobuf(
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("issuer_parameters", Protobuf.ToProtobuf(IssuerParameters)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("key_properties", Protobuf.ToProtobuf(KeyProperties)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("lifetime_action", Protobuf.ToProtobuf(LifetimeAction, item => Protobuf.ToProtobuf(item))),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("secret_properties", Protobuf.ToProtobuf(SecretProperties)),
				new KeyValuePair<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>("x509_certificate_properties", Protobuf.ToProtobuf(X509CertificateProperties)));
		} // ToProtobuf

		public static CertifiateCertificatePolicy FromProtobuf(Google.Protobuf.WellKnownTypes.Value value) {
			var obj = value.StructValue;
			var result = new CertifiateCertificatePolicy();
				if (obj.Fields.ContainsKey("issuer_parameters")) {
					result.IssuerParameters = CertifiateCertificatePolicyIssuerParameter.FromProtobuf(obj.Fields["issuer_parameters"]);
				}
				if (obj.Fields.ContainsKey("key_properties")) {
					result.KeyProperties = CertifiateCertificatePolicyKeyProperty.FromProtobuf(obj.Fields["key_properties"]);
				}
				if (obj.Fields.ContainsKey("lifetime_action")) {
					result.LifetimeAction = Protobuf.ToList(obj.Fields["lifetime_action"], item => CertifiateCertificatePolicyLifetimeAction.FromProtobuf(item));
				}
				if (obj.Fields.ContainsKey("secret_properties")) {
					result.SecretProperties = CertifiateCertificatePolicySecretProperty.FromProtobuf(obj.Fields["secret_properties"]);
				}
				if (obj.Fields.ContainsKey("x509_certificate_properties")) {
					result.X509CertificateProperties = CertifiateCertificatePolicyX509CertificateProperty.FromProtobuf(obj.Fields["x509_certificate_properties"]);
				}
			return result;
		} // FromProtobuf

	} // CertifiateCertificatePolicy

	/// <summary>
	/// The set of arguments for constructing a Certifiate resource.
	/// </summary>
	public struct CertifiateArgs {
		/// <summary>
		/// A `certificate` block as defined below, used to Import an existing certificate.
		/// </summary>
		public Pulumi.IO<CertifiateArgsCertificate> Certificate { get; set; }

		/// <summary>
		/// A `certificate_policy` block as defined below.
		/// </summary>
		public Pulumi.IO<CertifiateArgsCertificatePolicy> CertificatePolicy { get; set; }

		/// <summary>
		/// The name of the Certificate Issuer. Possible values include `Self`, or the name of a certificate issuing authority supported by Azure. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// A mapping of tags to assign to the resource.
		/// </summary>
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Tags { get; set; }

		/// <summary>
		/// Specifies the URI used to access the Key Vault instance, available on the `azurerm_key_vault` resource.
		/// </summary>
		public Pulumi.IO<string> VaultUri { get; set; }

	} // CertifiateArgs

	/// <summary>
	/// Manages a Key Vault Certificate.
	/// </summary>
	public class Certifiate : Pulumi.CustomResource {
		/// <summary>
		/// A `certificate` block as defined below, used to Import an existing certificate.
		/// </summary>
		public Pulumi.IO<CertifiateCertificate> Certificate { get; set; }

		/// <summary>
		/// The raw Key Vault Certificate.
		/// </summary>
		public Pulumi.IO<string> CertificateData { get; set; }

		/// <summary>
		/// A `certificate_policy` block as defined below.
		/// </summary>
		public Pulumi.IO<CertifiateCertificatePolicy> CertificatePolicy { get; set; }

		/// <summary>
		/// The name of the Certificate Issuer. Possible values include `Self`, or the name of a certificate issuing authority supported by Azure. Changing this forces a new resource to be created.
		/// </summary>
		public Pulumi.IO<string> Name { get; set; }

		/// <summary>
		/// The ID of the associated Key Vault Secret.
		/// </summary>
		public Pulumi.IO<string> SecretId { get; set; }

		/// <summary>
		/// A mapping of tags to assign to the resource.
		/// </summary>
		public Pulumi.IO<System.Collections.Generic.Dictionary<string, string>> Tags { get; set; }

		/// <summary>
		/// The X509 Thumbprint of the Key Vault Certificate returned as hex string.
		/// </summary>
		public Pulumi.IO<string> Thumbprint { get; set; }

		/// <summary>
		/// Specifies the URI used to access the Key Vault instance, available on the `azurerm_key_vault` resource.
		/// </summary>
		public Pulumi.IO<string> VaultUri { get; set; }

		/// <summary>
		/// The current version of the Key Vault Certificate.
		/// </summary>
		public Pulumi.IO<string> Version { get; set; }

		public Certifiate(string name, CertifiateArgs args, Pulumi.ResourceOptions opts = default(Pulumi.ResourceOptions))
			: base("azure:keyvault/certifiate:Certifiate", name, SerialiseArgs(args), opts) {
			Certificate = base.Outputs["certificate"].Select(item => CertifiateCertificate.FromProtobuf(item));
			CertificateData = base.Outputs["certificateData"].Select(item => Protobuf.ToString(item));
			CertificatePolicy = base.Outputs["certificatePolicy"].Select(item => CertifiateCertificatePolicy.FromProtobuf(item));
			Name = base.Outputs["name"].Select(item => Protobuf.ToString(item));
			SecretId = base.Outputs["secretId"].Select(item => Protobuf.ToString(item));
			Tags = base.Outputs["tags"].Select(item => Protobuf.ToMap(item));
			Thumbprint = base.Outputs["thumbprint"].Select(item => Protobuf.ToString(item));
			VaultUri = base.Outputs["vaultUri"].Select(item => Protobuf.ToString(item));
			Version = base.Outputs["version"].Select(item => Protobuf.ToString(item));
		} // ctor

		private static Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>> SerialiseArgs(CertifiateArgs args) {
			var props = new Dictionary<string, Pulumi.IO<Google.Protobuf.WellKnownTypes.Value>>();
			props["certificate"] = Protobuf.ToProtobuf(args.Certificate);
			props["certificatePolicy"] = Protobuf.ToProtobuf(args.CertificatePolicy);
			props["name"] = Protobuf.ToProtobuf(args.Name);
			props["tags"] = Protobuf.ToProtobuf(args.Tags);
			props["vaultUri"] = Protobuf.ToProtobuf(args.VaultUri);
			props["certificateData"] = null; //out
			props["secretId"] = null; //out
			props["thumbprint"] = null; //out
			props["version"] = null; //out
			return props;
		} // SerialiseArgs

	} // Certifiate
} // Pulumi.Azure.Keyvault
