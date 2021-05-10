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
	/// <summary>Pagina</summary>
	[PublishedModel("pagina")]
	public partial class Pagina : PublishedContentModel, IContenido, IResumen, ISEO
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.13.0")]
		public new const string ModelTypeAlias = "pagina";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.13.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.13.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.13.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Pagina, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Pagina(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Contenido Principal
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.13.0")]
		[ImplementPropertyType("contenidoPrincipal")]
		public virtual global::Umbraco.Core.Models.Blocks.BlockListModel ContenidoPrincipal => global::Umbraco.Web.PublishedModels.Contenido.GetContenidoPrincipal(this);

		///<summary>
		/// Extracto
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.13.0")]
		[ImplementPropertyType("extracto")]
		public virtual string Extracto => global::Umbraco.Web.PublishedModels.Resumen.GetExtracto(this);

		///<summary>
		/// Miniatura
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.13.0")]
		[ImplementPropertyType("miniatura")]
		public virtual global::Umbraco.Core.Models.PublishedContent.IPublishedContent Miniatura => global::Umbraco.Web.PublishedModels.Resumen.GetMiniatura(this);

		///<summary>
		/// Descripcion
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.13.0")]
		[ImplementPropertyType("descripcion")]
		public virtual string Descripcion => global::Umbraco.Web.PublishedModels.SEO.GetDescripcion(this);

		///<summary>
		/// Titulo
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.13.0")]
		[ImplementPropertyType("titulo")]
		public virtual string Titulo => global::Umbraco.Web.PublishedModels.SEO.GetTitulo(this);
	}
}
