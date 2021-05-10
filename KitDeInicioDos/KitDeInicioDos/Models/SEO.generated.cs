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
	// Mixin Content Type with alias "sEO"
	/// <summary>SEO</summary>
	public partial interface ISEO : IPublishedContent
	{
		/// <summary>Descripcion</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.13.0")]
		string Descripcion { get; }

		/// <summary>Titulo</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.13.0")]
		string Titulo { get; }
	}

	/// <summary>SEO</summary>
	[PublishedModel("sEO")]
	public partial class SEO : PublishedContentModel, ISEO
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.13.0")]
		public new const string ModelTypeAlias = "sEO";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.13.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.13.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.13.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SEO, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public SEO(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Descripcion
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.13.0")]
		[ImplementPropertyType("descripcion")]
		public virtual string Descripcion => GetDescripcion(this);

		/// <summary>Static getter for Descripcion</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.13.0")]
		public static string GetDescripcion(ISEO that) => that.Value<string>("descripcion");

		///<summary>
		/// Titulo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.13.0")]
		[ImplementPropertyType("titulo")]
		public virtual string Titulo => GetTitulo(this);

		/// <summary>Static getter for Titulo</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.13.0")]
		public static string GetTitulo(ISEO that) => that.Value<string>("titulo");
	}
}
