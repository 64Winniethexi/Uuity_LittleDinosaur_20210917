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
    [Header("�ˬd�a�O�ؤo�P�첾")]
    [Range(0, 1)]
    public float checkGroundRadius = 0.1f;
    public Vector3 checkGroundOffsest;
    [Header("���D����P�i���D�ϼh")]
    public KeyCode keyJump = KeyCode.Space;
    public LayerMask canJumpLayer;
    #endregion

    private Rigidbody2D rig;

    private void OnDrawGizmos()
    {
        //1. �M�w�ϥ��C��
        Gizmos.color = new Color (1, 0, 0.2f, 0.3f);
        //2. �M�wø�s�ϧ�
        Gizmos.DrawSphere(transform.position + 
            transform.TransformDirection(checkGroundOffsest), checkGroundRadius);
    }


    private void Start()
    {

        rig = GetComponent<Rigidbody2D>();
    }
    ///<summary>
    ///Undate ��60 FPS
    ///�T�w�ƥ�B:50 FPS
    ///�B�z����欰
    ///</summary>

    private void Update()
    {
        Flip();
    }

    private void FixedUpdate()
    {
        Move();
    }

    #region ��k
    ///<summary>
    /// 1.���a�O�_�����ʫ��� ���k��V
    /// 2.���󲾰ʦ欰 (API)
    /// </summary>
    private void Move()
    {
        //h�� ���w����J ���o�b�V(�����b)
        float h = Input.GetAxis("Horizontal");

        //���餸��. �[�t�� = �s �G���V�q (h ,0)
        rig.velocity = new Vector2(h * speed, rig.velocity.y);
        }
     ///<summary>
     ///½�� ;
     ///�� :���� Y 180
     ///�k :���� Y 0
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