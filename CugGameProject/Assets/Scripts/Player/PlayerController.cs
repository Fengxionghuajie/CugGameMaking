using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    [Header("Singleton mode")]
    public static PlayerController instance;//静态变量，单例模式


    [Header("Player operation")]
    public static float runSpeed;
    public float jumpSpeed;
    public float climbSpeed;

    private Rigidbody2D myRigidbody;
    private BoxCollider2D myFeet;
    private CapsuleCollider2D mybody;
    private float playerGravity;
    
    //public Animator myAnim;




    //单例模式
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            if (instance != this)
            {
                Destroy(gameObject);
            }
        }

        DontDestroyOnLoad(gameObject);
    }




    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        //myAnim = GetComponent<Animator>();
        myFeet = GetComponent<BoxCollider2D>();
        mybody = GetComponent<CapsuleCollider2D>();
        playerGravity = myRigidbody.gravityScale;
    }

    // Update is called once per frame
    void Update()
    {
        //Jump();
        Run();
    }




    void Run()
    {
        float moveDir = Input.GetAxis("Horizontal");
        Vector2 playerVel = new Vector2(moveDir * runSpeed, myRigidbody.velocity.y);
        myRigidbody.velocity = playerVel;
        //bool playerHasXAxisSpeed = Mathf.Abs(myRigidbody.velocity.x) > Mathf.Epsilon;//如果水平速度大于0，布尔值为true
        //myAnim.SetBool("Run", playerHasXAxisSpeed);
    }

    //void Jump()
    //{
    //    if (Input.GetButtonDown("Jump"))
    //    {

    //        if (isGround)
    //        {
    //            myAnim.SetInteger("JumpState", 1);
    //            Vector2 jumpVel = new Vector2(0.0f, jumpSpeed);
    //            myRigidbody.velocity = Vector2.up * jumpVel;
    //            canDoubleJump = true;
    //        }
    //        else
    //        {
    //            if (canDoubleJump)
    //            {
    //                myAnim.SetInteger("JumpState", 2);
    //                Vector2 doubleJumpVel = new Vector2(0.0f, doulbJumpSpeed);
    //                myRigidbody.velocity = Vector2.up * doubleJumpVel;
    //                canDoubleJump = false;
    //            }
    //        }
    //    }
    //}



}
