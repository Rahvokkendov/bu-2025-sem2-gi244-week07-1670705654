using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 5f;
    public float gravityMultiplier = 30f;
    public bool isGameOver;
    private Rigidbody rb;
    private InputAction jumpAction;
    private bool isGrounded = false;
    void Awake()
    {
        isGameOver = false;
        rb = GetComponent<Rigidbody>();
        jumpAction = InputSystem.actions.FindAction("Jump");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Physics.gravity *= gravityMultiplier;
    }

    // Update is called once per frame
    void Update()
    {

        if (jumpAction.triggered && isGrounded == true && isGameOver == false)
        {
            rb.AddForce(jumpForce * Vector3.up, ForceMode.Impulse);
            isGrounded = false ;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            isGameOver = true;
            Debug.Log("Game Ovah");
            //Time.timeScale = 0f;
        }
        
    }
}
