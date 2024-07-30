using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sadovnikov : MonoBehaviour
{
    public Camera cam;
    public Text carmapoints;
    private int points = 0;
    public AudioClip[] phrase;
    public AudioSource a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnMouseDown() {
        Debug.Log(Random.Range(0, 3));
        points++;
        if (points % 20 == 0) {
            a.clip = phrase[Random.Range(0, 3)];
            a.Play();
        }
        carmapoints.text = "¡¿ÀÀ€  ¿–Ã€: " +points;
    }
}
