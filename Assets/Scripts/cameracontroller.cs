using System.Collections;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{

    public GameObject player; //public variable to store a reference to the player game object



    private Vector3 offset;  //private to store the offset distance between the player and camera


    // use this for imitialization
    void start()
    {
        //calculate and store the offset value by getting the distance between the player's position and camera's positoin.
        offset = transform.position - player.transform.position;
    }

    //LateUpdate is called after update each frame

    void LateUpdate()
    {
        //set the position of the camera's transform to be the same as the player's, but offset by calculated offset distance.
        transform.position = player.transform.position + offset;
    }
}