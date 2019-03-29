using UnityEngine;

public class ApartmentView : View
{
    [SerializeField] private UnityEngine.UI.Text MetersText, FloorText, RoomsText;

    public void SetMeters(int meters)
    {
        MetersText.text = meters.ToString();
    }
    public void SetRooms(int rooms)
    {
        RoomsText.text = rooms.ToString();
    }
    public void SetFloor(int floor)
    {
        FloorText.text = floor.ToString();
    }
}