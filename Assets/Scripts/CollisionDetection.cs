using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public int hunger = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FoodItem")) //this bit is looking for the tag
        {
            FeedAnimal(other.GetComponent<FoodItem>().feedAmount);
        }
    }

    public void FeedAnimal(int feedAmount)
    {
        if (hunger > 0)
        {
            hunger -= feedAmount;
        }

        if (hunger <= 0)
        {
            HideAnimal();
        }
    }

    public void HideAnimal()
    {
        Destroy(gameObject);

    }
}
