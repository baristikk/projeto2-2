using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FimDeJogo : MonoBehaviour {

	public void CameraAcabou()
    {
        CutSceneController.instancia.ProximaCamera();
    }

}
