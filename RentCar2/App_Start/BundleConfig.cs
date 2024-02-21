using System.Web;
using System.Web.Optimization;

namespace RentCar2
{
	public class BundleConfig
	{
		// For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(BundleCollection bundles)
		{
			
			bundles.Add(new StyleBundle("~/bundles/bootstrap").Include(
				"~/Vendor/css/bootstrap.min.css"));
			bundles.Add(new StyleBundle("~/bundles/style").Include(
				"~/Vendor/css/style.css"));
			bundles.Add(new StyleBundle("~/bundles/jquery.fancybox").Include(
				"~/Vendor/css/jquery.fancybox.min.css"));
			bundles.Add(new StyleBundle("~/bundles/bootstrap-datepicker").Include(
				"~/Vendor/css/bootstrap-datepicker.css"));
			bundles.Add(new StyleBundle("~/bundles/owl.carousel").Include(
				"~/Vendor/css/owl.carousel.min.css"));
			bundles.Add(new StyleBundle("~/bundles/owl.theme.default.min").Include(
				"~/Vendor/css/owl.theme.default.min.css"));
			bundles.Add(new StyleBundle("~/bundles/flaticon").Include(
				"~/Vendor/fonts/flaticon/font/flaticon.css"));
			bundles.Add(new StyleBundle("~/bundles.aos").Include(
				"~/Vendor/css/aos.css"));
			bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
				"~/Vendor/js/jquery-3.3.1.min.js"));
			bundles.Add(new ScriptBundle("~/bundles/popper.min").Include(
				"~/Vendor/js/popper.min"));
			bundles.Add(new ScriptBundle("~/bundles/bootstrap.min").Include(
				"~/Vendor/js/bootstrap.min.js"));
			bundles.Add(new ScriptBundle("~/bundles/owl.carousel.min").Include(
				"~/Vendor/js/owl.carousel.min.js"));
			bundles.Add(new ScriptBundle("~/bundles/jquery.sticky").Include(
				"~/Vendor/js/jquery.sticky.js"));
			bundles.Add(new ScriptBundle("~/bundles/jquery.waypoints.min").Include(
				"~/Vendor/js/jquery.waypoints.min.js"));
			bundles.Add(new ScriptBundle("~/bundles/jquery.animateNumber.min").Include(
				"~/Vendor/js/jquery.animateNumber.min.js"));
			bundles.Add(new ScriptBundle("~/bundles/jquery.fancybox.min").Include(
				"~/Vendor/js/jquery.fancybox.min.js"));
			bundles.Add(new ScriptBundle("~/bundles/jquery.easing.1.3").Include(
				"~/Vendor/js/jquery.easing.1.3.js"));
			bundles.Add(new ScriptBundle("~/bundles/bootstrap-datepicker.min").Include(
				"~/Vendor/js/bootstrap-datepicker.min.js"));
			bundles.Add(new ScriptBundle("~/bundles/aos").Include(
				"~/Vendor/js/aos.js"));
		}
	}
}
