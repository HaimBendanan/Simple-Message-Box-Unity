using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Main.Assets.Scripts
{
	public class MessageBox : MonoBehaviour 
	{
		public Action onYes;
		public Action onNo;
		public Action onOutOfMessage;
		private string _message;
		private Text _mainText;
		private SpriteRenderer _blurBackground;
		private GameObject _yesBtn, _noBtn,_closeBtn;

		private void Awake()
		{
			var tx = GetComponentsInChildren<Transform>();
			var mainTextGo = tx.FirstOrDefault(transformChild => transformChild.gameObject.tag == Consts.MessageBox.Tags.MessageBoxText);
			var blurBackgroundGo =
				tx.FirstOrDefault(transformChild => transformChild.gameObject.tag == Consts.MessageBox.Tags.MessageBoxBlur);
			var yesGo = tx.FirstOrDefault(transformChild => transformChild.gameObject.tag == Consts.MessageBox.Tags.MessageBoxYes);
			var noGo = tx.FirstOrDefault(transformChild => transformChild.gameObject.tag == Consts.MessageBox.Tags.MessageBoxNo);
			var closeGo = tx.FirstOrDefault(transformChild => transformChild.gameObject.tag == Consts.MessageBox.Tags.CloseOption);

			try
			{
				_mainText = mainTextGo.GetComponent<Text>();
				_blurBackground = blurBackgroundGo.GetComponent<SpriteRenderer>();
				_yesBtn = yesGo.gameObject;
				_noBtn = noGo.gameObject;
				_closeBtn = closeGo.gameObject;
				DisableYesAndNo();
			}
			catch (Exception e)
			{
				Debug.LogErrorFormat("couldnt initialize fields of message box. error: {0}", e);
			}
		}
		private void DisableYesAndNo()
		{
			_yesBtn.SetActive(false);
			_noBtn.SetActive(false);
		}
		public void DisableCloseBtn()
		{
			_closeBtn.SetActive(false);
		}
		public void EnableYesAndNo(string yesText = "yes", string noText = "no")
		{
			_yesBtn.SetActive(true);
			_noBtn.SetActive(true);
			_yesBtn.GetComponentInChildren<Text>().text = yesText;
			_noBtn.GetComponentInChildren<Text>().text = noText;
		}
		public void SetMessage(string mes)
		{
			_mainText.text = mes;
		}
		public void MainMessageBoxClicked()
		{
			Debug.Log("main message touched");
		}
		public void YesClicked()
		{
			Debug.Log("Yes clicked");
			if (onYes != null)
				onYes();
			Dissapear();
		}
		public void NoClicked()
		{
			Debug.Log("No clicked");
			if (onNo != null)
				onNo();
			Dissapear();
		}
		public void OutOfMessageClicked()
		{
			Debug.Log("Out Of Message clicked");
			if (onOutOfMessage != null)
				onOutOfMessage();
			else
			{
				NoClicked();//default behaviour is to exit
			}
		}
		public void CloseClicked()
		{
			Debug.Log("Close clicked. For me it s a no.");
			NoClicked();
		}
		public void Dissapear()
		{
			Debug.Log("message dissapear");
			GetComponent<Animator>().Play((Consts.MessageBox.Animations.MessageBoxDissappear));
			Destroy(this.gameObject,1f);
		}
	}
}

