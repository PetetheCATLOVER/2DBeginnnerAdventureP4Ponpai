using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    //Varibles related to player character movement 
    public InputAction InputAction;
    Rigidbody2D riggidbody2d;
    Vector2 move;
    public float speed = 3.0f;

    // Varibles relatted to temporary invincibility
    public float timeInvincible = 2.0f;
    bool isInvincible;
    float damageCooldown;
    
   // Varibles relatted to the health system
    public int maxHealth = 5;
    public int health { get { return currentHealth; } }
    int currentHealth = 5;


    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
         vertical = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    { 
        Vector2 position = transform.position;
        position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        position.y = position.y + 3.0f * vertical * Time.deltaTime;

        rigidbody2d.MovePosition(position);
    }
     
     public void ChangeHealth(int amount)
    { 
            currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
            Debug.Log(currentHealth + "/" + maxHealth);
    }
}
