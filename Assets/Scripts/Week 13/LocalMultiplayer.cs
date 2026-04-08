using UnityEngine;
using UnityEngine.InputSystem;

public class LocalMultiplayer : MonoBehaviour
{
    public LocalMultiplayerManager manager;
    public PlayerInput playerInput;
    public Vector2 movementInput;
    public float speed = 5;
    public float health = 5;
    public bool dead = false;
    public SpriteRenderer sr;
    public Color color;

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)movementInput * speed * Time.deltaTime;
        if(health <=0 )
        {
            dead = true;
            color.a = 0.5f;
            sr.color = color;
        }
        else
        {
            dead = false;
        }
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        if (dead == false)
        {
            movementInput = context.ReadValue<Vector2>();
        }
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        if (dead == false)
        {
            if (context.performed)
            {
                Debug.Log("Player " + playerInput.playerIndex + ": Attacking");
                manager.PlayerAttacking(playerInput);
            }
        }
    }
    public void takeDamage()
    {
        if (dead == false)
        {
            health--;
        }
    }
}
