using System.Web;
using System.Web.Optimization;

namespace fancy_backend
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {          
          

            bundles.Add(new StyleBundle("~/scss").Include(
                      "~/scss/_banner.scss",
                      "~/scss/_blog.scss",
                      "~/scss/_button.scss",
                      "~/scss/_contact.scss",
                      "~/scss/_feature.scss",
                      "~/scss/_footer.scss",
                      "~/scss/_header.scss",
                      "~/scss/_predefin.scss",
                      "~/scss/_service.scss",
                      "~/scss/_slider.scss",
                      "~/scss/_testimonials.scss",
                      "~/scss/_variables.scss",
                      "~/scss/style.scss"));


         
        }
    }
}
