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
    public AudioSource Ding;
    public AudioSource X;

    //Private



    //Start of voids
	private void OnCollisionEnter(UnityEngine.Collision collisionInfo)
	{
        if (collisionInfo.collider.tag == "Wall")
        {
            playermove.enabled = false;
            DeadText.SetActive(true);
            X.Play();


        }
        if (collisionInfo.collider.tag == "WinLevel")
        {
            playermove.enabled = false;
            playermesh.enabled = false;
            CompletedLevelText.SetActive(true);
            Ding.Play();
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
