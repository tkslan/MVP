using System;
using System.Linq;
using UnityEngine;
using View;

namespace Presenter
{
    public abstract class Presenter<T, U> : PresenterBase where T : class, View.IView
    {
        public Action<U> OnViewUpdate = null;
        public new U Data => (U) base.Data;
        protected new T View => (T) base.View;

        public override void UpdateView()
        {
            OnViewUpdate?.Invoke(Data);
        }
        protected void SetData(U data)
        {
            base.Data = data;
        }
        
        private T LoadView(Transform parentTransform)
        {
            var loadedView = Controller.GetPoolView<T>();
            var view = GameObject.Instantiate(loadedView, parentTransform);
            view.GetGameObject.name = loadedView.name;
            return view as T;
        }

        public T OpenView(U data)
        {
            var view= OpenView(null,false);
            SetView(view, data);
            ShowView();
            return view;
        }
        public T OpenView(Transform parentTransform = null, bool autoShow = true)
        { 
            var view = View ?? LoadView(parentTransform == null ? Controller.transform : parentTransform);
            SetView(view, Data);
            if (autoShow) 
                this.ShowView();
            return view;
        }
    }
}