using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Health : Attribute, IUpgradable {

    // POLYMORPHISM
    public override int GetValue() {
        if (value == 0) {
            value = base.GetValue() * 2;
        }
        return value;
    }

    public void Upgrade(int level) {
        SetValue(GetValue() * level);
    }

    public void Upgrade() {
        SetValue(GetValue() * 2);
    }
}
