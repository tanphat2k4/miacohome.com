using  System;
using  System.Collections.Generic;
using  System.Linq.Expressions;
using  System.Web;
using  Umbraco.Core.Models;
using  Umbraco.Core.Models.PublishedContent;
using  Umbraco.Web;
using  Umbraco.ModelsBuilder;
using  Umbraco.ModelsBuilder.Umbraco;
[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "56c40fce5a7fbcf3")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.1")]


// FILE: models.generated.cs

//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------















namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Contacts</summary>
	[PublishedContentModel("cONTACTS")]
	public partial class COntacts : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "cONTACTS";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public COntacts(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<COntacts, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>AboutUS</summary>
	[PublishedContentModel("aBOUTUS")]
	public partial class ABoutus : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "aBOUTUS";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ABoutus(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ABoutus, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// aboutUs item
		///</summary>
		[ImplementPropertyType("aboutUsItem")]
		public IHtmlString AboutUsItem
		{
			get { return this.GetPropertyValue<IHtmlString>("aboutUsItem"); }
		}

		///<summary>
		/// Hide in navigation
		///</summary>
		[ImplementPropertyType("hideInNavigation")]
		public bool HideInNavigation
		{
			get { return this.GetPropertyValue<bool>("hideInNavigation"); }
		}

		///<summary>
		/// Images
		///</summary>
		[ImplementPropertyType("images")]
		public IPublishedContent Images
		{
			get { return this.GetPropertyValue<IPublishedContent>("images"); }
		}
	}

	/// <summary>BLog</summary>
	[PublishedContentModel("bLOG")]
	public partial class BLog : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "bLOG";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BLog(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BLog, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>Blog Item</summary>
	[PublishedContentModel("blogItem")]
	public partial class BlogItem : BLog
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "blogItem";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public BlogItem(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BlogItem, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Blog hot
		///</summary>
		[ImplementPropertyType("blogHot")]
		public bool BlogHot
		{
			get { return this.GetPropertyValue<bool>("blogHot"); }
		}

		///<summary>
		/// Description
		///</summary>
		[ImplementPropertyType("description")]
		public IHtmlString Description
		{
			get { return this.GetPropertyValue<IHtmlString>("description"); }
		}

		///<summary>
		/// Subject matter
		///</summary>
		[ImplementPropertyType("subjectMatter")]
		public string SubjectMatter
		{
			get { return this.GetPropertyValue<string>("subjectMatter"); }
		}

		///<summary>
		/// Thumbnail
		///</summary>
		[ImplementPropertyType("thumbnail")]
		public IPublishedContent Thumbnail
		{
			get { return this.GetPropertyValue<IPublishedContent>("thumbnail"); }
		}
	}

	/// <summary>Home</summary>
	[PublishedContentModel("home")]
	public partial class Home : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "home";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Banner
		///</summary>
		[ImplementPropertyType("banner")]
		public IEnumerable<IPublishedContent> Banner
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("banner"); }
		}

		///<summary>
		/// Discover
		///</summary>
		[ImplementPropertyType("discover")]
		public IEnumerable<IPublishedContent> Discover
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("discover"); }
		}

		///<summary>
		/// Packages
		///</summary>
		[ImplementPropertyType("packages")]
		public IEnumerable<IPublishedContent> Packages
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("packages"); }
		}

		///<summary>
		/// Process
		///</summary>
		[ImplementPropertyType("process")]
		public IEnumerable<IPublishedContent> Process
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("process"); }
		}

		///<summary>
		/// Solution
		///</summary>
		[ImplementPropertyType("solution")]
		public IEnumerable<IPublishedContent> Solution
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("solution"); }
		}
	}

	/// <summary>Improve packet form</summary>
	[PublishedContentModel("improvePacketForm")]
	public partial class ImprovePacketForm : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "improvePacketForm";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ImprovePacketForm(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ImprovePacketForm, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Hide in navigation
		///</summary>
		[ImplementPropertyType("hideInNavigation")]
		public bool HideInNavigation
		{
			get { return this.GetPropertyValue<bool>("hideInNavigation"); }
		}
	}

	/// <summary>Misc</summary>
	[PublishedContentModel("misc")]
	public partial class Misc : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "misc";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Misc(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Misc, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Hide in navigation
		///</summary>
		[ImplementPropertyType("hideInNavigation")]
		public bool HideInNavigation
		{
			get { return this.GetPropertyValue<bool>("hideInNavigation"); }
		}
	}

	/// <summary>Banner</summary>
	[PublishedContentModel("banner")]
	public partial class Banner : Misc
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "banner";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Banner(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Banner, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Gallery
		///</summary>
		[ImplementPropertyType("gallery")]
		public IEnumerable<IPublishedContent> Gallery
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("gallery"); }
		}
	}

	/// <summary>Customer review</summary>
	[PublishedContentModel("customerReview")]
	public partial class CustomerReview : Misc
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "customerReview";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public CustomerReview(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<CustomerReview, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Stories
		///</summary>
		[ImplementPropertyType("stories")]
		public IHtmlString Stories
		{
			get { return this.GetPropertyValue<IHtmlString>("stories"); }
		}
	}

	/// <summary>Discover what is possible</summary>
	[PublishedContentModel("discoverWhatIsPossible")]
	public partial class DiscoverWhatIsPossible : Misc
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "discoverWhatIsPossible";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public DiscoverWhatIsPossible(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<DiscoverWhatIsPossible, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// possible
		///</summary>
		[ImplementPropertyType("possible")]
		public IEnumerable<IPublishedContent> Possible
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("possible"); }
		}
	}

	/// <summary>Potential_Customer</summary>
	[PublishedContentModel("potential_Customer")]
	public partial class Potential_Customer : Misc
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "potential_Customer";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Potential_Customer(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Potential_Customer, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Email_customer
		///</summary>
		[ImplementPropertyType("email_customer")]
		public string Email_customer
		{
			get { return this.GetPropertyValue<string>("email_customer"); }
		}

		///<summary>
		/// Message
		///</summary>
		[ImplementPropertyType("message")]
		public string Message
		{
			get { return this.GetPropertyValue<string>("message"); }
		}

		///<summary>
		/// Name_customer
		///</summary>
		[ImplementPropertyType("name_customer")]
		public string Name_customer
		{
			get { return this.GetPropertyValue<string>("name_customer"); }
		}

		///<summary>
		/// Subject
		///</summary>
		[ImplementPropertyType("subject")]
		public string Subject
		{
			get { return this.GetPropertyValue<string>("subject"); }
		}
	}

	/// <summary>Step process</summary>
	[PublishedContentModel("stepProcess")]
	public partial class StepProcess : Misc
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "stepProcess";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public StepProcess(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<StepProcess, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Step
		///</summary>
		[ImplementPropertyType("step")]
		public string Step
		{
			get { return this.GetPropertyValue<string>("step"); }
		}
	}

	/// <summary>Packages</summary>
	[PublishedContentModel("packages")]
	public partial class Packages : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "packages";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Packages(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Packages, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Hide in navigation
		///</summary>
		[ImplementPropertyType("hideInNavigation")]
		public bool HideInNavigation
		{
			get { return this.GetPropertyValue<bool>("hideInNavigation"); }
		}
	}

	/// <summary>Process</summary>
	[PublishedContentModel("process")]
	public partial class Process : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "process";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Process(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Process, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Hide in navigation
		///</summary>
		[ImplementPropertyType("hideInNavigation")]
		public bool HideInNavigation
		{
			get { return this.GetPropertyValue<bool>("hideInNavigation"); }
		}

		///<summary>
		/// steps01
		///</summary>
		[ImplementPropertyType("steps01")]
		public IPublishedContent Steps01
		{
			get { return this.GetPropertyValue<IPublishedContent>("steps01"); }
		}

		///<summary>
		/// steps02
		///</summary>
		[ImplementPropertyType("steps02")]
		public IPublishedContent Steps02
		{
			get { return this.GetPropertyValue<IPublishedContent>("steps02"); }
		}

		///<summary>
		/// steps03
		///</summary>
		[ImplementPropertyType("steps03")]
		public IPublishedContent Steps03
		{
			get { return this.GetPropertyValue<IPublishedContent>("steps03"); }
		}

		///<summary>
		/// steps04
		///</summary>
		[ImplementPropertyType("steps04")]
		public IPublishedContent Steps04
		{
			get { return this.GetPropertyValue<IPublishedContent>("steps04"); }
		}
	}

	/// <summary>Portfolio</summary>
	[PublishedContentModel("portfolio")]
	public partial class Portfolio : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "portfolio";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Portfolio(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Portfolio, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Hide in navigation
		///</summary>
		[ImplementPropertyType("hideInNavigation")]
		public bool HideInNavigation
		{
			get { return this.GetPropertyValue<bool>("hideInNavigation"); }
		}
	}

	/// <summary>Portfolio_item</summary>
	[PublishedContentModel("portfolio_item")]
	public partial class Portfolio_item : Portfolio
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "portfolio_item";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Portfolio_item(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Portfolio_item, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// choose
		///</summary>
		[ImplementPropertyType("choose")]
		public bool Choose
		{
			get { return this.GetPropertyValue<bool>("choose"); }
		}

		///<summary>
		/// images
		///</summary>
		[ImplementPropertyType("images")]
		public IEnumerable<IPublishedContent> Images
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("images"); }
		}

		///<summary>
		/// Thumbnail
		///</summary>
		[ImplementPropertyType("thumbnail")]
		public IPublishedContent Thumbnail
		{
			get { return this.GetPropertyValue<IPublishedContent>("thumbnail"); }
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public string UmbracoFile
		{
			get { return this.GetPropertyValue<string>("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}



// EOF
