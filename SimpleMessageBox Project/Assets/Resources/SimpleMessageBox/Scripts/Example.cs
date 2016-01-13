using Main.Assets.Scripts;
using UnityEngine;

namespace Assets.Scripts
{
	public class Example : MonoBehaviour {

		void Start ()
		{
			var messageBox = Helpers.BringMessageBox();
			messageBox.SetMessage(Consts.MessageBox.StringsForUser.Example1);
			// You can choose if you want to enable the buttons(with custom text) or not
			messageBox.EnableYesAndNo("Yes!","No...");
			messageBox.onYes = () =>
			{
				Debug.Log("Handling Yes response...");
			};
			messageBox.onNo = () =>
			{
				Debug.Log("Handling No response...");
			};
			messageBox.onOutOfMessage = () =>
			{
				Debug.Log("Handling Out of message.");
				// For example you can choose to make the message dissapear
				messageBox.Dissapear();
			};
		}
	}
}
