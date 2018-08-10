using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Collision : MonoBehaviour {//Start

    //Public 
    public PlayerMovement playermove;
    public MeshRenderer playermesh;
    public GameObject CompletedLevelText;
    public GameObject DeadText;

    //Private



    //Start of voids
	private void OnCollisionEnter(UnityEngine.Collision collisionInfo)
	{
        if (collisionInfo.collider.tag == "Wall")
        {
            playermove.enabled = false;
            DeadText.SetActive(true);
        }
        if (collisionInfo.collider.tag == "WinLevel")
        {
            playermove.enabled = false;
            playermesh.enabled = false;
            CompletedLevelText.SetActive(true);
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
