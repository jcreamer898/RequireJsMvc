using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace RequireJsMvc.Helpers
{
    public static class HtmlHelperExtensions
    {
        /// <summary>
        /// An Html helper for Require.js
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="common">Location of the common js file.</param>
        /// <param name="module">Location of the main.js file.</param>
        /// <returns></returns>
        public static MvcHtmlString RequireJs(this HtmlHelper helper, string common, string module)
        {
            var require = new StringBuilder();
#if (DEBUG)
            string jsLocation = "Scripts/";
#else
            string jsLocation = "Scripts-build/";
#endif

            require.AppendLine("<script>");
            require.AppendLine(string.Format(@"require( [ ""/{0}{1}.js"" ], function() {{", jsLocation, common));
            require.AppendLine(string.Format("    require( [ \"{0}\"] );", module));
            require.AppendLine("});");
            require.AppendLine("</script>");

            return new MvcHtmlString(require.ToString());
        }
    }
}