using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


// �̳У����£�̧����뿪�������ӿ�
public class PositionButtonUIControl:MonoBehaviour,IPointerDownHandler,IPointerUpHandler,IPointerExitHandler
{

    // �ӳ�ʱ��
    private float delay = 0.2f;
    // ��ť�Ƿ��ǰ���״̬
    private bool isDown = false;
    // ��ť���һ���Ǳ���ס״̬ʱ���ʱ��
    private float lastIsDownTime;


    private GameObject player;
    private Rigidbody2D myRigidbody;
    private float Speed;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        myRigidbody = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
        Speed = PlayerController.runSpeed;
    }

    void Update()
    {
        // �����ť�Ǳ�����״̬
        if (isDown)
        {
            // ��ǰʱ�� -  ��ť���һ�α����µ�ʱ�� > �ӳ�ʱ��0.2��
            if (Time.time - lastIsDownTime > delay)
            {
                // ������������
                Debug.Log("����");
                // ��¼��ť���һ�α����µ�ʱ��
                lastIsDownTime = Time.time;
            }
        }

    }


    // ����ť�����º�ϵͳ�Զ����ô˷���
    public void OnPointerDown(PointerEventData eventData)
    {
        isDown = true;
        lastIsDownTime = Time.time;
    }

    // ����ţ̌���ʱ���Զ����ô˷���
    public void OnPointerUp(PointerEventData eventData)
    {
        isDown = false;
    }

    // �����Ӱ�ť���뿪��ʱ���Զ����ô˷���
    public void OnPointerExit(PointerEventData eventData)
    {
        isDown = false;
    }





    // Update is called once per frame
    public void LeftWalk()
    {
        Debug.Log("��");
        float moveDir = Input.GetAxis("Horizontal");
        Vector2 playerVel = new Vector2(moveDir * Speed, myRigidbody.velocity.y);
        myRigidbody.velocity = playerVel;
    }


    public void RightWalk()
    {
        Debug.Log("��");
        float moveDir = Input.GetAxis("Horizontal");
        Vector2 playerVel = new Vector2(moveDir * Speed, myRigidbody.velocity.y);
        myRigidbody.velocity = playerVel;
    }

}
