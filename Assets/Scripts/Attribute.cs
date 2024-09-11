using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ABSTRACTION
public abstract class Attribute : IAttribute {

    private int defaultValue = 100;
    protected int value;

    public virtual int GetValue() {
        return defaultValue;
    }
    public void SetValue(int value) {
        this.value = value;
    }
}
