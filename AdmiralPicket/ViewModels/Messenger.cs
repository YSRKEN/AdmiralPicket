using Prism.Events;

namespace AdmiralPicket.ViewModels {
	public class Messenger : EventAggregator {
		private static Messenger instance;
		public static Messenger Instance {
			get { return instance ?? (instance = new Messenger()); }
		}
	}
}