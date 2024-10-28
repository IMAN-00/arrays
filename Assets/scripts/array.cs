using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class array : MonoBehaviour
{

    void Start()

{
    String[] words =["Cat, Dog, Car, Pizza, Hat, Fish, Tree, Monkey, Ball, Bird"];

    int random = rnd.Next(0,10);
    int i = 7;
    string Funny ="";
    while (i>=0)
    {
       int random = rnd.Next(0,10);
       Debug.Log (Funny = Funny +"");
       Debug.Log (words[random]);
       i ++;

    }

     Debug.Log ("Funny sentence");



}
}
