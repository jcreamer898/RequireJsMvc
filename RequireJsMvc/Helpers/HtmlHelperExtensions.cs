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

            string jsLocation = ConfigurationManager.AppSettings["JsLocation"];

            require.AppendLine("require( [ \"" + jsLocation + common + "\" ], function() {");
            require.AppendLine("    require( [ \"" + module + "\"] );");
            require.AppendLine("});");

            return new MvcHtmlString(require.ToString());
        }
    }
}