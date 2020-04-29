using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameCompletedMenu : MonoBehaviour
{
    public GameObject GameFinishedMenu;
    public AudioSource Song2D;
    public int final_counter;

    // Start is called before the first frame update
    void Start()
    {
        Song2D.GetComponent<AudioSource>();
        final_counter = ShootableObject.points;
    }

    // Update is called once per frame
    void Update()
    {
        if(final_counter == 6)
        {
            GameFinishedMenu.SetActive(true);
            Song2D.Stop();
        }
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
