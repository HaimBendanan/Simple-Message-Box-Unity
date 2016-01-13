using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Main.Assets.Scripts
{
	public class Helpers
	{
		public static GameObject BringPrefabToScene(string prefab)
		{
			return GameObject.Instantiate(RessourcesLoadPrefab(prefab));
		}
		public static GameObject RessourcesLoadPrefab(string prefab)
		{
			return Resources.Load("SimpleMessageBox/Prefabs/" + prefab) as GameObject;
		}

		public static GameObject BringPrefabToScene(string prefab, float x, float y)
		{
			var obj = BringPrefabToScene(prefab);
			obj.transform.position = new Vector3(x, y, obj.transform.position.z);
			return obj;
		}

		public static MessageBox BringMessageBox()
		{
			return BringPrefabToScene(Consts.MessageBox.Prefabs.MessageBox).GetComponent<MessageBox>();
		}
	}
}
