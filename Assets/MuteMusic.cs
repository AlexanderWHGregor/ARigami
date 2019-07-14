using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteMusic : MonoBehaviour
{
  //Toggle m_Toggle;
  //public Text m_Text;
  public Toggle m_Toggle;
  void Start()
  {
      //Fetch the Toggle GameObject
      m_Toggle = GetComponent<Toggle>();
      //Add listener for when the state of the Toggle changes, and output the state
      m_Toggle.onValueChanged.AddListener(delegate {
          ToggleValueChanged();
      });
  }

  //Output the new state of the Toggle into Text when the user uses the Toggle
  void ToggleValueChanged()
  {

    if (m_Toggle.isOn) {

      GameObject.Find("AudioBG").GetComponent<AudioSource>().enabled=true;

    }

    else {

      GameObject.Find("AudioBG").GetComponent<AudioSource>().enabled=false;

    }
  }
}
