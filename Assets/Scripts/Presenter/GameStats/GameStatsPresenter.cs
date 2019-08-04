
using Presenter.Apartment;
using View.GameStats;

namespace Presenter.GameStats
{
    public class GameStatsPresenter: ViewPresenter<GameStatsView, Model.GameStats>
    {
        public override void UpdateView()
        {
            base.UpdateView();
            View.SetStats(Data);
        }

        public override void OnOpened()
        {
            
        }

        public void SetNewApartmentBalcony()
        {
            if (Controller.GetPresenter<ApartmentWithBalconyPresenter>() == null)
            {
                var balcony = new ApartmentWithBalconyPresenter();
                balcony.OpenView(Controller.transform, new Model.ApartmentBalcony()
                {
                    Balcony = true,
                    BalconyMeters = 10,
                    Floor = 2,
                    Meters = 55,
                    Rooms = 2
                });
            }
        }
    }
}