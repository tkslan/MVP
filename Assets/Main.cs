using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        var view = GetComponentInChildren<ApartmentView>();
        var apartmentPresenter = new ApartmentPresenter(new Apartment() { Floor = 6, Rooms = 1, Meters = 76 }, view);
        apartmentPresenter.ShowView();
    }
}
