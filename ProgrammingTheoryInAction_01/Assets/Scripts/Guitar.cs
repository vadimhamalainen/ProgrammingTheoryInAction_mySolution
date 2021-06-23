using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Guitar : MusicInstrument // inheritance
{
    // Start is called before the first frame update
    void Start()
    {
        instrumentType = "Guitar";
        buttonComponent = GetComponent<Button>();
        buttonComponent.onClick.AddListener(ButtonOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void PlayMusic(string notes)
    {
        // base.PlayMusic(notes);
        print("Guitar - select a string pull it up and release it and the note will play - " + notes);
    }

    private void ButtonOnClick()
    {
        PlayMusic("Flamenco");
    }
}
