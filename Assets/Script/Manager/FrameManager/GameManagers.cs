using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;
public class GameManagers :MonoBehaviour
{
    #region Fild

    public static GameManagers _instance;

    public EffectManager _effectManager;
    public GoldManager _goldManager;
    public TimeManager _timeManager;


    private ArmMassage[] Allitems;//存放游戏中所有的武器
    private GameObject tipUI;//用来确定按下是yes和no的提示
    private ArmMassage[] takeArm;//确定带走的武器
    private DrugMassage[] takeDrug;//确定带走的药品


    #endregion

    #region Enum
    public enum Pooltype
    {
        NPC,
        Arm,
		UI
    }
    #endregion

    #region property
    public bool backIsFull { get; set; }//背包是否满格
    public ArmMassage[] TakeArm { get { return takeArm; } }
    public DrugMassage[] TakeDrug { get { return takeDrug; } }

    #endregion


    #region Event


    #endregion

    #region MonoBehaviour Method

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        MainManager._instance.InitManager();
        StartCoroutine(InitArmExcel());

        //监听
        NPC.DeathEvent += Death;
    }

    private void Start()
    {
        backIsFull = false;
    }
    #endregion



    #region Method Public

    /// <summary>
    /// 初始化PoolManager需要用到的枚举
    /// </summary>
    /// <returns></returns>
    public Enum[] Getenum()
    {
        Enum[] enums=new Enum[] { Pooltype.NPC,Pooltype.Arm ,Pooltype.UI};
        return enums;
    }

    /// <summary>
    /// 创建一个怪物
    /// </summary>
    public void CreatEnemy(Transform targetTransform, GameObject targetObject)
    {
       GameObject go= MainManager._instance._poolManager.Create(targetObject, Pooltype.NPC);
        go.transform.position = targetTransform.position;
        go.transform.rotation = targetTransform.rotation;
        go.transform.parent = targetTransform;
        go.SetActive(true);
    }

    /// <summary>
    /// 创建商人Merchant
    /// </summary>
    public void CreateMerchant(Transform targetTransform, GameObject targetObject)
    {
        GameObject go = MainManager._instance._poolManager.Create(targetObject,Pooltype.NPC);
    }

    /// <summary>
    /// 统一管理所有死亡的信息，包括角色死亡，怪物死亡s
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void Death(System.Object sender,DeathEventArgs e )
    {
        MainManager._instance._poolManager.Destroy(e.senderObject,Pooltype.NPC);
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
    /// 生成武器
    /// </summary>
    /// <param name="name">装备名字</param>
    /// <returns></returns>
    public GameObject CreateArm(string name)
    {
        foreach(ArmMassage item in Allitems)
        {
            if (name == item.name)
            {
                GameObject go = Resources.Load(Myconts.RSOURCE_PREFABS_ARM_PATH + name) as GameObject;
                go = MainManager._instance._poolManager.Create(go, Pooltype.Arm);
                return go;

            }
        }
        return null;
    } 

   

    public void TipUI(string text)
    {

    }


    #endregion





    #region Method Private

    /// <summary>
    /// 奖励
    /// </summary>
    /// <param name="grade"></param>
    /// <param name="point"></param>
    private void Award(int grade, Transform point)
    {
        //奖励金币
        //奖励武器
        ArmMassage arm = new ArmMassage();
        arm = AwardArm();
        GameObject go1 = Resources.Load(Myconts.RSOURCE_PREFABS_ARM_PATH + arm.name) as GameObject;
        GameObject go = MainManager._instance._poolManager.Create(go1, Pooltype.Arm);
        go.transform.position = point.position;
        go.transform.rotation = point.rotation;
        InitArm(go, arm);

    }

    /// <summary>
    /// 奖励武器
    /// </summary>
    /// <returns>返回武器的所有基础属性</returns>
    private ArmMassage AwardArm()
    {
        int index = UnityEngine.Random.Range(0,Allitems.Length-1);
        return Allitems[index];
    }

    /// <summary>
    /// 武器创建成功后初始化武器属性
    /// </summary>
    /// <param name="initTargetArm">初始化的武器物体</param>
    /// <param name="arm">初始化信息</param>
    private void InitArm(GameObject initTargetArm,ArmMassage arm)
    {
        initTargetArm.GetComponent<Arm>().Init(arm);
    }


    #endregion

    #region IEnumator

    IEnumerator InitArmExcel()
    {
        int columnNum = 0;
        int rowsNum = 0;
        string path = Application.dataPath + Myconts.EXCELFILE_PATH + "Item.xlsx";
        string[,] Item = ExcelContral.DataReader(path, ref columnNum, ref rowsNum);
        Allitems = new ArmMassage[rowsNum];
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
            Allitems[i].sprite = Resources.Load(Myconts.RESOURCE_SPRITE_ARM_PATH + Allitems[i].name) as Sprite;
        }

        yield return Allitems;
    }
    #endregion
}
