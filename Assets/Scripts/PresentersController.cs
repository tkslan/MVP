using System;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using Presenter;
using Model;

public class PresentersController : MonoBehaviour
{
    private List<IPresenter> _presenters;

    // Start is called before the first frame update
    void Start()
    {
        Presenter.Presenter.OnPresenterCreated += AddPresenter;
        Presenter.Presenter.OnPresenterDispose += RemovePresenter;
        // Open3dApartmentView(new Apartment() {Floor = 2, Meters = 123, Rooms = 2});
        OpenGameStats();
    }

    void OpenGameStats()
    {
        var stats = new GameStats()
        {
            BestLevelTimes = new List<uint>() {10, 35, 66, 88, 99, 230},
            Level = 1,
            World = 1,
            Score = 1001
        };
        var presenter = new Presenter.GameStats.GameStatsPresenter();
        presenter.OpenView(transform, stats);
    }

    public void Open3dApartmentView(Apartment apartment)
    {
        var apartmentPresenter = new Presenter.Apartment.Apartment3dPresenter();
        apartmentPresenter.OpenView(transform, apartment);
    }

    private void AddPresenter(IPresenter presenter)
    {
        _presenters = _presenters ?? new List<IPresenter>();
        _presenters.Add(presenter);
        presenter.SetController(this);
    }

    private void RemovePresenter(IPresenter presenter)
    {
        var removed = _presenters.Remove(presenter);
    }

    public T GetPresenter<T>() where T : Presenter.Presenter
    {
        if (_presenters == null)
            throw new NoNullAllowedException("There is no presenters at the moment");

        var requestedPresenter = _presenters.Find(f => f is T);

        return requestedPresenter as T;
    }
}