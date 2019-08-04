
using UnityEngine;

namespace View
{
	[RequireComponent(typeof(CanvasGroup))]
	public class View : BaseView<Presenter.Presenter>, IView
	{
		public GameObject GetGameObject => this.gameObject;

		public bool Interactable
		{
			get => CanvasGroup.interactable;
			set => CanvasGroup.interactable = CanvasGroup.blocksRaycasts = value;
		}

		public bool Visible
		{
			get => CanvasGroup.alpha > 0.9f;
			set => CanvasGroup.alpha = value ? 1f : 0f;
		}

		public void CloseThisView()
		{
			Presenter.HideView();
			Presenter.DisposeView();
		}

	}
}