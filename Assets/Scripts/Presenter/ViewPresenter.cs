using System;
using System.Linq;
using UnityEngine;

namespace Presenter
{
    public abstract class ViewPresenter<T, U> : Presenter where T : View.IView
    {
        public Action<U> OnViewUpdate = null;
        public new U Data => (U) base.Data;
        protected new T View => (T) base.View;

        public override void UpdateView()
        {
            OnViewUpdate?.Invoke(Data);
        }
        
        private T LoadView(Transform parentTransform)
        {
            var views = Resources.LoadAll<View.View>("Views").ToList();
            var loadedView = views.Find(f => f is T);
            var view = GameObject.Instantiate(loadedView, parentTransform).GetComponent<T>();
            view.GetGameObject.name = loadedView.name;
            return view;
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