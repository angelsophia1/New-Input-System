using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public InputMaster controls;

    void Awake()
    {
        controls.Player.Shoot.performed += _ => Shoot();
        controls.Player.Movement.performed += ctx => Move(ctx.ReadValue<Vector2>());
    }

    void Move(Vector2 direction)
    {
        Debug.Log("Player wants to move." + direction);
    }

    void Shoot()
    {
        Debug.Log("We just shot!");
    }
    private void OnEnable()
    {
        controls.Enable();
    }
    private void OnDisable()
    {
        controls.Disable();
    }

    //private void Update()
    //{
    //    Keyboard kb = InputSystem.GetDevice<Keyboard>();
    //    if (kb.spaceKey.wasPressedThisFrame)
    //    {
    //        Debug.Log("Someone pressed spacekey.");
    //    }
    //}
}
