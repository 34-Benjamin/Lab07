using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    private Animation thisAnimation;
    [SerializeField]
    private float _upwardForceMultiplier = 100f;
    public GameObject[] blocks;
    private int score;
    public Text scoretxt;
    
    
  
    void Start()
    {
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y <=2.5f)
        {
            thisAnimation.Play();
            Rigidbody rigidbody = GetComponent<Rigidbody>();
            rigidbody.velocity = Vector3.zero;
            rigidbody.AddForce(Vector3.up * _upwardForceMultiplier);

        }
        if (transform.position.y <= -4.5f)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("gameover");
        }
       

    }
    private void OnTriggerEnter(Collider collision)

    {
        if (collision.gameObject.tag == "obstacle")
        {
            score++;
            scoretxt.text = "Score :  " + score;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "obstacle")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("gameover");
        }
    }
  
}
