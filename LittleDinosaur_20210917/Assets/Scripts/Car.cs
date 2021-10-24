using UnityEngine;     //�ޥ�Unity �����R�W�Ŷ�:�i�H�ϥΦ��Ŷ���API

//������
//class ���O:�@�Ӫ����Ź�
//�y�k:���O ���O�W�� { ���O���e (���O����) }
//�����O�n�b Unity ���ϥΥ����~�� MonoBehaviour
public class Car : MonoBehaviour 
{
    #region ���y�k�Υ|�j�`������
    // ��� Field :�O�s�U�����������
    // �y�k :�׹��� ������� ���W�� ���w �w�]�� �����Ÿ�
    // �|�j�`������:
    // ��  ��: �x�s�S���p���I�����t��� - int
    // �B�I��: �x�s�a���p���I�����t��� - float
    // �r  ��: �x�s��r��T           - string
    // ���L��: �O�P�_ true false      - bool
    // �׹���:
    // �p�H:��L���O����s�� �����  private (�w�]��)
    // ���}:��L���O�i�H�s�� ��  ��  pibliv
    // ����ݩ� Attritube 
    // �y�k : [�ݩʦW��(��)]
    // 1. ���D Header(�r��)
    // 2. ���� Tooltip(�r��)
    // 3. �d�� Range(�̤j�� �̤p��) 
    public int cc = 1000;
    [Range(1, 10)]
    public float weight =3.5f;
    [Tooltip("�o�O���l���~�P�W��")]
    public string brand = "���h";
    [Header("�O�_���ѵ�")]
    public bool hasSkyWundow = true;
    #endregion

    #region Unity ���������
    // �C�� �V�q(�y��) ���� �C������ ����
    // �C�� Color
    public Color color;
    public Color colorRed = Color.red;
    public Color colorYellow = Color.yellow;
    public Color colorCostom1 = new Color(0,0,1);
    public Color colorCostom2 = new Color(1, 0,1 ,0.5f);
    // �V�q 2 ~ 4 Vector
    public Vector2 v2;
    public Vector2 v2one = Vector2.one;
    public Vector2 v2Right = Vector2.right;
    // ���� keycode
    public KeyCode keycode;
    public KeyCode keycodeMouseLeft = KeyCode.Mouse0;
    public KeyCode keyCodeJump = KeyCode.Space;
    //�C������ GameObject
    public GameObject goCamera;
    public GameObject goCar;
    // ���� Componet
    public Transform traCamera;
    public Camera cam;
    public SpriteMaskInteraction spr;

    #endregion

}