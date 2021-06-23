using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Piano : MusicInstrument // inheritance
{
    
    void Start()
    {
        instrumentType = "Piano";
        buttonComponent = GetComponent<Button>();
        buttonComponent.onClick.AddListener(ButtonOnClick);
    }

    
    void Update()
    {
        
    }

    public override void PlayMusic(string notes)
    {
        // base.PlayMusic(notes);
        print("Piano - press key and play notes - " + notes);
    }

    private void ButtonOnClick()
    {
        PlayMusic("Beethoven");
    }

    private void fn()
    { }
}
