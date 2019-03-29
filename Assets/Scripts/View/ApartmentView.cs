using UnityEngine;

public class ApartmentView : View
{
	[SerializeField] private UnityEngine.UI.Text MetersText, FloorText, RoomsText;

	public string Meters { get { return MetersText.text; } set { MetersText.text = value; } }
	public string Rooms { get { return RoomsText.text; } set { RoomsText.text = value; } }
	public string Floor { get { return FloorText.text; } set { FloorText.text = value; } }
}