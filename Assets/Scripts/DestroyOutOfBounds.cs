using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    //public Transform[] spawnTransformsLeft; //Used for Challenge but not sure how to implement
    //public Transform[] spawnTransformsRight;
    //public GameObject animalCow;
    //public GameObject animalMoose;
    //public GameObject animalFox;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DestroyObjects();
    }

    private void DestroyObjects()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        if (transform.position.z < -topBound)
        {
            Destroy(gameObject);
        }
    }
    //public int GetRandomNumberLeft() //Used for Challenge but not sure how to implement
    //{
    //    int randomNumber = Random.Range(0, spawnTransformsLeft.Length);
    //    return randomNumber;
    //}
    //public int GetRandomNumberRight()
    //{
    //    int randomNumber = Random.Range(0, spawnTransformsRight.Length);
    //    return randomNumber;
    //}
}
