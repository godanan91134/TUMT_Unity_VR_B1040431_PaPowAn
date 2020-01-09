using UnityEngine;

public class player : MonoBehaviour
{


    public int count;
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "武器")
        {
            count += 1;
        }
    }
}
