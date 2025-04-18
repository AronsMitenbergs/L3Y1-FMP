using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{

    public bool grounded = false;
    public float groundCheckDistance;
    private float bufferCheckDistance = 0.1f;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        groundCheckDistance = (GetComponent<CapsuleCollider>().height / 2) + bufferCheckDistance;

        RaycastHit hit;
        if(Physics.Raycast(transform.position, -transform.up, out hit, groundCheckDistance))
        {
            grounded = true;
        }
        else
        {
            grounded = false;
        }
    }
}
