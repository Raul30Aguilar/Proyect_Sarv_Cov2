using Coronavirus_Proyecto.Models.News;
using Coronavirus_Proyecto.ViewModels.NoticiaDetalle;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace Coronavirus_Proyecto.Views.NoticiaDetalle
{
    /// <summary>
    /// Article detail page.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ArticleDetailPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Coronavirus_Proyecto.Views.NoticiaDetalle.ArticleDetailPage"/> class.
        /// </summary>
        public ArticleDetailPage(Article article)
        {
            InitializeComponent();
            BindingContext = new ArticleDetailPageViewModel(article);
        }
    }
}