using System;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Serialization;

namespace MediaBrowser.Channels.Adult.SpankBang
{
	class Plugin : BasePlugin<PluginConfiguration>
	{
		public override Guid Id => new Guid("7C6DA777-9FB3-45D0-86FD-C171DE6435CB");
		public override string Name => "SpankBang";

		public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer) :
			base(applicationPaths, xmlSerializer) { }
	}
}
