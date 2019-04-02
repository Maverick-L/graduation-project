using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTip : MonoBehaviour
{
	private void Awake()
	{
		LevelAreaBase._instance.LevelAreaEvent += _instance_LevelAreaEvent;
	}

	private void _instance_LevelAreaEvent(object sender, System.EventArgs e)
	{
		GameObject tip = Resources.Load(Myconts.REOURCE_UI_PATH + "Tips") as GameObject;
        MainManager._instance.Create(tip, GameManagers.Type.UI);
	}

}
