using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public Rigidbody sphereRigidbody;
    public float ballSpeed = 2f;
    void Start()
    {
        Debug.Log("Calling the Start method");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = Vector2.zero;

        if(Input.GetKey(KeyCode.W))
        {
            inputVector += Vector2.up;
        }

        if(Input.GetKey(KeyCode.S))
        {
            inputVector += Vector2.down;
        }

        if(Input.GetKey(KeyCode.D))
        {
            inputVector += Vector2.right;
        }

        if(Input.GetKey(KeyCode.A))
        {
            inputVector += Vector2.left;
        }
        
        Vector3 inputXZPlane = new Vector3(inputVector.x, 0, inputVector.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
        Debug.Log("Resultant Vector: " + inputVector);
    }
}
