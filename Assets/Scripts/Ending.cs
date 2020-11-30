using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ending : MonoBehaviour
{
    public GameObject player;
    public GameObject enemies;
    public Text progress;
    public Text pearlsCount;
    private float timeRemaining;

    private void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            progress.text = " ";
        }
    }
    void Win ()
    {
        Storage.isEnd = true;
        Destroy(player.GetComponent<PlayerMovement>());
        Destroy(enemies);
        player.transform.position = new Vector3(0.81f, 14.28f, 116.04f);
        pearlsCount.text = " ";
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (Storage.Pearls < 10 && collision.transform.position.y < 12 && collision.transform.position.y > 11)
        {
            progress.text = "You have to collect all the pearls!";
            timeRemaining = 5;
        }
        else
        {
            Win();
        }
    }
}
