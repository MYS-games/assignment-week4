using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballDetecter : MonoBehaviour
{
    private GameObject topBorder;
    private GameObject bottomBorder;
    private GameObject basket;
    private ScoreHandler scoreHandler;

    // Start is called before the first frame update
    void Start()
    {
        topBorder = GameObject.Find("TopInside");
        bottomBorder = GameObject.Find("BottomInside");
        basket = GameObject.Find("Basket");
        scoreHandler = basket.GetComponent<ScoreHandler>();
    }

    // Update is called once per frame
    void Update()
    {
       if (transform.position.y <= topBorder.transform.position.y && transform.position.y >= bottomBorder.transform.position.y)
        {   
            if (Input.GetKeyDown(KeyCode.Z) && transform.name == "red")
            {
                // score++
                scoreHandler.addPointToScore();
                Destroy(this.gameObject);
            }
            if (Input.GetKeyDown(KeyCode.X) && transform.name == "blue")
            {
                // score++
                scoreHandler.addPointToScore();
                Destroy(this.gameObject);

            }
            if (Input.GetKeyDown(KeyCode.C) && transform.name == "yellow")
            {
                // score++
                scoreHandler.addPointToScore();
                Destroy(this.gameObject);

            }

        }
    }
}
