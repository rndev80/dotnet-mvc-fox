﻿using System.Web;
using System.Web.Optimization;

namespace FoxLearnDotNetMVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/login/css").Include(
                "~/bootstrap/dist/css/bootstrap.min.css",
                "~/plugins/font-awesome/css/font-awesome.min.css",
                "~/plugins/Ionicons/css/ionicons.min.css",
                "~/dist/css/AdminLTE.min.css",
                "~/plugins/iCheck/square/blue.css"));

            bundles.Add(new ScriptBundle("~/login/js").Include(
                "~/plugins/jquery/dist/jquery.min.js",
                "~/bootstrap/dist/js/bootstrap.min.js",
                "~/plugins/iCheck/icheck.min.js"));
        }
    }
}
