using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 控制器:2D橫向卷軸版本
/// </summary>

public class Controller2D : MonoBehaviour
{
    #region 欄位:公開
    [Header("移動速度"), Range(0, 500)]
    public float speed = 3.5f;
    [Header("跳躍高度"), Range(0, 15000)]
    public float jump = 300;
    #endregion

    private Rigidbody2D rig;

    private void Start()
    {

        rig = GetComponent<Rigidbody2D>();
    }
    ///<summary>
    ///Undate 約60 FPS
    ///固定事件處:50 FPS
    ///處理物件行為
    ///</summary>
    private void FixedUpdate()
    {
        Move();
    }
    #region 方法
    ///<summary>
    /// 1. 玩家是否有按移動按鍵 左右方向鍵
    /// 2.玩家移動行為<API>
    ///</summary>
    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        print("玩家左右按鍵值" + h);
    }
    

    #endregion
}