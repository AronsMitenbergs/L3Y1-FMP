using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public bool grounded = false;


    [Header("Settings")]
    public float ChargedPower = 0;
    public float upForce = 90f;
    public float forwardForce = 90f;
    public Vector3 jumpDirection = Vector3.up;

    public float yRot;

    private bool jumpNow = false;
    private Rigidbody rBody;
    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space") && grounded)
        {
            ChargedPower += Time.deltaTime * 3;
        }

        if (Input.GetKeyUp("space"))
        {
            jumpNow = true;
        }

        if (ChargedPower >= (5))
        {
            jumpNow = true;
        }

        yRot = transform.localRotation.eulerAngles.y;
        
    }


    void FixedUpdate()
    {
        if (jumpNow == (true))
        {
            rBody.AddForce(transform.forward * ChargedPower * forwardForce);
            rBody.AddForce(transform.up * ChargedPower * upForce);
            jumpNow = false;
            ChargedPower = 0;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        grounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        grounded = false;
    }
}
