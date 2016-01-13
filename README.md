# Simple-Message-Box-Unity
A simple message box for unity.
You can easily set the text, choose to have no buttons, or 2 buttons with custom labels. The background around the textbox is automatically blurred. you can easily suply actions for 'On Yes' , 'On No' or 'On out of textBox' clicked.

Add to your Unity project:
Simply import the SimpleMessageBox package to your project. all the files are under ressources/SimpleMessageBox so it should be easy to locate the import location of the files.
You can also open the SimpleMessageBox project if you want to have a look a the files and test the message box before importing the package.

Create a message box:
var messageBox = Helpers.BringMessageBox();

Set the text of the message box:
messageBox.SetMessage(Consts.StringsForUser.Example1);

Add buttons(optional) with custom text
messageBox.EnableYesAndNo("Yes!","No...");

Supply actions for button press, close or clicks outside of the box
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
}
