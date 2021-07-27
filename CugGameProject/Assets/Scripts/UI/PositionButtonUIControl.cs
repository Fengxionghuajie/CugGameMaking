using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


// 继承：按下，抬起和离开的三个接口
public class PositionButtonUIControl:MonoBehaviour,IPointerDownHandler,IPointerUpHandler,IPointerExitHandler
{

    // 延迟时间
    private float delay = 0.2f;
    // 按钮是否是按下状态
    private bool isDown = false;
    // 按钮最后一次是被按住状态时候的时间
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
        // 如果按钮是被按下状态
        if (isDown)
        {
            // 当前时间 -  按钮最后一次被按下的时间 > 延迟时间0.2秒
            if (Time.time - lastIsDownTime > delay)
            {
                // 触发长按方法
                Debug.Log("长按");
                // 记录按钮最后一次被按下的时间
                lastIsDownTime = Time.time;
            }
        }

    }


    // 当按钮被按下后系统自动调用此方法
    public void OnPointerDown(PointerEventData eventData)
    {
        isDown = true;
        lastIsDownTime = Time.time;
    }

    // 当按钮抬起的时候自动调用此方法
    public void OnPointerUp(PointerEventData eventData)
    {
        isDown = false;
    }

    // 当鼠标从按钮上离开的时候自动调用此方法
    public void OnPointerExit(PointerEventData eventData)
    {
        isDown = false;
    }





    // Update is called once per frame
    public void LeftWalk()
    {
        Debug.Log("左");
        float moveDir = Input.GetAxis("Horizontal");
        Vector2 playerVel = new Vector2(moveDir * Speed, myRigidbody.velocity.y);
        myRigidbody.velocity = playerVel;
    }


    public void RightWalk()
    {
        Debug.Log("右");
        float moveDir = Input.GetAxis("Horizontal");
        Vector2 playerVel = new Vector2(moveDir * Speed, myRigidbody.velocity.y);
        myRigidbody.velocity = playerVel;
    }

}
