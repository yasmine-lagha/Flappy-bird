using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BirdScript : MonoBehaviour
{
    int score = 0;
    Rigidbody2D rbd2d;
    public float speed = 5f;
    [SerializeField]
    private float flapForce = 20f;
    void Start()
    {
        Time.timeScale = 0;
        rbd2d = GetComponent<Rigidbody2D>();
        rbd2d.velocity = Vector2.right * speed * Time.deltaTime;

    }
     void Update ()
    {
        if (Input.GetMouseButtonDown(0) && !isDead )
        {
            rbd2d.velocity = Vector2.right * speed * Time.deltaTime;
            rbd2d.AddForce(Vector2.up * flapForce); 

        }
    }
    bool isDead;
    public GameObject ReplayButton; 
    void OnCollisionEnter2D(Collision2D col)
    {
        isDead = true;
        rbd2d.velocity = Vector2.zero;
        ReplayButton.SetActive(true);
        GetComponent<Animator>().SetBool("isDead", true);
    }
      public void Replay() { 
        SceneManager.LoadScene(0);
         }
    
     public void UnFreeze ()
    {
        Time.timeScale = 1;
    }
    public Text scoreText;
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag== "Score")
        {
            score++;
            UnityEngine.Debug.Log(score);
            scoreText.text = score.ToString();
        }  
    }
}



