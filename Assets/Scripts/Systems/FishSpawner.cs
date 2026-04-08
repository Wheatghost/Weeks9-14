using JetBrains.Annotations;
using System.Collections;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    //Different possible fish spawns
    public GameObject goodFish;
    public GameObject badFish;

    //Different possible locations for fish spawns
    public Transform position;

    //Possible fish types
    public float choice;
    public bool good;

    //Timer for fish spawns
    public float timer;

    //Checking if a fish is allowed to spawn
    public bool ready = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (ready == true)
        {
            StartCoroutine(SpawnFish());
        }
    }

    public void RandomFish() 
    {
        choice = Random.Range(0, 2);
        if (choice == 0)
        {
            good = true;
        }
        else
        {
            good = false;
        }
    }

    public void FishUpdate()
    {
        ready = !ready;
    }

    IEnumerator SpawnFish()
    {
        //Spawn a fish 
        timer += Time.deltaTime;
        if (timer >= 5)
        {
            timer = 0;
            if (good == true)
            {
                Destroy(goodFish);
                Instantiate(goodFish, position);
            }
            if (good == false)
            {
                Destroy(badFish);
                Instantiate(badFish, position);
            }
            RandomFish();
            FishUpdate();
        }
        yield return null;
    }
        
}
