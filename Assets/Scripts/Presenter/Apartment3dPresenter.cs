
public class Apartment3dPresenter : ApartmentPresenter
{
	public override void UpdateView()
	{
		base.UpdateView();
		ApartmentView.Meters = $"Meters in 3D: {(Apartment.Meters * 1.2f).ToString()}";
	}
	public void DebugInfo()
	{
		UnityEngine.Debug.Log(this + "" + Apartment.Rooms);
	}
	public void ShowBasePanel()
	{
		Controller.OpenView<ApartmentView, ApartmentPresenter>(Data).ShowView();
	}
}
