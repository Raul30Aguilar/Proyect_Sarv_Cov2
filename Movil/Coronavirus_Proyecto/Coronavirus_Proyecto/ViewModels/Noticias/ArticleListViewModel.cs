using Coronavirus_Proyecto.Models.News;
using Coronavirus_Proyecto.Views.NoticiaDetalle;
using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Model1 = Coronavirus_Proyecto.Models.News.Article;

namespace Coronavirus_Proyecto.ViewModels.Noticias
{
    /// <summary>
    /// ViewModel for article list page.
    /// </summary> 
    [Preserve(AllMembers = true)]
    public class ArticleListViewModel : BaseViewModel
    {
        #region Fields

        private ObservableCollection<Model1> featuredStories;

        private ObservableCollection<Model1> latestStories;

        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance for the <see cref="ArticleListViewModel" /> class.
        /// </summary>
        public ArticleListViewModel(INavigation _navigation)
        {

            Navigation = _navigation;
            Task.Run(async() => 
                {

                var endpoint = "https://newsapi.org/v2/top-headlines?country=co&category=health&apiKey=2ec1f56f5f334b8bb34ae654152a08d7";
                    var client = new HttpClient();
                    client.BaseAddress = new Uri(endpoint);
                    var result = await client.GetStringAsync(endpoint);
                    var lista = JsonConvert.DeserializeObject<ArticleList>(result);

                    LatestStories = new ObservableCollection<Article>(lista.articles);
                    featuredStories = new ObservableCollection<Article>(LatestStories.Take(3));

                })
                .Wait();

            //this.FeaturedStories = new ObservableCollection<Model1>
            //{
            //    new Model1
            //    {
            //        ImagePath = App.BaseImageUrl + "ArticleImage2.png",
            //        Name = "Learning to Reset",
            //        Author = "John Doe",
            //        Date = "Aug 2010",
            //        AverageReadingTime = "5 mins read"
            //    },
            //    new Model1
            //    {
            //        ImagePath = App.BaseImageUrl + "ArticleImage3.png",
            //        Name = "Holistic Approach to UI Design",
            //        Author = "John Doe",
            //        Date = "Apr 16",
            //        AverageReadingTime = "5 mins read"
            //    },
            //    new Model1
            //    {
            //        ImagePath = App.BaseImageUrl + "ArticleImage4.png",
            //        Name = "Guiding Your Flock to Success",
            //        Author = "John Doe",
            //        Date = "May 2012",
            //        AverageReadingTime = "5 mins read"
            //    },
            //    new Model1
            //    {
            //        ImagePath = App.BaseImageUrl + "ArticleImage5.png",
            //        Name = "Be a Nurturing, Fierce Team Leader",
            //        Author = "John Doe",
            //        Date = "Apr 16",
            //        AverageReadingTime = "5 mins read"
            //    },
            //    new Model1
            //    {
            //        ImagePath = App.BaseImageUrl + "ArticleImage6.png",
            //        Name = "Holistic Approach to UI Design",
            //        Author = "John Doe",
            //        Date = "Dec 2013",
            //        AverageReadingTime = "5 mins read"
            //    }
            //};

            //this.LatestStories = new ObservableCollection<Model1>
            //{
            //    new Model1
            //    {
            //        ImagePath = App.BaseImageUrl + "Article_image1.png",
            //        Name = "Learning to Reset",
            //        Author = "John Doe",
            //        Date = "Apr 16",
            //        AverageReadingTime = "5 mins read"
            //    },
            //    new Model1
            //    {
            //        ImagePath = App.BaseImageUrl + "Article_image2.png",
            //        Name = "Holistic Approach to UI Design",
            //        Author = "John Doe",
            //        Date = "May 26",
            //        AverageReadingTime = "5 mins read"
            //    },
            //    new Model1
            //    {
            //        ImagePath = App.BaseImageUrl + "Article_image3.png",
            //        Name = "Guiding Your Flock to Success",
            //        Author = "John Doe",
            //        Date = "Apr 10",
            //        AverageReadingTime = "5 mins read"
            //    },
            //    new Model1
            //    {
            //        ImagePath = App.BaseImageUrl + "Article_image4.png",
            //        Name = "Holistic Approach to UI Design",
            //        Author = "John Doe",
            //        Date = "Apr 16",
            //        AverageReadingTime = "5 mins read"
            //    },
            //};

            this.MenuCommand = new Command(this.MenuClicked);
            //this.BookmarkCommand = new Command(this.BookmarkButtonClicked);
            this.FeatureStoriesCommand = new Command(this.FeatureStoriesClicked);
            this.ItemSelectedCommand = new Command(this.ItemSelected);
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the property that has been bound with the rotator view, which displays the articles featured stories items.
        /// </summary>
        public ObservableCollection<Model1> FeaturedStories
        {
            get
            {
                return this.featuredStories;
            }

            set
            {
                if (this.featuredStories == value)
                {
                    return;
                }

                this.featuredStories = value;
                this.NotifyPropertyChanged();
            }
        }

        /// <summary>
        /// Gets or sets the property that has been bound with the list view, which displays the articles latest stories items.
        /// </summary>
        public ObservableCollection<Model1> LatestStories
        {
            get
            {
                return this.latestStories;
            }

            set
            {
                if (this.latestStories == value)
                {
                    return;
                }

                this.latestStories = value;
                this.NotifyPropertyChanged();
            }
        }

        public INavigation Navigation { get; set; }
        #endregion

        #region Command

        /// <summary>
        /// Gets or sets the command that will be executed when the menu button is clicked.
        /// </summary>
        public Command MenuCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that will be executed when the bookmark button is clicked.
        /// </summary>
        public Command BookmarkCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that will executed when the feature stories item is clicked.
        /// </summary>
        public Command FeatureStoriesCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that will be executed when an item is selected.
        /// </summary>
        public Command ItemSelectedCommand { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Invoked when the menu button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private void MenuClicked(object obj)
        {
            // Do something
        }

        /// <summary>
        /// Invoked when the bookmark button is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        //private void BookmarkButtonClicked(object obj)
        //{
        //    if (obj is Model1 article)
        //    {
        //        article.IsBookmarked = !article.IsBookmarked;
        //    }
        //}

        /// <summary>
        /// Invoked when the the feature stories item is clicked.
        /// </summary>
        /// <param name="obj">The object</param>
        private void FeatureStoriesClicked(object obj)
        {
            // Do something
        }

        /// <summary>
        /// Invoked when an item is selected.
        /// </summary>
        /// <param name="obj">The Object</param>
        private void ItemSelected(object obj)
        {
            var item =
                obj as Syncfusion.ListView.XForms.ItemTappedEventArgs;
            Navigation.PushAsync(new ArticleDetailPage(item.ItemData as Article));
        }

        #endregion
    }
}
