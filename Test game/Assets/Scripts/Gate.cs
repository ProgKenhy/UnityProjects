using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField] int _value;
    [SerializeField] DeformationType _deformationType;
    [SerializeField] GateAppearance _gateAppearance;
    // Start is called before the first frame update
    public void OnValidate()
    {
        _gateAppearance.UpdateVisual(_value, _deformationType);
    }
}
