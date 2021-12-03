using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 控制器:2D橫向卷軸版本
/// </summary>

public class Controller2D : MonoBehaviour
{
    #region 公開
    [Header("移動速度"), Range(0, 500)]
    public float speed = 3.5f;
    [Header("跳躍高度"), Range(0, 15000)]
    public float jump = 300;
    [Header("檢查地板尺寸與位移")]
    [Range(0, 1)]
    public float checkGroundRadius = 0.1f;
    public Vector3 checkGroundOffsest;
    [Header("跳躍按鍵與可跳躍圖層")]
    public KeyCode keyJump = KeyCode.Space;
    public LayerMask canJumpLayer;
    [Header("動畫參數:走路與跳躍")]
    public string parameterWalk = "開關走路";
    public string parameterJump = "開關跳躍";
    #endregion

    #region 私人
    private Animator ani;

    private Rigidbody2D rig;

    [SerializeField]
    private bool isGrounded;
    #endregion

    #region 事件
    ///<summary>
    ///檢查是否在地板
    /// </summary>

    private void OnDrawGizmos()
    {
        //1. 決定圖示顏色
        Gizmos.color = new Color(1, 0, 0.2f, 0.3f);
        //2. 決定繪製圖形
        Gizmos.DrawSphere(transform.position +
            transform.TransformDirection(checkGroundOffsest), checkGroundRadius);
    }


    private void Start()
    {

        rig = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }
    ///<summary>
    ///Undate 約60 FPS
    ///固定事件處:50 FPS
    ///處理物件行為
    ///</summary>

    private void Update()
    {
        Flip();
        CheckGround();
        Jump();
    }

    private void FixedUpdate()
    {
        Move();
    }
    #endregion

    #region 方法
    private void CheckGround() 
     {
          
        Collider2D hit = Physics2D.OverlapCircle(transform.position +
        transform.TransformDirection(checkGroundOffsest), checkGroundRadius, canJumpLayer);

        //print("碰到的物件名稱" + hit.name);
        isGrounded = hit;

        ani.SetBool(parameterJump, !isGrounded);
     }
    

    
    private void Jump()
    {
        //如果 在地板上 按下指定按鍵
        if (isGrounded && Input.GetKeyDown(keyJump))
        {
            rig.AddForce(new Vector2(0, jump));
        }
    }
    
    ///<summary>
    /// 1.玩家是否有移動按鍵 左右方向
    /// 2.物件移動行為 (API)
    /// </summary>
    private void Move()
    {
        //h值 指定為輸入 取得軸向(水平軸)
        float h = Input.GetAxis("Horizontal");

        //剛體元件. 加速度 = 新 二為向量 (h ,0)
        rig.velocity = new Vector2(h * speed, rig.velocity.y);

        ani.SetBool(parameterWalk, h != 0);

        }
     ///<summary>
     ///翻面 ;
     ///左 :角度 Y 180
     ///右 :角度 Y 0
     /// </summary>
     
    private void Flip()
    {
        float h = Input.GetAxis("Horizontal");
        
        if (h < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);

        }
        else if (h > 0)
        {
            transform.eulerAngles = Vector3.zero;
        }
    }

    #endregion
}