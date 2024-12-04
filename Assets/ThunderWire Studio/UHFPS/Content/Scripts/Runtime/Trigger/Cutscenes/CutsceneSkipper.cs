using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CutsceneSkipper : MonoBehaviour
{
    [SerializeField] PlayableDirector pDirector;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SkipCutscene(40f);
        }
    }
    public void SkipCutscene(float TiempoCutScene)
    {
        pDirector.time = TiempoCutScene;
    }
}
