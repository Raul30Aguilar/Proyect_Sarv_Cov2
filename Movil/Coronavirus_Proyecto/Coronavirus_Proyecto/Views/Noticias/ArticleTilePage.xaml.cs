using Coronavirus_Proyecto.ViewModels.Noticias;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Coronavirus_Proyecto.Views.Noticias
{
    /// <summary>
    /// Page to show the article tile
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ArticleTilePage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArticleTilePage" /> class.
        /// </summary>
        public ArticleTilePage()
        {
            InitializeComponent();
            BindingContext = new ArticleListViewModel(Navigation);
        }

        /// <summary>
        /// Invoked when view size is changed.
        /// </summary>
        /// <param name="width">The Width</param>
        /// <param name="height">The Height</param>
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            if (width > height)
            {
                GridLayout.SpanCount = Device.Idiom == TargetIdiom.Phone ? 3 : 4;
            }
            else
            {
                GridLayout.SpanCount =
                    Device.Idiom == TargetIdiom.Phone ? 2 : Device.Idiom == TargetIdiom.Tablet ? 3 : 4;
            }
        }
    }
}