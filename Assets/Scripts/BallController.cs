using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] private float ballSpeed = 2f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float groundCheckDistance = 1f;
    [SerializeField] private LayerMask groundLayer;

    private bool isGrounded;

    void Start()
    {
        Debug.Log("Calling the Start method");
    }

    void Update()
    {
        CheckGrounded();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    public void MoveBall(Vector2 input)
    {
        Vector3 inputXZPlane = new Vector3(input.x, 0f, input.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
        Debug.Log("Resultant Vector: " + input);
    }
    public void Jump()
    {
        if (isGrounded)
        {
            sphereRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            Debug.Log("Jumping!");
        }
    }
    private void CheckGrounded()
    {
        isGrounded = Physics.Raycast(
            transform.position,      
            Vector3.down,            
            groundCheckDistance,     
            groundLayer              
        );
    }
}
