using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Main.Assets.Scripts
{
	public class Consts
	{
		public class MessageBox
		{
			public class Prefabs
			{
				public const string MessageBox = "MessageBoxFlat";
			}
			public class Animations
			{
				public const string MessageBoxDissappear = "MessageBoxDissappear";
				public const string MessageBoxAppear = "MessageBoxAppear";
			}
			public class StringsForUser
			{
				public const string Example1 = "this is a basic textBox";
			}
			public class Tags
			{
				public const string MessageBoxBlur = "MessageBoxBlur";
				public const string MessageBox = "MessageBox";
				public const string MessageBoxText = "MessageBoxText";
				public const string MessageBoxYes = "MessageBoxYes";
				public const string MessageBoxNo = "MessageBoxNo";
				public const string CloseOption = "CloseOption";
			}
		}
	}
}
