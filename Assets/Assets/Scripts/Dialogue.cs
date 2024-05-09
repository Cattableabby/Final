using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Dialogue 
{
    [SerializeField] public string _charcterName;
    [TextArea(3,10)]
    public string[] sentences;
}
