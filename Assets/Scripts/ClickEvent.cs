using UnityEngine;
using System.Collections;

public class ClickEvent : MonoBehaviour
{
    public GameObject ball;

    void Start()
    {
        ball.GetComponent<Rigidbody2D>().isKinematic = true;
    }

    public void DoClick()
    {
        ball.GetComponent<Rigidbody2D>().isKinematic = false;
    }
}
