using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Grid : MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler,ICanvasRaycastFilter
{
    private Transform canvesTra;
    private Transform nowParent;//记录当前物品的格子是那个一个
    private bool isRayCastLocationValid = true;//射线是否可以穿透
    public bool isRun=true;//此物品是否可以使用
    public int grid;//此物品所在位置


    public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
    {
        if (!KnapsackManager.instance.isDrag||!isRun)
        {
            return false;
        }
        return isRayCastLocationValid;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
            canvesTra = GameObject.Find("Knapsack").transform;
            nowParent = transform.parent;
            transform.SetParent(canvesTra);
            isRayCastLocationValid = false;
    }


    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {

            GameObject go = eventData.pointerCurrentRaycast.gameObject;
        //print(go.tag);
        if (go != null)
        {
            if (go.tag == "Grid")
            {
                SetParentAndPostion(go.transform, this.transform);
                   KnapsackManager.instance.ChangePos(grid, int.Parse(go.name.Split('-')[1]));

            }
            else if (go.tag == "Item")
            {
                SetParentAndPostion(go.transform.parent, this.transform);
                SetParentAndPostion(nowParent, go.transform);
                  KnapsackManager.instance.ChangePos(grid, go.GetComponent<Grid>().grid);
            }
            else if (go.tag == "TrashBinGrad")
            {
                SetParentAndPostion(go.transform.parent, this.transform);
                KnapsackManager.instance.ChangePos(grid);
                GameObject ob = go.transform.parent.parent.gameObject;
               
            }
        else
        {

            SetParentAndPostion(nowParent, this.transform);
        }              
            }
            else
            {
                SetParentAndPostion(nowParent, this.transform);
            }
      //  Rotate.enabled=false;
        isRayCastLocationValid = true;
    }

    public void SetParentAndPostion(Transform Parent,Transform child)
    {
        child.SetParent(Parent);
        child.position = Parent.position;
    }
}
