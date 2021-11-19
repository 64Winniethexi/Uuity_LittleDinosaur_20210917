using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���:2D��V���b����
/// </summary>

public class Controller2D : MonoBehaviour
{
    #region ���:���}
    [Header("���ʳt��"), Range(0, 500)]
    public float speed = 3.5f;
    [Header("���D����"), Range(0, 15000)]
    public float jump = 300;
    #endregion

    private Rigidbody2D rig;

    private void Start()
    {

        rig = GetComponent<Rigidbody2D>();
    }
    ///<summary>
    ///Undate ��60 FPS
    ///�T�w�ƥ�B:50 FPS
    ///�B�z����欰
    ///</summary>
    private void FixedUpdate()
    {
        Move();
    }
    #region ��k
    ///<summary>
    /// 1. ���a�O�_�������ʫ��� ���k��V��
    /// 2.���a���ʦ欰<API>
    ///</summary>
    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        print("���a���k�����" + h);
    }
    

    #endregion
}