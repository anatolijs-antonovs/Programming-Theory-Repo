using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ABSTRACTION
public abstract class Attribute : IAttribute {

    private int defaultValue = 100;
    public int getDefaultValue() {
       return defaultValue;
    }

    public abstract int getValue();
    public abstract void setValue(int value);
}
