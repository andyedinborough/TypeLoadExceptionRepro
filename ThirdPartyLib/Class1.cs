using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Razor.Language;

namespace ThirdPartyLib
{
    public class Class1
    {
        public class CustomHelperResult : HelperResult
        {
            public CustomHelperResult(Func<TextWriter, Task> asyncAction) : base(asyncAction)
            {
            }
        }

        private class VirtualRazorProject : RazorProject
        {
            public override IEnumerable<RazorProjectItem> EnumerateItems(string basePath) => null;

            public override RazorProjectItem GetItem(string path) => null;
        }
    }
}
