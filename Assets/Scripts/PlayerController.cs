using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float xRange = 15;
    public float zRange = 3;
    public Vector3 moveDirection;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        KeepPlayerInBounds();
        ThrowProjectile();
    }

    private void MovePlayer()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        moveDirection = new Vector3(horizontalInput, 0, verticalInput).normalized; // Calculate the movement direction after updating input values

        Vector3 movement = moveDirection * speed * Time.deltaTime; // Combine horizontal and vertical inputs and normalize the result

        transform.Translate(movement); // Move the player based on the combined input
    }

    private void KeepPlayerInBounds() //If the position in x is greater than or less than to the xRange then the players position is reset to the lock x position
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

        if (transform.position.z < 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        }
    }
    public void ThrowProjectile()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //Used to launch carrot with Space
        {
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        }
    }
}