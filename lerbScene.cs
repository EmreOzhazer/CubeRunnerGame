using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerbScene : MonoBehaviour
{
    public GameObject TestGameObject;

    public bool isGoingRight = false;

    public Transform startPoint;
    public Transform endPoint;
    public float timeMultiplier = 1f;
    public float time = 0f;

    public AnimationCurve myLerpCurve;

    private Vector3 currentPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGoingRight)
        {
            time += (Time.deltaTime / timeMultiplier);
            currentPosition = Vector3.Lerp(startPoint.position, endPoint.position, myLerpCurve.Evaluate(time));

            TestGameObject.transform.position = currentPosition;


            if(time >= 1f)
            {
                isGoingRight = true;
                time = 1f;
            }
        }

            else
        {
            time -= (Time.deltaTime / timeMultiplier);
            currentPosition = Vector3.Lerp(startPoint.position, endPoint.position, myLerpCurve.Evaluate(time));

            TestGameObject.transform.position = currentPosition;


            if (time <= 0f)
            {
                isGoingRight = false;
                time = 0f;
            }

        }
    }



}
