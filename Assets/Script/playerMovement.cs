using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    float speed = 7.5f;

    float horizontalMove = 0f;
    bool jump = false;
    public bool crouch = false;

    public Animator playerAnim;
    Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();
  

    }

    // Update is called once per frame
    void Update()
    {

        if (controller.m_Grounded)
        {
            playerAnim.SetBool("grounded", true);
        }
        else
        {
            playerAnim.SetBool("grounded", false);
        }

        horizontalMove = Input.GetAxis("Horizontal") * speed;
        playerAnim.SetFloat("speed", Mathf.Abs(horizontalMove));
   
       
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetButtonDown("Crouch") && controller.m_Grounded)
        {
            crouch = true;          
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }


    public void OnCrouchEvent(bool crouching)
    {
        playerAnim.SetBool("crouch", crouching);
    }

    public void OnLandEvent()
    {
        controller.m_AirControl = true;
        playerAnim.SetBool("Attack-DownThrust-Air",false);
        player.down = false;
    }
}
