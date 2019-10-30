
using Presenter.Apartment;
using View.GameStats;

namespace Presenter.GameStats
{
    public class Default: Presenter<GameStatsView, Model.GameStats>
    {
        public void SetNewApartmentBalcony()
        {
            if (Controller.GetPresenter<Balcony>() == null)
            {
                var balcony = new Balcony();
                balcony.OpenView(new Model.ApartmentBalcony()
                {
                    Balcony = true,
                    BalconyMeters = 10,
                    Floor = 2,
                    Meters = 55,
                    Rooms = 2
                });
            }
        }

        protected override void OnOpened()
        {
            View.SetStats(Data);
        }
    }
}