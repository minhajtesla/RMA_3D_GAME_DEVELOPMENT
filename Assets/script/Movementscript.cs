using UnityEngine;

public class Movementscript : MonoBehaviour
{
    [Header("Movement variable")]
    public float moveSpeed;
    public float walkSpeed = 2f;
    public float runSpeed = 5f;
    public float jumpForce = 5f;


    public Rigidbody rb;
    public Transform Camera;


    [Header("Ground Check")]
    public bool isGrounded;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    private float verticalVelocity;

    private void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);


    }
    private void FixedUpdate()
    {
        movement();
        crouching();
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            verticalVelocity = jumpForce;
        }
    }


    void movement()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Debug.Log("Horizontal: " + h + " Vertical: " + v);

        Vector3 inputdirection = new Vector3(h, 0, v).normalized;
        Vector3 move = Vector3.zero;
        if (inputdirection.magnitude > .1f)
        {
            float targetAngle = Mathf.Atan2(inputdirection.x, inputdirection.z) * Mathf.Rad2Deg + Camera.transform.eulerAngles.y;
            move = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward * walkSpeed;
            transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);
        }
        verticalVelocity -= 9.81f * Time.deltaTime;

        if (isGrounded && verticalVelocity < 0)
        {
            verticalVelocity = -2f;
        }

        Vector3 finalvelocity = move + Vector3.up * verticalVelocity;
        rb.velocity = finalvelocity;

    }

    void crouching()
    {
        if(Input.GetKey(KeyCode.C))
        {
            transform.localScale = new Vector3(1, 0.5f, 1);
            //crouch
        }
        else 
        {
            transform.localScale = new Vector3(1, 1, 1);
            //stand up
        }
    }


}
