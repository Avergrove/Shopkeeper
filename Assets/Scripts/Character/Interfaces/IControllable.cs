using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IControllable{
    void OnUpPressed();
    void OnDownPressed();
    void OnLeftPressed();
    void OnRightPressed();

    void OnJumpPressed();
    void OnFirePressed();
    void OnInteractPressed();
    void OnMenuPressed();

    void OnPausePressed();
   
}
