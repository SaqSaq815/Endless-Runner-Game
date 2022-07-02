using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Player thePlayer;

    private Vector3 lastPlayerPosition;
    private float distanceToMove;

    // Start is called before the first frame update
    void Start()
    {
        thePlayer = FindObjectOfType<Player>();
        lastPlayerPosition = thePlayer.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        distanceToMove = thePlayer.transform.position.x - lastPlayerPosition.x; // maybe try with y value as well but with like a .x -1 to experiment.
        transform.position = new Vector3(transform.position.x + distanceToMove, transform.position.y, transform.position.z);
        lastPlayerPosition = thePlayer.transform.position;
    }
}
