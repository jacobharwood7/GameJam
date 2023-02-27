using UnityEngine;

public class RootBody : MonoBehaviour
{

    [SerializeField] GameObject body;
    [SerializeField] GameObject head;
    [SerializeField] Transform headTransform;

    public float delay = 0.05f;
    float timer;

    float headX;
    float headY;
    float headZ;

    void Update()
    {

        timer += Time.deltaTime;
    }

    /*public void SetBody()
    {
       
        headX = head.transform.position.x;
        headY = head.transform.position.y;
        headZ = head.transform.position.z;
        
        if (timer > delay*2)
        {
            CreateBody(headX,headY,headZ);
            timer = 0;
        }
    }*/

    public void CreateBody()
    {
        Instantiate(body, new Vector3(head.transform.position.x,
        head.transform.position.y,
        head.transform.position.z),
        Quaternion.Euler(0f, 0f, headTransform.eulerAngles.z));
    }
 
}
