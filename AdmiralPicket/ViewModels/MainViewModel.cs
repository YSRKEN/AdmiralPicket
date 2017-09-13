using AdmiralPicket.Models;
using Prism.Events;
using Reactive.Bindings;

namespace AdmiralPicket.ViewModels
{
	class MainViewModel {
		// Model設定
		private MainModel model;
		// 座標取得ボタン
		public ReactiveCommand GetPosition { get; }
		// コンストラクタ
		public MainViewModel(){
			model = new MainModel();
			GetPosition = new ReactiveCommand();
			GetPosition.Subscribe(new System.Action(model.AddText("座標取得");));
		}
	}
}
