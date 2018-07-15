using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour
{
    public GameObject plataforma;
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("Box") || coll.gameObject.CompareTag("Red") || coll.gameObject.CompareTag("Blue"))
            plataforma.SetActive(false);
    }

}