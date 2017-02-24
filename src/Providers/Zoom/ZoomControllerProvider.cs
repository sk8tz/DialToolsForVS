﻿using System.ComponentModel.Composition;
using System.IO;
using System.Reflection;
using Windows.UI.Input;

namespace DialToolsForVS
{
    [Export(typeof(IDialControllerProvider))]
    internal class ZoomControllerProvider : IDialControllerProvider
    {
        public const string Moniker = "Zoom";
        public IDialController TryCreateController(IDialControllerHost host)
        {
            string folder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string iconFilePath = Path.Combine(folder, "Providers\\Zoom\\icon.png");

            host.AddMenuItem(Moniker, iconFilePath);

            return new ZoomController();
        }
    }
}
