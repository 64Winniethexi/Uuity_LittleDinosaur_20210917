using UnityEngine;     //引用Unity 引擎命名空間:可以使用此空間的API

//單行註解
//class 類別:一個物件的藍圖
//語法:類別 類別名稱 { 類別內容 (類別成員) }
//此類別要在 Unity 內使用必須繼承 MonoBehaviour
public class Car : MonoBehaviour 
{
    #region 欄位語法及四大常用類型
    // 欄位 Field :保存各種類型的資料
    // 語法 :修飾詞 資料類型 欄位名稱 指定 預設值 結束符號
    // 四大常用類型:
    // 整  數: 儲存沒有小數點的正負整數 - int
    // 浮點數: 儲存帶有小數點的正負整數 - float
    // 字  串: 儲存文字資訊           - string
    // 布林值: 是與否 true false      - bool
    // 修飾詞:
    // 私人:其他類別不能存取 不顯示  private (預設值)
    // 公開:其他類別可以存取 顯  示  pibliv
    // 欄位屬性 Attritube 
    // 語法 : [屬性名稱(值)]
    // 1. 標題 Header(字串)
    // 2. 提示 Tooltip(字串)
    // 3. 範圍 Range(最大值 最小值) 
    public int cc = 1000;
    [Range(1, 10)]
    public float weight =3.5f;
    [Tooltip("這是車子的品牌名稱")]
    public string brand = "賓士";
    [Header("是否有天窗")]
    public bool hasSkyWundow = true;
    #endregion

    #region Unity 內資料類型
    // 顏色 向量(座標) 按鍵 遊戲物件 元件
    // 顏色 Color
    public Color color;
    public Color colorRed = Color.red;
    public Color colorYellow = Color.yellow;
    public Color colorCostom1 = new Color(0,0,1);
    public Color colorCostom2 = new Color(1, 0,1 ,0.5f);
    // 向量 2 ~ 4 Vector
    public Vector2 v2;
    public Vector2 v2one = Vector2.one;
    public Vector2 v2Right = Vector2.right;
    // 按鍵 keycode
    public KeyCode keycode;
    public KeyCode keycodeMouseLeft = KeyCode.Mouse0;
    public KeyCode keyCodeJump = KeyCode.Space;
    //遊戲物件 GameObject
    public GameObject goCamera;
    public GameObject goCar;
    // 元件 Componet
    public Transform traCamera;
    public Camera cam;
    public SpriteMaskInteraction spr;

    #endregion

}