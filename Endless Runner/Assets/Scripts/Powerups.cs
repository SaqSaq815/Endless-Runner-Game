using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerups : MonoBehaviour
{
    public bool doublePoints;
    public bool safeMode;

    public float powerupLenght;

    private PowerupManager thePowerupManager;

    // Start is called before the first frame update
    void Start()
    {
        thePowerupManager = FindObjectOfType<PowerupManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Player")
        {
            thePowerupManager.ActivatePowerup(doublePoints, safeMode, powerupLenght);
        }
        gameObject.SetActive(false);
    }

}
