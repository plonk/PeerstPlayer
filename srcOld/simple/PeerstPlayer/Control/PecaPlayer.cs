﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PeerstPlayer.Event;

namespace PeerstPlayer
{
	public partial class PecaPlayer : UserControl
	{
		//-----------------------
		// 公開プロパティ
		//-----------------------

		public class Property
		{
			public const string Volume = "Volume";
		};

		// プロパティ変更イベント
		public event PropertyChangedEventHandler PropertyChanged;

		// フォームイベント
		public event FormEvent FormEvent;

		// 音量
		public int Volume
		{
			get { return wmp.settings.volume; }
			set { wmp.settings.volume = value; RaisePropertyChanged(Property.Volume); }
		}

		// 音量ミュート
		public bool Mute { get { return wmp.settings.mute; } }

		// 動画幅
		public int ImageWidth
		{
			get
			{
				if (wmp.currentMedia == null) { return DEFAULT_IMAGE_WIDTH; }
				else { return wmp.currentMedia.imageSourceWidth; }
			}
		}

		// 動画高さ
		public int ImageHeight
		{
			get
			{
				if (wmp.currentMedia == null) { return DEFAULT_IMAGE_HEIGHT; }
				else { return wmp.currentMedia.imageSourceHeight; }
			}
		}

		// アスペクト比
		public int AspectRate { get { return ImageWidth / ImageHeight; } }

		//-----------------------
		// 定義
		//-----------------------

		// デフォルト動画幅
		private const int DEFAULT_IMAGE_WIDTH = 480;

		// デフォルト動画高さ
		private const int DEFAULT_IMAGE_HEIGHT = 360;

		//-----------------------
		// 公開メソッド
		//-----------------------

		// コンストラクタ
		public PecaPlayer()
		{
			InitializeComponent();

			wmp.uiMode = "none";
			wmp.stretchToFit = true;
			wmp.MouseDownEvent += wmp_MouseDownEvent;

			WmpEventManager wmpEventManager = new WmpEventManager(wmp);
			WmpNativeWindow wmpNativeWindow = new WmpNativeWindow(wmp.Handle);
			wmpEventManager.FormEvent += wmpEventManager_FormEvent;
			wmpNativeWindow.FormEvent += wmpEventManager_FormEvent;
		}

		// URLを開く
		public void OpenUrl(string url)
		{
			wmp.URL = url;
		}

		// リトライ
		public void Retry()
		{
			wmp.URL = wmp.URL;
		}

		// 再接続
		public void Bump()
		{
		}

		// リレー切断
		public void DisconnectRelay()
		{
		}

		//-----------------------
		// 非公開メソッド
		//-----------------------

		// プロパティ変更通知
		private void RaisePropertyChanged(string propertyName)
		{
			if (PropertyChanged == null) { return; }
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
		}

		// マウス押下イベント
		private void wmp_MouseDownEvent(object sender, AxWMPLib._WMPOCXEvents_MouseDownEvent e)
		{
			// WMPフルスクリーンを解除
			if (wmp.fullScreen)
			{
				wmp.fullScreen = false;
			}
		}

		// Formイベント
		private void wmpEventManager_FormEvent(FormEventArgs args)
		{
			// イベント通知
			Notify(args);
		}

		// イベント通知
		private void Notify(FormEventArgs args)
		{
			if (FormEvent != null)
			{
				FormEvent(args);
			}
		}
	}
}
