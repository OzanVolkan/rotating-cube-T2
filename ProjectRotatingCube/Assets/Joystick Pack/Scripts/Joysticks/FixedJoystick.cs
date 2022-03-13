using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FixedJoystick : Joystick
{
    [SerializeField] public Rigidbody rb_cube;
    public bool pressed = false;
    public int force = 1000;
    protected override void Start()
    {
        base.Start();
        background.gameObject.SetActive(false);
    }

    public override void OnPointerDown(PointerEventData eventData)
    {
        background.anchoredPosition = ScreenPointToAnchoredPosition(eventData.position);
        background.gameObject.SetActive(true);
        base.OnPointerDown(eventData);
        pressed = true;

    }

    private void Update()
    {
        if (pressed)
        {
            //rb_cube.AddForce(0,0, force*Time.deltaTime);
        }
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        background.gameObject.SetActive(false);
        base.OnPointerUp(eventData);
        pressed = false;
    }
}