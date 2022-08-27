using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int randomNum;
    public int i = 3;
    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        randomNum = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i.ToString());
        FeatureHide();
    }

    private void FeatureHide()
    {
        if (gameObject.CompareTag("Red") && i == 100)
            gameObject.SetActive(false);
        if (gameObject.CompareTag("Blue") && i == randomNum)
                gameObject.GetComponent<Renderer>().enabled = false;
    }
}
