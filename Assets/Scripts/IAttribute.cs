using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAttribute {
    int getValue();

    void setValue(int value);

    int getDefaultValue();
}
