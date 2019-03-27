using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayBn : MonoBehaviour
{
	public Text UIText;
	private float timer;
    // Start is called before the first frame update
    void Start()
    {
		timer = 0.0f;
    }

	// Update is called once per frame
	void Update()
	{
		timer += Time.deltaTime * 2;
		if (timer % 2 > 1.0f)
		{
			UIText.text = "";
		}
		else
		{
			UIText.text = "开始游戏";
		}
    }
}
