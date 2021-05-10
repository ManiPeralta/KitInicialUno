//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.13.0
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	/// <summary>Ajustes Generales</summary>
	[PublishedModel("ajustesGenerales")]
	public partial class AjustesGenerales : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.13.0")]
		public new const string ModelTypeAlias = "ajustesGenerales";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.13.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.13.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.13.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<AjustesGenerales, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public AjustesGenerales(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Email De Envio: Para hacer uso del formulario de contacto, se necesita una direccion de email
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.13.0")]
		[ImplementPropertyType("emailDeEnvio")]
		public virtual string EmailDeEnvio => this.Value<string>("emailDeEnvio");

		///<summary>
		/// Email De Recepcion: A este email le llegaran los emails. Puedes poner mas de un email separado por comas
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.13.0")]
		[ImplementPropertyType("emailDeRecepcion")]
		public virtual string EmailDeRecepcion => this.Value<string>("emailDeRecepcion");

		///<summary>
		/// Estilo Menu
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.13.0")]
		[ImplementPropertyType("estiloMenu")]
		public virtual string EstiloMenu => this.Value<string>("estiloMenu");

		///<summary>
		/// Estilo Pie De Pagina
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.13.0")]
		[ImplementPropertyType("estiloPieDePagina")]
		public virtual string EstiloPieDePagina => this.Value<string>("estiloPieDePagina");

		///<summary>
		/// Favicon
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.13.0")]
		[ImplementPropertyType("favicon")]
		public virtual global::Umbraco.Core.Models.PublishedContent.IPublishedContent Favicon => this.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("favicon");

		///<summary>
		/// Logotipo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.13.0")]
		[ImplementPropertyType("logotipo")]
		public virtual global::Umbraco.Core.Models.PublishedContent.IPublishedContent Logotipo => this.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("logotipo");

		///<summary>
		/// Menu Principal
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.13.0")]
		[ImplementPropertyType("menuPrincipal")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.Models.Link> MenuPrincipal => this.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Web.Models.Link>>("menuPrincipal");

		///<summary>
		/// Nombre Del Sitio
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.13.0")]
		[ImplementPropertyType("nombreDelSitio")]
		public virtual string NombreDelSitio => this.Value<string>("nombreDelSitio");

		///<summary>
		/// Recaptcha Secret Key
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.13.0")]
		[ImplementPropertyType("recaptchaSecretKey")]
		public virtual string RecaptchaSecretKey => this.Value<string>("recaptchaSecretKey");

		///<summary>
		/// Recaptcha Site Key
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.13.0")]
		[ImplementPropertyType("recaptchaSiteKey")]
		public virtual string RecaptchaSiteKey => this.Value<string>("recaptchaSiteKey");
	}
}
