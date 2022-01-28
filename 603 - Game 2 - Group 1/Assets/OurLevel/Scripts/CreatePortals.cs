using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.CorgiEngine;

public class CreatePortals : MonoBehaviour
{
    public GameObject PortalPrefab;
    // Start is called before the first frame update
    public void TransferToPosition(Vector3 p1, Vector3 p2)
    {
        Teleporter port1 = Instantiate(PortalPrefab, p1, Quaternion.identity).GetComponent<Teleporter>();
        Teleporter port2 = Instantiate(PortalPrefab, p2, Quaternion.identity).GetComponent<Teleporter>();
        port1.Destination = port2;

    }
}
