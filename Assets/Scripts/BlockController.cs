using UnityEngine;
using System.Collections;

public class BlockController : MonoBehaviour
{
    static bool isGoUp = false;
    static bool isGoDown = false;
    static bool isGoRight = false;
    static bool isGoLeft = false;

    enum whereGo
    {
        GoUp = 1,
        GoDown,
        GoRight,
        GoLeft
    }

    public float speed;
    whereGo gowhere;
    public GameObject ball;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Ball")
        {
            collider.GetComponent<Rigidbody2D>().isKinematic = true;

            isGoDown = false;
            isGoUp = false;
            isGoLeft = false;
            isGoRight = false;

            if (gameObject.name.Contains("Down"))
            {
                isGoDown = true;
                gowhere = whereGo.GoDown;
            }


            if (gameObject.name.Contains("Up"))
            {
                isGoUp = true;
                gowhere = whereGo.GoUp;
            }


            if (gameObject.name.Contains("Right"))
            {
                isGoRight = true;
                gowhere = whereGo.GoRight;
            }


            if (gameObject.name.Contains("Left"))
            {
                gowhere = whereGo.GoLeft;
                isGoLeft = true;
            }
        }
    }

    void Update()
    {
        switch (gowhere)
        {
            case whereGo.GoDown:
                if(isGoDown)
                    ball.transform.position = new Vector2(ball.transform.position.x, ball.transform.position.y - speed * Time.deltaTime);
                break;

            case whereGo.GoUp:
                if(isGoUp)
                    ball.transform.position = new Vector2(ball.transform.position.x, ball.transform.position.y + speed * Time.deltaTime);
                break;

            case whereGo.GoRight:
                if(isGoRight)
                    ball.transform.position = new Vector2(ball.transform.position.x + speed * Time.deltaTime , ball.transform.position.y);
                break;

            case whereGo.GoLeft:
                if(isGoLeft)
                    ball.transform.position = new Vector2(ball.transform.position.x - speed * Time.deltaTime, ball.transform.position.y);
                break;
        }
    }
}
