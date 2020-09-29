using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLerp : MonoBehaviour
{
    public GameObject mainCam;

    private Vector3 startPos;
    private Vector3 endPos;

    private Vector3 startAngle;
    private Vector3 endAngle;

    public Vector3 offset;
    public Vector3 newrot;

    private float lerpTime = 3;
    private float currentLerpTime = 0;

    private bool keyHit = false;

    public GameObject gameFeedUI;
    public GameObject gameTitleUI;

    // Start is called before the first frame update
    void Start()
    {
        startPos = mainCam.transform.position;
        endPos = offset;

        startAngle = mainCam.transform.eulerAngles;
        endAngle = newrot;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
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
            float Perc = currentLerpTime / lerpTime;
            mainCam.transform.position = Vector3.Lerp(startPos, endPos, Perc);
            mainCam.transform.eulerAngles = Vector3.Lerp(startAngle, endAngle, Perc);

            gameFeedUI.SetActive(true);
            gameTitleUI.SetActive(false);
        }
    }
}
