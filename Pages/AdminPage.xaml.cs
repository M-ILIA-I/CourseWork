using CourseWork.Services;

namespace CourseWork.Pages;

public partial class AdminPage : ContentPage
{
	FindTourService ft;
	AddTourService at;
	public AdminPage(AddTourService At, FindTourService Ft)
	{
		InitializeComponent();
		ft = Ft;
		at = At;
	}

    private async void Add(object sender, EventArgs e)
	{ 
		Tour tour = new Tour ();
		var a = ft.GetToursCount();
		tour.Id = a;
		tour.departureDate = DD.Text;
		tour.arrivingDate = AD.Text;
		tour.peopleQuantity = int.Parse(PQ.Text);
		tour.departureCountry = DC.Text;
		tour.arrivingCountry = AC.Text;
		tour.transport = T.Text;
		tour.price = P.Text;
		at.AddTour(tour);
		await Shell.Current.GoToAsync(nameof(UserPage));
    }
}