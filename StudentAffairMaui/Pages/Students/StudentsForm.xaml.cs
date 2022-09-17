using StudentAffairMaui.ViewModels;

namespace StudentAffairMaui;

public partial class StudentsForm : ContentPage
{
	public StudentsForm(StudentsFormViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}