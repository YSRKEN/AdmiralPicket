using AdmiralPicket.ViewModels;
using Prism.Events;
using System;
using System.Windows;

namespace AdmiralPicket.Views {
	/// <summary>
	/// MainView.xaml の相互作用ロジック
	/// </summary>
	public partial class MainView : Window {
		public MainView() {
			InitializeComponent();
			Messenger.Instance.GetEvent<PubSubEvent<double>>()
				.Subscribe(d => MessageBox.Show(d.ToString()));
		}
	}
}
