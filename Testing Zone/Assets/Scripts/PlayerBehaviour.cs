using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    private Vector2 _input = Vector2.zero;

    // Update is called once per frame
    void Update()
    {
        if (_input.x != 0 || _input.y != 0)
        {
            transform.position += (Vector3) _input * (speed * Time.deltaTime);
        }
    }

    public void SetDirection(InputAction.CallbackContext context)
    {
        _input = context.ReadValue<Vector2>();
    }
}
