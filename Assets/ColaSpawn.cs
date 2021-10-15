using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColaSpawn : MonoBehaviour
{
    public GameObject Cola;
    public GameObject ColaActivator;
   
    public void Add() {
    	if  (ColaActivator.active){
        Instantiate(Cola, transform.position, transform.rotation);
        }
    }
       
}
