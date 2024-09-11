using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Stamina : Attribute {

    public override int GetValue() {
        return base.GetValue() / 2;
    }
}
