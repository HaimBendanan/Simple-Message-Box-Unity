# Simple-Message-Box-Unity
A message box for unity (IOS/Android/...).
You can easily set the text, choose to have no buttons, or 2 buttons with custom labels. The background around the textbox is automatically blurred. You can easily suply actions for 'On Yes' , 'On No' or 'On out of textBox' clicked.
You can easily change the background of the box, the buttons, the fonts etc'.
Be aware that you should not prompt more than one message at the same time.

[Screenshot 1](http://postimg.org/image/9izfjazcd/)  

[Screenshot 2](http://postimg.org/image/ib7zj4u3j/)  

[Screenshot 3](http://postimg.org/image/duh3tt09b/)  


##Add the package to your Unity project:
Import the SimpleMessageBox package to your project ([How to Here](http://answers.unity3d.com/questions/10813/importing-a-unitypackage.html)). All the files are under ressources/SimpleMessageBox so it should be easy to locate the import location of the files.
You can also open the SimpleMessageBox project if you want to have a look a the files and test the message box before importing the package.

##Create a message box:
```
var messageBox = Helpers.BringMessageBox();
```
##Set the text of the message box:
```
messageBox.SetMessage(Consts.StringsForUser.Example1);
```
##Add buttons(optional) with custom text
```
messageBox.EnableYesAndNo("Yes!","No...");
```
##Supply actions for button press, close or clicks outside of the box
```
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
```
