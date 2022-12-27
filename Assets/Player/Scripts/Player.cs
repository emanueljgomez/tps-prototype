using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   
    [Header("Player movement")]
    [SerializeField] private float playerSpeed = 1.9f;
    
    [Header("Player animator and gravity controller")]
    [SerializeField] private CharacterController cC;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      playerMove();  
    }

    void playerMove()
    {
        float horizontal_axis = Input.GetAxisRaw("Horizontal");
        float vertical_axis = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(horizontal_axis, 0f, vertical_axis).normalized;

        if(direction.magnitude >= 0.1f) 
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            cC.Move(direction.normalized * playerSpeed * Time.deltaTime);
        }
        
    }

}
