using Prism.Mvvm;
using Reactive.Bindings;

namespace AdmiralPicket.Models
{
	class MainModel : BindableBase {
		public ReactiveProperty<string> LoggingText {
			get;
		} = new ReactiveProperty<string>();
		// ログ表示にテキストを追加する
		public void AddText(string str) {
			LoggingText.Value += $"{str}\n";
		}
	}
}
