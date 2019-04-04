using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;
public class GameManagers :MonoBehaviour
{

    public static GameManagers _instance;
    public EffectManager _effectManager;
    public GoldManager _goldManager;
    public TimeManager _timeManager;
    private ArmMassage[] Allitems;//存放游戏中所有的武器
    private GameObject[] playerItems=new GameObject[3];//存放玩家拥有的武器,玩家只能，最多拥有三把武器
    private bool armIsFull = false;//用来判断是否满了；
    public enum Type
    {
        NPC,
        Arm,
		UI
    }

    #region property
   
    #endregion


    #region Event


    #endregion

   

    #region Method Public
    /// <summary>
    /// 初始化PoolManager需要用到的枚举
    /// </summary>
    /// <returns></returns>
    public Enum[] Getenum()
    {
        Enum[] enums=new Enum[] { Type.NPC,Type.Arm ,Type.UI};
        return enums;
    }


    /// <summary>
    /// 创建一个怪物
    /// </summary>
    public void CreatEnemy(Transform targetTransform, GameObject targetObject)
    {
       GameObject go= MainManager._instance._poolManager.Create(targetObject,Type.NPC);
        go.transform.position = targetTransform.position;
        go.transform.rotation = targetTransform.rotation;
        go.transform.parent = targetTransform;
    }

    /// <summary>
    /// 创建商人Merchant
    /// </summary>
    public void CreateMerchant(Transform targetTransform, GameObject targetObject)
    {
        GameObject go = MainManager._instance._poolManager.Create(targetObject,Type.NPC);
    }


    //死亡处理
    public void Death(System.Object sender,DeathEventArgs e )
    {
        MainManager._instance._poolManager.Destroy(e.senderObject,Type.NPC);
        switch (sender.GetType().Name)
        {
            case "Enemy":
                //进行奖励调用
                Award(e.grade, e.senderObject.transform);
                break;
            case "Player":
                //调用死亡之后的UI
                break;
        }
    }

    /// <summary>
    /// 
    /// 生成的装备是Player所拥有的装备
    /// 
    /// 指定名字的装备，如果有名字相同的返回第一个，如果装备没有，则返回空
    /// </summary>
    /// <param name="name">装备名字</param>
    /// <returns></returns>
    public GameObject CreateArm(string name)
    {
        foreach(GameObject item in playerItems)
        {
            if (name == item.name&&item.activeSelf==false)
            {
     
                return item;
            }
        }
        return null;
    } 
    /// <summary>
    /// 武器切换
    /// </summary>
    /// <param name="nextname">切换后的武器的名称</param>
    public void CutArm(string nextname)
    {
        GameObject go = CreateArm(nextname);
        if (go == null) {
            return;
        }

        foreach (GameObject item in playerItems)
        {
            if (item.activeSelf)
            {
                go.transform.position = item.transform.position;
                go.transform.rotation = item.transform.rotation;
                item.SetActive(false);
            }
        }
        go.SetActive(true);

    }

    #endregion

    #region Method Private
    private void Awake()
    {
        _instance = this;
        MainManager._instance.InitManager();
        StartCoroutine(InitExcel());
        //人物拥有的三把武器不需要进入poolmanager  初始化之后存放在这个里面就可以
        playerItems[0] = MainManager._instance._poolManager.Create(Resources.Load(Myconts.RSOURCE_PREFABS_PATH + "Cube") as GameObject, Type.Arm);
        playerItems[1] = MainManager._instance._poolManager.Create(Resources.Load(Myconts.RSOURCE_PREFABS_PATH + "Sphere") as GameObject, Type.Arm);
        playerItems[2] = MainManager._instance._poolManager.Create(Resources.Load(Myconts.RSOURCE_PREFABS_PATH + "Capsule") as GameObject, Type.Arm);
        playerItems[0].SetActive(true);
        //监听
        NPC.DeathEvent += Death;
    }

    private void Award(int grade,Transform point)
    {
        //奖励金币
        //奖励武器
        ArmMassage arm = AwardArm();
        GameObject go = MainManager._instance._poolManager.Create(Resources.Load(Myconts.RSOURCE_PREFABS_ARM_PATH + arm.name)as GameObject, Type.Arm);
        go.transform.position = point.position;
        go.transform.rotation = point.rotation;
        InitArm(go, arm);
       
    }

    /// <summary>
    /// 奖励武器
    /// </summary>
    /// <returns>返回武器的名字</returns>
    private ArmMassage AwardArm()
    {
        int index = UnityEngine.Random.Range(0,ExcelContral.RowsNum(Myconts.EXCELFILE_PATH+"Item.xlsx"));
        return Allitems[index];
    }

    /// <summary>
    /// 初始化武器属性
    /// </summary>
    /// <param name="initTargetArm">初始化的武器物体</param>
    /// <param name="arm">初始化信息</param>
    private void InitArm(GameObject initTargetArm,ArmMassage arm)
    {
        initTargetArm.GetComponent<Arm>().Init(arm);
    }

    /// <summary>
    /// 数组满了之后表示武器背包满格，之后的操作
    /// </summary>
    private void ArmIsFull()
    {
        if (armIsFull)
        {
            //UI显示背包满了是否替换
        }
        else
        {

        }

    }


    #endregion

    #region IEnumator

    IEnumerator InitExcel()
    {
        int columnNum = 0;
        int rowsNum = 0;
        string path = Application.dataPath + Myconts.EXCELFILE_PATH + "Item.xlsx";
        string[,] Item = ExcelContral.DataReader(path, ref columnNum, ref rowsNum);
        Allitems = new ArmMassage[columnNum];
        for(int i = 0; i < rowsNum; i++)
        {
            Allitems[i].id = int.Parse(Item[i,0].ToString());
            Allitems[i].name = Item[i,1].ToString();
            Allitems[i].Intro = Item[i, 2].ToString();
            Allitems[i].price = int.Parse(Item[i,3].ToString());
            Allitems[i].attackDamage = float.Parse(Item[i,4].ToString());
            Allitems[i].attackSpeed = float.Parse(Item[i,5].ToString());
            Allitems[i].grade = 1;
            Allitems[i].durable = 100;
           
        }
        yield return Allitems;
    }
    #endregion
}
