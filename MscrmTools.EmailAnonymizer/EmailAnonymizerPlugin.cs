using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Reflection;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace MscrmTools.EmailAnonymizer
{
    // Do not forget to update version number and author (company attribute) in AssemblyInfo.cs class
    // To generate Base64 string for Images below, you can use https://www.base64-image.de/
    [Export(typeof(IXrmToolBoxPlugin)),
        ExportMetadata("Name", "Email anonymizer"),
        ExportMetadata("Description", "Allows to update email attributes with fake email addresses"),
        // Please specify the base64 content of a 32x32 pixels image
        ExportMetadata("SmallImageBase64", "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAIAAAD8GO2jAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAAAYdEVYdFNvZnR3YXJlAHBhaW50Lm5ldCA0LjEuNv1OCegAAALiSURBVEhL5ZXbS2pREMbPn2ZlJWVFFEkiSJjQS9aDD2nYQw/lhQ5kRIUIRSml0M1ACILAJ7EeKiIJKRRM8UKkXb3g+WDWkaNtt3sHQXB+D7KdtWa+2bNmzf4l+WZ+hsDw8LDJZFpdXXW73evr63a7XafT9fX1sWVemgio1epQKPT+/l6ppVwu5/N5l8vV3t7OtjagoUBLS8vc3Nzz8zML2YD7+/uRkRHmw0VDAYPB8PHxQVGQbzKZdDgcExMT8/Pz5+fnhUKBlgCWBgYGmNsnuAU6Ozvj8Tj5I/rm5iaMCoVCqVS2trYODg5OTk6+vLzQBhAIBPDG5FsHt4DFYmGulcrBwQEKvb+///r6Go1GT09P0+n0+Pj49PR0NpulPUhCo9Ew51q4BcLhMHmiSl1dXQsLC5FIpLe3F0t+v79YLEISr/Lw8IBn2rm2tka+dXAIIFAulyM3nCEsKJder6dVs9l8fX1Nz3d3d09PT7Rzd3eXjHVwCMjl8pWVFZ/Ph7gnJyc9PT0oN6UPdnZ2PB4PHsbGxq6urh4fH0lgb2+PNtTBXSJicXFxe3u7o6MDL9Tf3w8LLhciGo1GmUx2c3ODPKpXZGlpibzq4BNAjqgGao26ozWtVmswGEREJIu/uGXHx8cUHV2L287cauETQOchzZmZme7u7uXl5Y2NDZQLzeP1ejEqnE5nqVQigcPDQ+bzCT4BMDo6GovFUIp/r1JbW9vW1lY1+u3tLSrG1j7RRACg+kdHR5lMhhoJDYqTR+NT9FQqNTQ0RDs5aS5AIGupVIpfnAeFBmhT/uhAqACBic1iVyqXl5fV3uVBhIBKpcK0oOgXFxeYV2yBFxECmKYU/e3tDYOPWZshQuDs7IwEcMjMJAARAolEggRsNhszCUCEQPUAqoNPCCIE0KAETpuZBCBC4Gv8GAF8h3HLiNnZWWYVgFABrVZLJwwwtJlVAP+PAOba779MTU0xqwCECnwRieQPZnJ+QpoxACgAAAAASUVORK5CYII="),
        // Please specify the base64 content of a 80x80 pixels image
        ExportMetadata("BigImageBase64", "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"),
        ExportMetadata("BackgroundColor", "#FF404040"),
        ExportMetadata("PrimaryFontColor", "White"),
        ExportMetadata("SecondaryFontColor", "White")]
    public class EmailAnonymizerPlugin : PluginBase
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public EmailAnonymizerPlugin()
        {
            // If you have external assemblies that you need to load, uncomment the following to
            // hook into the event that will fire when an Assembly fails to resolve
            // AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(AssemblyResolveEventHandler);
        }

        public override IXrmToolBoxPluginControl GetControl()
        {
            return new EmailAnonymizerControl();
        }

        /// <summary>
        /// Event fired by CLR when an assembly reference fails to load
        /// Assumes that related assemblies will be loaded from a subfolder named the same as the Plugin
        /// For example, a folder named Sample.XrmToolBox.MyPlugin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        private Assembly AssemblyResolveEventHandler(object sender, ResolveEventArgs args)
        {
            Assembly loadAssembly = null;
            Assembly currAssembly = Assembly.GetExecutingAssembly();

            // base name of the assembly that failed to resolve
            var argName = args.Name.Substring(0, args.Name.IndexOf(","));

            // check to see if the failing assembly is one that we reference.
            List<AssemblyName> refAssemblies = currAssembly.GetReferencedAssemblies().ToList();
            var refAssembly = refAssemblies.Where(a => a.Name == argName).FirstOrDefault();

            // if the current unresolved assembly is referenced by our plugin, attempt to load
            if (refAssembly != null)
            {
                // load from the path to this plugin assembly, not host executable
                string dir = Path.GetDirectoryName(currAssembly.Location).ToLower();
                string folder = Path.GetFileNameWithoutExtension(currAssembly.Location);
                dir = Path.Combine(dir, folder);

                var assmbPath = Path.Combine(dir, $"{argName}.dll");

                if (File.Exists(assmbPath))
                {
                    loadAssembly = Assembly.LoadFrom(assmbPath);
                }
                else
                {
                    throw new FileNotFoundException($"Unable to locate dependency: {assmbPath}");
                }
            }

            return loadAssembly;
        }
    }
}