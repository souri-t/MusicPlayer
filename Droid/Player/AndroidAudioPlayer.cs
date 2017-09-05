using System;
using Xamarin.Forms;
using Android.Media;
using Android.App;

[assembly: Xamarin.Forms.Dependency(typeof(MusicPlayer.Player.AndroidAudioPlayer))]


namespace MusicPlayer.Player
{
	/**	音楽再生クラス	*/
	public class AndroidAudioPlayer : IAudioPlayer
	{

		/** MediaPlayer のインスタンス生成	*/
		MediaPlayer mediaPlayer = new MediaPlayer();

		/**	コンストラクタ	*/
		public AndroidAudioPlayer()
		{
			var context = Forms.Context;


		}

		/**	曲選択時のコールバックメソッド	*/
		public void OnSelect(){
			System.Diagnostics.Debug.WriteLine("Android OnSelect");

			//FindViewById(Resource.Id.imageView);

			//			mediaPlayer.SetDataSource(Afdescripter.getFileDescriptor(), Afdescripter.getStartOffset(),
			//Afdescripter.getLength());
		}

		/**	再生時のコールバックメソッド	*/
		public void OnPlay(){
			mediaPlayer.Start();
		}

		/**	停止時のコールバックメソッド	*/
		public void OnPause(){
			mediaPlayer.Pause();
		}

		/**	前曲時のコールバックメソッド	*/
		public void OnPrevious(){
			mediaPlayer.PrepareAsync();
		}

		/**	次曲時のコールバックメソッド	*/
		public void OnNext(){
		}

	}

}