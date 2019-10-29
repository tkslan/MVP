using View.Apartment;

namespace Presenter.Apartment
{
    public class Default : ViewPresenter<ApartmentView, Model.Apartment>
    {
        public override void UpdateView()
        {
            base.UpdateView();
            View.Floor = $"Floor : {Data.Floor}";
            View.Rooms = $"Rooms : {Data.Rooms}";
            View.Meters = $"Meters: {Data.Meters}";
        }

        public override void OnOpened()
        {
            
        }
    }
}