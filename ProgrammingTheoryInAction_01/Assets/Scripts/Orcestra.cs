using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Orcestra : MonoBehaviour
{
    public GameObject[] orckestraMuscInstrumentsGO;
    private MusicInstrument[] orckestraMuscInstruments;

    public GameObject playeOrckestraButtonGO;
    private Button playOrckestraButton;

    // Start is called before the first frame update
    void Start()
    {
        int countOfMusicInstruments = orckestraMuscInstrumentsGO.Length;
        orckestraMuscInstruments = new MusicInstrument[countOfMusicInstruments];

        // Get MusicInstrument base class from every orckestra music instrument
        for(int i = 0; i < countOfMusicInstruments; i++)
        {
            orckestraMuscInstruments[i] = orckestraMuscInstrumentsGO[i].GetComponent<MusicInstrument>();
        }


        playOrckestraButton = playeOrckestraButtonGO.GetComponent<Button>();
        playOrckestraButton.onClick.AddListener(PlayOrckestraButtonOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PlayOrckestraButtonOnClick()
    {
        
        foreach(MusicInstrument mi in orckestraMuscInstruments)
        {
            // abstraction
            mi.PlayMusic("Moon sonata");
        }
    }
}
