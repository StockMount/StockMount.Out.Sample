using System.Web;
using System.Web.Optimization;

namespace StockMount.Out.Sample
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

             
            bundles.Add(new ScriptBundle("~/bundles/Bootstrap/js").Include(
                        "~/Scripts/bootstrap.js" ));


             bundles.Add(new ScriptBundle("~/js/JsonFormater").Include(
                        "~/Scripts/JsonFormater/bundle.js"));

            /*****Pages Js***/
            bundles.Add(new ScriptBundle("~/js/DoLogin").Include(
                        "~/Scripts/pages/doLogin.js"));

            bundles.Add(new ScriptBundle("~/js/GetStores").Include(
                        "~/Scripts/pages/GetStores.js"));

            bundles.Add(new ScriptBundle("~/js/GetSales").Include(
                        "~/Scripts/pages/GetSales.js"));

            bundles.Add(new ScriptBundle("~/js/GetMessages").Include(
                        "~/Scripts/pages/GetMessages.js"));

            bundles.Add(new ScriptBundle("~/js/SendUserMessage").Include(
                        "~/Scripts/pages/SendUserMessage.js"));

            bundles.Add(new ScriptBundle("~/js/ConfirmOrRejectOrderItem").Include(
                        "~/Scripts/pages/ConfirmOrRejectOrderItem.js"));

            bundles.Add(new ScriptBundle("~/js/GetAllUserMessage").Include(
                        "~/Scripts/pages/GetAllUserMessage.js"));
            bundles.Add(new ScriptBundle("~/js/GetIntegrationShipmentCompanies").Include(
                        "~/Scripts/pages/GetIntegrationShipmentCompanies.js"));

            bundles.Add(new ScriptBundle("~/js/SetOrderShipmentInformation").Include(
                        "~/Scripts/pages/SetOrderShipmentInformation.js"));

            bundles.Add(new ScriptBundle("~/js/SetMessageRead").Include(
                        "~/Scripts/pages/SetMessageRead.js"));
            


            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));


            bundles.Add(new StyleBundle("~/Content/bootstrap").Include(
                        
                        "~/Content/bootstrap.css",
                        "~/Content/shop-item.css",
                        "~/Content/Custom.css",
                         "~/Content/JsonFormater/style.css" 

                        )); 


             


        }
    }
}