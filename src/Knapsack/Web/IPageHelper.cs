using System;
using System.Collections.Generic;
using System.Web;

namespace Knapsack.Web
{
    public interface IPageHelper
    {
        void ReferenceScript(string scriptPathOrUrl);
        void ReferenceExternalScript(string externalScriptUrl, string location);
        IHtmlString RenderScripts(string location);

        IHtmlString RenderScriptUrl(string modulePath, Func<IEnumerable<string>, string> formatAction);

        void ReferenceStylesheet(string stylesheetPath);
        IHtmlString RenderStylesheetLinks();

        string ReplacePlaceholders(string line);
    }
}
