using System;
using Xamarin.Forms;

namespace MusicPlayer.Player
{

	/**	音楽再生インタフェース	*/
	public interface IAudioPlayer
    {
		/**	曲選択時のコールバックメソッド	*/
		void OnSelect();

		/**	再生時のコールバックメソッド	*/
		void OnPlay();

		/**	停止時のコールバックメソッド	*/
		void OnPause();

		/**	前曲時のコールバックメソッド	*/
		void OnPrevious();

		/**	次曲時のコールバックメソッド	*/
		void OnNext();

	}
}
