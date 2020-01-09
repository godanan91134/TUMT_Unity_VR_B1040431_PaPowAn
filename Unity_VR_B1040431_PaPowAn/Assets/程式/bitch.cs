using UnityEngine;
using UnityEngine.UI;

public class bitch : MonoBehaviour
{
    public GameObject obj;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.name == "Girl")
        {
            print("123");
            obj.SetActive(true);
        }
    }
}
