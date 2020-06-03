using System;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Coronavirus_Proyecto.Class;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using Model1 = Coronavirus_Proyecto.Class.Class1;
namespace Coronavirus_Proyecto.ViewModels.Forms
{
    /// <summary>
    /// ViewModel for Business Registration Form page 
    /// </summary> 
 
    [Preserve(AllMembers = true)]
    public class BusinessRegistrationFormViewModel : BaseViewModel
    {
        #region Constructor
        private ObservableCollection<Model1> latestStories;
        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessRegistrationFormViewModel" /> class
        /// </summary>
        public BusinessRegistrationFormViewModel()
        {
            Task.Run(async () =>
            {
                var endpoint = "http://env-5757416.enscaled.sg/proyecto/covid/departamentos";
                var client = new HttpClient();
                client.BaseAddress = new Uri(endpoint);
                var result = await client.GetStringAsync(endpoint);
                var lista = JsonConvert.DeserializeObject<DepartamentoList>(result);

                LatestStories = new ObservableCollection<Class1>(lista.Property1);


            }).Wait();
             

            this.SubmitCommand = new Command(this.SubmitClicked);
        }
        #endregion
        
        #region Properties

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the Full Name from user.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the Business Name from user.
        /// </summary>
        public string BusinessName { get; set; }

        /// <summary>
        /// Gets or sets the property that bounds with a ComboBox that gets the Business from user.
        /// </summary>
        public string Business { get; set; }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the Email ID from user.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the Phone Number from user.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the Street Address from user.
        /// </summary>
        public string StreetAddress { get; set; }

        /// <summary>
        /// Gets or sets the property that bounds with an entry that gets the City from user.
        /// </summary>
        public string City { get; set; }

        #endregion 

        #region Comments

        /// <summary>
        /// Gets or sets the command is executed when the Submit button is clicked.
        /// </summary>
        public Command SubmitCommand { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Invoked when the Submit button clicked
        /// </summary>
        /// <param name="obj">The object</param>
        private void SubmitClicked(Object obj)
        {

        }

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

        #endregion
    }
}