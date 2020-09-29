using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodLerp : MonoBehaviour
{
    public GameObject food;

    private Vector3 startPos;
    private Vector3 endPos;

    public Vector3 offset;

    private float lerpTime = 2;
    private float currentLerpTime = 0;

    private bool keyHit = false;

    // Start is called before the first frame update
    void Start()
    {
        startPos = food.transform.position;
        endPos = offset;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            keyHit = true;
        }
        if (keyHit == true)
        {
            currentLerpTime += Time.deltaTime;
            if (currentLerpTime >= lerpTime)
            {
                currentLerpTime = lerpTime;
            }
            //transform.position = offset;
            float Perc = currentLerpTime/lerpTime;
            food.transform.position = Vector3.Lerp(startPos, endPos, Perc);

            //FindObjectOfType<GameManager>().EndGame();

        }
    }
}
