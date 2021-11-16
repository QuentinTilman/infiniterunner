using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{


    public float speed = 10;
    public float jumpForce = 10;
    public Rigidbody rb;
    float horizontalInput;
    private float horizontalMultiplier = 2;
    public Animator animator;
    void Start()
    {

    }

    private void FixedUpdate() {
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position+forwardMove + horizontalMove);
    }

    void Update()
    {
       horizontalInput = Input.GetAxis("Horizontal");
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "lethal")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("MainMenu");
            //animator for losing
        }
        else if(other.gameObject.tag == "coin"){
            Destroy(other.gameObject);
        }
        else
        {
            //animator for falling 
        }
    }

    void stopGameSession()
    {
        //show recap session
        SceneManager.LoadScene("MainMenu");
    }

}
