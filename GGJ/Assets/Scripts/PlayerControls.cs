using UnityEngine;

public class PlayerControls : MonoBehaviour
{

    // Player adjustable speed
    [SerializeField] float speed;
    [SerializeField] float rotationSpeed;

    // Reference to Body Creation Script
    [SerializeField] RootBody bodyManager;

    // Delay For body spawn
    [SerializeField] float spawnTimerDelay = 0.12f;
    [SerializeField] float timer;

    /*
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float forwardForce = -700f;
    [SerializeField] float RotationForce = 500f;
    */


    int counter = 20;

    void start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
         float xInput = Input.GetAxis("Horizontal");
         float yInput = Input.GetAxis("Vertical");

         Vector2 movementDirection = new Vector2(xInput, yInput);
         float inputMagnitude = Mathf.Clamp01(movementDirection.magnitude);
         movementDirection.Normalize();

         transform.Translate(movementDirection * speed * inputMagnitude * Time.deltaTime, Space.World);

         if(movementDirection != Vector2.zero)
         {
             timer += Time.deltaTime;
             if (timer > spawnTimerDelay)
             {

                //bodyManager.CreateBody();
                timer = 0;
             }
             Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movementDirection);
             transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
         }

        /*
        if ( Input.GetKey(KeyCode.A))
        {
            ApplyRotation(RotationForce);
        }
        else if( Input.GetKey(KeyCode.D))
        {
            ApplyRotation(-RotationForce);
        }


        counter++;
        if (counter <= 300)
        {
            Spurt();
        }
        else if (counter > 600)
        {
            counter = 0;
        }
        */
    }

   
    /*

    void ApplyRotation(float rotationThisFrame)
    {
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
    }

    void Spurt()
    {
        rb.AddRelativeForce(new Vector2(0f, forwardForce * Time.deltaTime), ForceMode2D.Impulse);
    }

    */
}