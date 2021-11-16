using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainMovement : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 2;
    public Rigidbody rb;
    void FixedUpdate() {
         Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
         rb.MovePosition(rb.position - forwardMove);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
