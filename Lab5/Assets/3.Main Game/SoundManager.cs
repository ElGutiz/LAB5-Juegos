using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource audio1;
    // Start is called before the first frame update
    void Start()
    {
        audio1.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Button1_Sound()
    {
        audio1.clip = Resources.Load<AudioClip>("buttonSound");
        audio1.Play();
    }
}
