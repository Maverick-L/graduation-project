using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KnapsackManager : MonoBehaviour
{
    #region Public field
    public static KnapsackManager instance;
    public bool isDrag = true;//是否允许拖拽
    public GameObject GridFullMassage;//格子满了提示消息
    public GameObject PageButton;//创建显示页数的Button
    public int GoodsSum;//物品的总数
    public Transform[] Grid;//格子
    public Transform Page;

    private ArmMassage[] arm;
    private DrugMassage[] drug;

    public int ItemsNum { get {
            int value = 0;
            for (int i = 0; i < Item.Count; i++)
            {
                foreach (GameObject go in Item[i])
                {
                    if (go!=null&&go.name != "OutOfRun")
                    {
                        value++;
                    }
                }
            }
            return value;

        } }
    #endregion

    #region private field

    private List<GameObject[]> Item = new List<GameObject[]>();
    private bool isfull = false;
    private int PageNum;//已经有的页码
    private int NowPage = 1;//当前页码
    private int Pagelimit;//页码限制，上限
    private int GridSum;//格子数
    #endregion

    #region MonoBehaviour Method
    private void Awake()
    {
        instance = this;

    }

    private void Start()
    {
        GridSum = Grid.Length;
        LimitPage();
        AddPage();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PickUp("Xiangjiaopi", RubbishType.Fruit);
            PickUp("Batteriers", RubbishType.Battery);
        }
    }
    #endregion

    #region Private Method
    /// <summary>
    /// 查询格子
    /// </summary>
    /// <returns></returns>
    private void GridIsFull(string name)
    {
        for (int j = 0; j < PageNum; j++)
        {
            for (int i = 0; i < GridSum; i++)
            {
                if (Item[j][i] == null)
                {
                    AddItem(j, name, i);
                    return;
                }
            }
        }
    }

    /// <summary>
    /// 添加装备
    /// </summary>
    private void AddItem(int page, string name, int pos)
    {
        GameObject go = Instantiate(Resources.Load(Const.RESOURCES_PREFAB_PATH + "RubbishUI/" + name) as GameObject);

        if (go == null)
        {
            print("无此物品");
        }
        else
        {
            go.transform.SetParent(Grid[pos]);//加入到对应的列表下面
            go.transform.position = Grid[pos].position;
            Grid targetgrid = go.GetComponent<Grid>();
            targetgrid.grid = pos;
            targetgrid.type = type;
            Item[page][pos] = go;
            if (page + 1 == NowPage)
            {
                go.SetActive(true);
            }
            else
            {
                go.SetActive(false);
            }
            go.name = name;
        }
    }

    #endregion

    #region Public Method
    /// <summary>
    /// 捡起物品
    /// </summary>
    /// <param name = "name" > 物品的名字 </ param >
    public void PickUp(string name, RubbishType type)
    {
        GridIsFull(name, type);
        if (isfull)
        {
            GridFullMassage.SetActive(true);
            return;
        }

    }

    /// <summary>
    /// 设置页数的顶峰值，修改相应的物品为OutOfRun
    /// </summary>
    public void LimitPage()
    {
        Pagelimit = GoodsSum / GridSum + 1;//获取到页码上限
        for (int i = 0; i < Pagelimit; i++)
        {
            Item.Add(new GameObject[Grid.Length]);
            if (i == Pagelimit - 1)
            {
                for (int j = GoodsSum % GridSum; j < GridSum; j++)
                {
                    AddItem(i, "OutOfRun", j, RubbishType.Nomal);
                }
            }
        }
    }

    /// <summary>
    /// 点击切换页码
    /// </summary>
    /// <param name="page">页码</param>
    public void OnClick(int page)
    {
        CutPage(page);

    }


    /// <summary>
    /// 替换位置
    /// </summary>
    /// <param name="lastpos">拖动的物体的编号</param>
    /// <param name="nowpos">被替换的物体的编号,如果为空，返回格子编号</param>
    public void ChangePos(int lastpos,int nowpos,bool isremove=false)
    {
        if (!isremove)
        {
            if (nowpos == -1)
            {
                Item[NowPage-1][nowpos] = Item[NowPage][lastpos];
                Item[NowPage-1][lastpos] = null;
                return;
            }
            GameObject go = Item[NowPage-1][nowpos];//被替换的物体
            Item[NowPage-1][nowpos] = Item[NowPage-1][lastpos];
            Item[NowPage-1][lastpos] = go;
        }
    }
    
    public void ChangePos(int nowpos,bool isremove = true)
    {
        if (isremove)
        {
            Item[NowPage-1][nowpos]=null;          
        }
    }


    #endregion

}
