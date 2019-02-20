using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatapultScript : MonoBehaviour {

    public float startSpeed = 0f;
    public GameObject catapultObject;
    public GameObject ballStartPoint;
    public GameObject ball;
    public Slider slider;
    public GameObject targetLineRight;
    public GameObject targetLineLeft;
    public GameObject particles;
    GameObject ps;

    void Start()
    {
        ps = Instantiate(particles, ballStartPoint.transform);
    }

    void FixedUpdate () {
        catapultObject.gameObject.transform.Rotate(0, 0, -startSpeed * Time.deltaTime * 10);
    }

    private void Update()
    {
        if (ballStartPoint.activeInHierarchy)
        {
            if (startSpeed > 0f)
            {
                targetLineRight.SetActive(true);
                targetLineLeft.SetActive(false);
            }
            if (startSpeed < 0f)
            {
                targetLineRight.SetActive(false);
                targetLineLeft.SetActive(true);
            }
            if (startSpeed == 0)
            {
                targetLineRight.SetActive(false);
                targetLineLeft.SetActive(false);
            }
        } else
        {
            targetLineRight.SetActive(false);
            targetLineLeft.SetActive(false);
        }
    }

    public void OnBallStart ()
    {
        if (ballStartPoint.activeInHierarchy && startSpeed != 0)
        {
            GameObject clone = Instantiate(ball, ballStartPoint.transform.position, ballStartPoint.gameObject.transform.rotation);
            clone.GetComponent<Rigidbody2D>().AddForce(-ballStartPoint.transform.right * startSpeed * 3);
            clone.transform.SetParent(gameObject.transform);
            ps.transform.SetParent(clone.transform);
            ballStartPoint.SetActive(false);
        }
    }

    public void OnSliderChanged ()
    {
        startSpeed = slider.value * 10;
    }

    public void OnReset ()
    {
        ps = Instantiate(particles, ballStartPoint.transform);
        ballStartPoint.SetActive(true);
    }
}
