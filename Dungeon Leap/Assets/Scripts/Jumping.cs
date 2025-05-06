using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jumppowermeter : MonoBehaviour
{
    private Image Jumping;
    public float ChargedPower = 5f;
    NewBehaviourScript1 Player;


    void Start()
    {
        Jumping = GetComponent<Image>();
        Player = FindObjectOfType<NewBehaviourScript1>();
    }

    // Update is called once per frame
    void Update()
    {
        ChargedPower = Player.ChargedPower;
        Jumping.fillAmount = ChargedPower / 5;

    }
    void FixedUpdate()
    {

    }
}