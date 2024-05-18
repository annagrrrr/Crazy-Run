using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomTouchInput : MonoBehaviour
{
    //public Rigidbody rb;
    //public float speed;

    private float startTimer;
    Vector2 secondTouchPos = new Vector2(150, 150);
    private void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }
    void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if ((touch.deltaPosition.x > 100) && (Mathf.Abs(touch.deltaPosition.y) <= 50))
            {
                Debug.Log("свайп направо");
            }

        }
        if (Input.touchCount == 2)
        {
            Touch touch1 = Input.GetTouch(0);
            Touch touch2 = Input.GetTouch(1);

            Vector3 touch1vector = new Vector3(touch1.position.x, 0f, touch1.position.y);
            Vector3 touch2vector = new Vector3(touch2.position.x, 0f, touch2.position.y);

            Vector3 newtouch1vector = new Vector3(touch1.deltaPosition.x, 0f, touch1.deltaPosition.y);
            Vector3 newtouch2vector = new Vector3(touch2.deltaPosition.x, 0f, touch2.deltaPosition.y);

            Vector3 prevtouch1vector = touch1vector-newtouch1vector;
            Vector3 prevtouch2vector = touch2vector-newtouch2vector;
            if (Vector3.Distance(prevtouch1vector, prevtouch2vector) > (Vector3.Distance(touch1vector, touch2vector)))
            {
                Debug.Log("увеличение рассто€ни€");

            }
            else
            {
                Debug.Log("уменьшение расстро€ни€");
            }
        }

    }
}
