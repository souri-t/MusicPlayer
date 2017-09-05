using Xamarin.Forms;

namespace MusicPlayer
{
	public partial class MusicPlayerPage : ContentPage
	{
		/**	コンストラクタ	*/
		public MusicPlayerPage(){
			InitializeComponent();
		}

		/**	曲選択ボタン押下時のコールバックメソッド	*/
		private void OnSelectButtonClicked(object sender, System.EventArgs e){
			DependencyService.Get<Player.IAudioPlayer>().OnSelect();
		}

		/**	再生ボタン押下時のコールバックメソッド	*/
		private void OnPlayButtonClicked(object sender, System.EventArgs e){
			DependencyService.Get<Player.IAudioPlayer>().OnPlay();
		}

		/**	停止ボタン押下時のコールバックメソッド	*/
		private void OnPauseButtonClicked(object sender, System.EventArgs e){
			DependencyService.Get<Player.IAudioPlayer>().OnPause();
		}

		/**	前曲ボタン押下時のコールバックメソッド	*/
		private void OnPreviousButtonClicked(object sender, System.EventArgs e)
		{
			DependencyService.Get<Player.IAudioPlayer>().OnPrevious();
		}

		/**	次曲ボタン押下時のコールバックメソッド	*/
		private void OnNextButtonClicked(object sender, System.EventArgs e){
			DependencyService.Get<Player.IAudioPlayer>().OnNext();
		}
	}
}
