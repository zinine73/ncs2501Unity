using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class KeyInput : MonoBehaviour
{
    public Image graphic;
    public Sprite standard, downgfx, upgfx, heldgfx;
    public TextMeshProUGUI boolDisplay1, boolDisplay2, boolDisplay3;
    
    void Start()
    {
        graphic.sprite = standard;
    }

    void Update()
    {
        bool down = Input.GetButtonDown("Fire1");
        bool held = Input.GetButton("Fire1");
        bool up = Input.GetButtonUp("Fire1");
        if (down)
        {
            graphic.sprite = downgfx;
        }
        else if (held)
        {
            graphic.sprite = heldgfx;
        }
        else if (up)
        {
            graphic.sprite = upgfx;
        }
        else
        {
            graphic.sprite = standard;
        }
        boolDisplay1.text = " " + down;
        boolDisplay2.text = " " + held;
        boolDisplay3.text = " " + up;
    }
}
