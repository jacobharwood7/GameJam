using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField] GameObject Player;

    [SerializeField] float xRange = 155f;
    [SerializeField] float yRange = 90f;


    // Update is called once per frame
    void Update()
    {
        float clampedXPos = Mathf.Clamp(Player.transform.position.x, -xRange, xRange);

        float clampedYPos = Mathf.Clamp(Player.transform.position.y, -yRange, yRange);

        transform.position = new Vector3(clampedXPos, clampedYPos, 0f)+ new Vector3(0f,0f,1f);
    }
}
