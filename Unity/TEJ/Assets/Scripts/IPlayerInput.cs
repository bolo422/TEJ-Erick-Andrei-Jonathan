using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerInput
{
    public bool m1_up { get => Input.GetMouseButtonUp(0); }
    public bool m1_down { get => Input.GetMouseButtonDown(0); }

}
