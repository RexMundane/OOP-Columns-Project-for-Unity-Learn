using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InheritenceColumn : AbstractionColumn
{
    // Start is called before the first frame update
    private void Start()
    {
        ColumnName = "Inheritence";
        ColumnDescription = "Inheritence Description";
        SetTextFields();
    }
}
