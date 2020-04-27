using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoretTextScript : MonoBehaviour
{
    Text text;
    private static int points;


    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        points = ShootableObject.points;
        text.text = "Points: " + points.ToString();
    }
}
