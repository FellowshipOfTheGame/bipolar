using UnityEngine;
using System.Collections;

public class HoldButtonScript : MonoBehaviour
{
    public GameObject plataforma;
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("Box") || coll.gameObject.CompareTag("Red") || coll.gameObject.CompareTag("Blue"))
            plataforma.SetActive(false);
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("Box") || coll.gameObject.CompareTag("Red") || coll.gameObject.CompareTag("Blue"))
            plataforma.SetActive(true);
    }

}