using System;
using System.Linq;
using UnityEngine;

namespace Presenter
{
    public abstract class ViewPresenter<T, U> : Presenter where T : View.IView
    {
        public Action<U> OnViewUpdate = null;
        public U Data => (U) base.Data;
        protected T View => (T) base.View;

        public override void UpdateView()
        {
            OnViewUpdate?.Invoke(Data);
        }

        private T LoadView(Transform parentTransform)
        {
            var views = Resources.LoadAll<View.View>("Views");
            var loadedView = views.ToList().Find(f => f is T);
            var view = GameObject.Instantiate(loadedView, parentTransform);
            view.name = loadedView.name;
            return view.GetComponent<T>();
        }

        public T OpenView(Transform parentTransform, U data, bool autoShow = true)
        {
            var view = LoadView(parentTransform);
            this.SetView(view, data);
            
            if (autoShow) 
                this.ShowView();
            return view;
        }
    }
}