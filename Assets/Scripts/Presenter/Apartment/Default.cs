using View.Apartment;

namespace Presenter.Apartment
{
    public class Default : Presenter<ApartmentView, Model.Apartment>
    {
        public override void UpdateView()
        {
            base.UpdateView();
            View.Floor = $"Floor : {Data.Floor}";
            View.Rooms = $"Rooms : {Data.Rooms}";
            View.Meters = $"Meters: {Data.Meters}";
        }

        public Default(Model.Apartment data)
        {
            SetData(data);
        }

        public Default()
        {
            
        }
        protected override void OnOpened()
        {
            
        }
    }
}