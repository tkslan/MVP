﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using UnityEngine;
using Presenter;
using Model;
using View;

public class PresentersController : MonoBehaviour
{
    private List<IPresenter> _presenters;
    public List<View.View> Views
    {
        get => _views;
    }
    private List<View.View> _views;
    // Start is called before the first frame update
    void Start()
    {
        _views = Resources.LoadAll<View.View>("Views").ToList();
                   
        PresenterBase.OnCreated += AddPresenter;
        PresenterBase.OnDisposed += RemovePresenter;
        // Open3dApartmentView(new Apartment() {Floor = 2, Meters = 123, Rooms = 2});
       // OpenGameStats();
       var aprtment = new Apartment() {Floor = 2, Meters = 123, Rooms = 2};
        var tp = new Presenter.Apartment.Default(aprtment);
        tp.OpenView();
        aprtment.Meters++;
        tp.UpdateView();
    }

    public View.View GetPoolView<T>()
    {
        return Views.Find(f => f is T);
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
        var presenter = new Presenter.GameStats.Default();
        presenter.OpenView(stats);
    }

    public void Open3dApartmentView(Apartment apartment)
    {
        var apartmentPresenter = new Presenter.Apartment.Extra3D();
        apartmentPresenter.OpenView(apartment);
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

    public T GetPresenter<T>() where T : class, IPresenter
    {
        if (_presenters == null)
            throw new NoNullAllowedException("There is no presenters at the moment");

        var requestedPresenter = _presenters.Find(f => f is T);

        return requestedPresenter as T;
    }
}