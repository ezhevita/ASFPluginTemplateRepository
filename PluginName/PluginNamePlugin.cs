using System;
using System.Composition;
using System.Linq;
using System.Reflection;
using ArchiSteamFarm.Core;
using ArchiSteamFarm.Plugins.Interfaces;
using JetBrains.Annotations;

namespace PluginName {
	[Export(typeof(IPlugin))]
	[UsedImplicitly]
	public class PluginNamePlugin : IPlugin {
		public void OnLoaded() {
			ASF.ArchiLogger.LogGenericInfo(Name + " by ezhevita | Support & source code: https://github.com/ezhevita/" + Name);
		}

		public string Name => nameof(PluginName);
		public Version Version => Assembly.GetExecutingAssembly().GetName().Version ?? throw new InvalidOperationException();

	}
}
