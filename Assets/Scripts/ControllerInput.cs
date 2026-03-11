using UnityEngine;
using UnityEngine.InputSystem;

public class ControllerInput : MonoBehaviour
{
    public float speed = 5;
    public Vector2 movement;
    public Vector2 rotate;
    public AudioSource soundEffect;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //stick
        transform.position += (Vector3)movement * speed * Time.deltaTime;
        //mouse
        //transform.position = (Vector3)movement;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        rotate = context.ReadValue<Vector2>();
        Vector3 newRotate = transform.eulerAngles;
        newRotate.z += rotate.x;
        transform.eulerAngles = newRotate;
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        if (context.performed == true)
        {
            soundEffect.Play();
        }
    }

    public void OnPoint(InputAction.CallbackContext context)
    {
        movement = Camera.main.ScreenToWorldPoint(context.ReadValue<Vector2>());
    }

}
