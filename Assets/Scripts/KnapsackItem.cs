using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnapsackItem : UIDragDropItem {

	protected override void OnDragDropRelease(GameObject surface)
	{
		base.OnDragDropRelease(surface);

		if (surface.tag == "grid")
		{
			//物品居中
			this.transform.parent = surface.transform;
			this.transform.localPosition = Vector3.zero;
		}
		else if (surface.tag == "grid_item")
		{
			//交换物品
			Transform parent = surface.transform.parent;
			surface.transform.parent = this.transform.parent;
			surface.transform.localPosition = Vector3.zero;
			this.transform.parent = parent;
			this.transform.localPosition = Vector3.zero;
		}
	}
}
