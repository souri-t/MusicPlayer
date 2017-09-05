using MediaPlayer;
using UIKit;
using Xamarin.Forms;


[assembly: Xamarin.Forms.Dependency(typeof(MusicPlayer.Player.IosAudioPlayer))]

namespace MusicPlayer.Player
{
	/**	音楽再生クラス	*/
	public class IosAudioPlayer : MPMediaPickerControllerDelegate, IAudioPlayer{

		/**	Playerインスタンス		*/
		private MPMusicPlayerController player = null;

		/**	コンストラクタ	*/
		public IosAudioPlayer(){
			/**	Player生成	*/
			player = MPMusicPlayerController.ApplicationMusicPlayer;

		}

		/**	曲選択時のコールバックメソッド	*/
		public void OnSelect(){
			System.Diagnostics.Debug.WriteLine("iOS OnSelect");

			/** ピッカーのインスタンスを作成    */
			var picker = new MPMediaPickerController();

			/**	ピッカーのデリゲートを設定	*/
			picker.Delegate = this;

			/**	ピッカーの複数選択を可にする	*/
			picker.AllowsPickingMultipleItems = true;

			/**	ピッカーを表示	*/
			UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewController(picker, true, null);

		}

		/**	再生時のコールバックメソッド	*/
		public void OnPlay(){
			System.Diagnostics.Debug.WriteLine("iOS OnPlay");
			player.Play();
		}

		/**	停止時のコールバックメソッド	*/
		public void OnPause(){
			System.Diagnostics.Debug.WriteLine("iOS OnPause");
			player.Pause();
		}

		/**	前曲時のコールバックメソッド	*/
		public void OnPrevious(){
			System.Diagnostics.Debug.WriteLine("iOS OnPrevious");
			player.PrepareToPlay();
		}

		/**	次曲時のコールバックメソッド	*/
		public void OnNext(){
			System.Diagnostics.Debug.WriteLine("iOS OnNext");
			player.SkipToNextItem();
		}

		/**	ピッカー曲選択時のコールバックメソッド	*/
		public override void MediaItemsPicked(MPMediaPickerController sender, MPMediaItemCollection mediaItemCollection){
			System.Diagnostics.Debug.WriteLine("iOS MediaItemsPicked");

			/**	選択した曲情報をplayerに設定	*/
			this.player.SetQueue(mediaItemCollection);

			/**	再生	*/
			player.Play();

			var mediaItem = mediaItemCollection.Items[0];

			/**	ピッカーを閉じる	*/
			UIApplication.SharedApplication.KeyWindow.RootViewController.DismissViewController(true, null);
		}

		/**	ピッカーキャンセル時のコールバックメソッド	*/
		public override void MediaPickerDidCancel(MPMediaPickerController sender){
			System.Diagnostics.Debug.WriteLine("iOS MediaPickerDidCancel");

			/**	ピッカーを閉じる	*/
			UIApplication.SharedApplication.KeyWindow.RootViewController.DismissViewController(true, null);
		}
	}
}