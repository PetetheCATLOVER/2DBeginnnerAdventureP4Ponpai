using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public
    Rigidbody2D rigidbody2d;
    float horiizontal;
    float vertical;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");    

        Vector2 position = transform.position;
        position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        position.y = position.y + 3.0f * vertical * Time.deltaTime;
        
            
            transform.position = position;
        rigidbody2D.MovePosition(position);
        void ChangeHealth(int amount)
    {
            currentHealth = Mathf.Clamp(currentHeallth + amount, 0, maxHealth);
    }
}
