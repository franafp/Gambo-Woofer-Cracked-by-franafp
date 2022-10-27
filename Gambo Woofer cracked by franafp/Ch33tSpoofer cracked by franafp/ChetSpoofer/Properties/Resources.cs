using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ChetSpoofer.Properties
{
	// Token: 0x0200000A RID: 10
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000041 RID: 65 RVA: 0x000060CE File Offset: 0x000042CE
		internal Resources()
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000042 RID: 66 RVA: 0x000060D8 File Offset: 0x000042D8
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("ChetSpoofer.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00006120 File Offset: 0x00004320
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00006137 File Offset: 0x00004337
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00006140 File Offset: 0x00004340
		internal static Bitmap ca12nvas
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("ca12nvas", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00006170 File Offset: 0x00004370
		internal static Bitmap can132131vas
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("can132131vas", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000047 RID: 71 RVA: 0x000061A0 File Offset: 0x000043A0
		internal static Bitmap canv13123as
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("canv13123as", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000048 RID: 72 RVA: 0x000061D0 File Offset: 0x000043D0
		internal static Bitmap canv2312313as
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("canv2312313as", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00006200 File Offset: 0x00004400
		internal static Bitmap canva11s
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("canva11s", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00006230 File Offset: 0x00004430
		internal static Bitmap canva1212s
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("canva1212s", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00006260 File Offset: 0x00004460
		internal static Bitmap logo
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("logo", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00006290 File Offset: 0x00004490
		internal static Bitmap logo_modified
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("logo-modified", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x0400003D RID: 61
		private static ResourceManager resourceMan;

		// Token: 0x0400003E RID: 62
		private static CultureInfo resourceCulture;
	}
}
