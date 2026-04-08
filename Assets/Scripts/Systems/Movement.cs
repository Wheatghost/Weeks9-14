using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    //Setting speed, and creating the controller variables
    public float speed = 5;
    public Vector2 movement;

    public FishCode fish;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //use the value of the movement to move the player
        transform.position += (Vector3)movement * speed * Time.deltaTime;
    }

    //Movement
    public void OnMove(InputAction.CallbackContext context)
    {
        //read the movement key but also ignore any vertical movement
        movement = context.ReadValue<Vector2>();
        movement.y = 0;

    }

    //Tossing Fish
    public void OnAttack(InputAction.CallbackContext context)
    {
        fish.Toss();
    }

    //Keeping Fish
    public void OnInteract(InputAction.CallbackContext context)
    {
        fish.Keep();
    }
}
