using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{

    public float moveSpeed = 600f;
    public float Timer = 0f;
    static float highTimer = 0f;

    bool updateTimer = true;

    bool Left = false;
    bool Right = false;


    // Update is called once per frame
    void Update()
    {
        Move();
        if (updateTimer)
        {
            Timer += Time.deltaTime;
        }
    }


    void Move()
    {
        if(Input.GetKeyDown (KeyCode.A) || Left)
        {
            transform.RotateAround(Vector3.zero, Vector3.forward, Time.fixedDeltaTime * moveSpeed);
        }
        if (Input.GetKeyDown(KeyCode.D) || Right)
        {
            transform.RotateAround(Vector3.zero, Vector3.forward, Time.fixedDeltaTime * -moveSpeed);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        updateTimer = false;
        SceneManager.LoadScene(2);
        Debug.Log(Timer);
        PlayerPrefs.SetFloat("Score", Timer);
        if (Timer>highTimer)
        {
            highTimer = Timer;
        }
        PlayerPrefs.SetFloat("High Score", highTimer);
    }

    public void LeftButtonDown()
    {
        Left = true;
    }
    public void LeftButtonUp()
    {
        Left = false;
    }
    public void RightButtonDown()
    {
        Right = true;
    }
    public void RightButtonUp()
    {
        Right = false;
    }
}
