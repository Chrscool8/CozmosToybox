using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtonController : MonoBehaviour
{
    public GameObject CozmoParent;
    public GameObject modedisplaytext;

    public void ToggleDebugMode()
    {
        CozmoParent.GetComponent<CozmoBotGeneral>().ToggleDebugMode();
        Debug.Log("Click!");
    }

    public void ToggleCozmoCam()
    {
        CozmoParent.GetComponent<CozmoBotGeneral>().ToggleCozmoCam();
        Debug.Log("Click!");
    }
    public void ToggleAIMode()
    {
        string new_mode = CozmoParent.GetComponent<CozmoBotGeneral>().ToggleAIMode();
        modedisplaytext.GetComponent<UnityEngine.UI.Text>().text = new_mode;
        Debug.Log(new_mode);
    }
}