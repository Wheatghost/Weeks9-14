using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{
    public AudioSource StepSfx;
    public AudioSource SwingSfx;
    public List<AudioClip> clips;
    public int randomSound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        randomSound = (int)Random.Range(0,clips.Count);
    }

    public void Footstep()
    {
        //Debug.Log("Step");
        StepSfx.clip = clips[randomSound];
        StepSfx.Play();
    }

    public void Swing()
    {
        SwingSfx.Play();
    }
}
