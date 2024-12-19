using UnityEngine;

public class EnemyMoving : MonoBehaviour
{
    void FixedUpdate()
    {
        if (transform.position.x < 5)
            transform.position = new Vector3(transform.position.x + 0.2f, -4f, 0f);

        if (transform.position.x >= 5 && transform.position.x < 13)
            transform.position = new Vector3(transform.position.x + 0.2f, Mathf.Log(transform.position.x - 4, 20) * (-Mathf.Pow(transform.position.x - 13, 2) * 0.06f + 4) - 4, transform.position.z);
            
        if (transform.position.x >= 13)
            transform.position = new Vector3(transform.position.x + 0.2f, transform.position.y, 0f);

    }
}
