using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Violin : MusicInstrument // inheritance
{

    // Start is called before the first frame update
    void Start()
    {
        instrumentType = "Violin";
        buttonComponent = GetComponent<Button>();
        buttonComponent.onClick.AddListener(ButtonOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void PlayMusic(string notes)
    {
        //base.PlayMusic(notes);
        print("Violin - take a bow and slide along the desired string and the note will be played - " + notes);
    }

    private void ButtonOnClick()
    {
        PlayMusic("Teritomba");
    }
}
