using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.VR;
using Photon.VR.Cosmetics;

public class ChangeCosmetic : MonoBehaviour
{
    public string CosmeticName;
    public CosmeticType Type; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("HandTag"))
        {
            PhotonVRManager.SetCosmetic(Type, CosmeticName);
        }
    }
}