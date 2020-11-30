using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchPearl : MonoBehaviour
{
     // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            collider.gameObject.GetComponent<Player>().CollectPearls();
            Object.Destroy(gameObject);
        }
    }
}