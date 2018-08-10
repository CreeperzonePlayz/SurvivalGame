using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {//Start

    //Public 
    public PlayerMovement playermove;
    public MeshRenderer playermesh;


    //Private



    //Start of voids
	private void OnCollisionEnter(UnityEngine.Collision collisionInfo)
	{
        if (collisionInfo.collider.tag == "Wall")
        {
            playermove.enabled = false;
        }
        if (collisionInfo.collider.tag == "WinLevel")
        {
            playermove.enabled = false;
            playermesh.enabled = false;
            Debug.Log("Win!");
        }
	}
    //void start only checks once game is started
	private void Start()
	{
		
	}
    //Void update checks every frame
	private void Update()
	{
		
	}

}//End
