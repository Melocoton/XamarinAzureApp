using Xamarin.Forms;

namespace XamarinAzureApp.View
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		    BindingContext = new ViewModel.MainViewModel();
		    //cargarTablaAsync();

		}

        //private async void cargarTablaAsync()
        //{
        //    String azureEndPoint = "https://melocotonnode.azurewebsites.net";
        //    MobileServiceClient client = new MobileServiceClient(azureEndPoint);

        //    IMobileServiceTable<Ciudades> table = client.GetTable<Ciudades>();
        //    List<Ciudades> items = await table.ToListAsync();

        //}
    }
}
