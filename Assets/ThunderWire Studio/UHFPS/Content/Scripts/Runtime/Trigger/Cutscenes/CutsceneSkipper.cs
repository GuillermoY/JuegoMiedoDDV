using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CutsceneSkipper : MonoBehaviour
{
    [SerializeField] PlayableDirector pDirector;
    [SerializeField] float tiempoSkip;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SkipCutscene(tiempoSkip);
        }
    }
    public void SkipCutscene(float TiempoCutScene)
    {
        if (pDirector.time < TiempoCutScene)
        {
            pDirector.time = TiempoCutScene;
        }
        else
        {
            pDirector.time = TiempoCutScene+(TiempoCutScene-1);
        }
    }
}
