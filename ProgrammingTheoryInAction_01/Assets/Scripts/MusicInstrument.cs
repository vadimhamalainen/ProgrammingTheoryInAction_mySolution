using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicInstrument : MonoBehaviour  // inheritance
{
    protected Button buttonComponent;
    
   
    // incapsulation
    public string instrumentType
    {
        get { return instrumentType; }
        set { }
    }
    
   
    // abstraction + polymorphism
    public virtual void PlayMusic(string notes)
    {
        print("base music instrument plays notes (string notes), I do not know how because it is not a feasible tool");
    }
    
    public virtual void PlayMusic(List<char> notes)
    {
        print("base music instrument plays notes (List notes)");
    }

   
}
