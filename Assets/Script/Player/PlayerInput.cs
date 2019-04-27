using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMove))]
public class PlayerInput : MonoBehaviour
{
    
    public static Vector2 Moveinput;
    public static bool LeftMouseRun;
    public static bool LeftMouse;
    public static bool RightMouse;
    public static bool RightMouseRun;
    public static bool LeftShift;
    public static bool Jump;
    public static bool Fkey;
    public static bool Rkey;
    public static float MouseX;
    public static float MouseY;
    public static Transform PlayerTrans;
    public static bool IsMoving;
    public static float Index=0;//物品栏的索引
    public static bool GKey;
    
    public static Transform FpsCameraTrans;
    private void Awake()
    {
        PlayerTrans = GetComponent<Transform>();

       

    }
  
    void Update()
    {
        MoveInput();
        Rotate();
        Escapekeydown();
        Mouseleft();
        FkeyDown();
        Ekeydown();

        Rightmouse();
        Rkeydown();
        KeepLeftShiftDown();

        MouseScrollWheel();
        GKeyDown();
    }
    private void GKeyDown()
    {
        if (CursorLock.Islock)
        {
            GKey = Input.GetKeyDown(KeyCode.G);
        }
    }
    private void MouseScrollWheel()
    {
        if (CursorLock.Islock)
        {
            Index+=Input.GetAxis("Mouse ScrollWheel");
        }
       
    }
    private void Rightmouse()
    {
        if (CursorLock.Islock)
        {
            RightMouse = Input.GetMouseButtonDown(1);
            RightMouseRun = Input.GetMouseButton(1);
        }
    }
    private void Rkeydown()
    {
        Rkey = Input.GetKeyDown(KeyCode.R);//同步
    }

    private void Ekeydown()//玩家按E打开仓库or 背包
    {

        //if (Input.GetKeyDown(KeyCode.E))
        //{

        //    CursorLock.Islock = !CursorLock.Islock;


        //    if (!PlayerManager.Instance.GetPanelState(UIPanelType.Inventory))
        //        PlayerManager.Instance.UsePanel(UIPanelType.Inventory);
        //    else
        //    {
        //        PlayerManager.Instance.DisablePanel(UIPanelType.Inventory);

        //    }
        //}
    }
    private void Rotate()//鼠标移动。。需要同步
    {
        MouseX = Input.GetAxis("Mouse X");
        MouseY = Input.GetAxis("Mouse Y");
    }
    private void MoveInput()//w,a,s,d。。需要同步
    {

        Moveinput.x = Input.GetAxis("Horizontal");
        Moveinput.y = Input.GetAxis("Vertical");
        Jump = Input.GetKey(KeyCode.Space);
       
    }

    private void TouchUp()
    {
         Moveinput.x = 0;
         Moveinput.y = 0;

    }

    private void Escapekeydown()//光标，退出界面，按Esc
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            CursorLock.Islock = !CursorLock.Islock;
        }

    }
    private void Mouseleft()
    {
        if (CursorLock.Islock)//同步
        {
            LeftMouseRun = Input.GetMouseButton(0);
            LeftMouse = Input.GetMouseButtonDown(0);

        }

    }
    public void FkeyDown()//同步
    {
        Fkey = Input.GetKeyDown(KeyCode.F);
    }
    private void KeepLeftShiftDown()
    {
        LeftShift = Input.GetKey(KeyCode.LeftShift);
    }
}
