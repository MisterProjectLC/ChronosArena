﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButton : Button
{
    public MenuOverseer menuOverseer;
    private int type = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    public override void PointerDown()
    {
        menuOverseer.Selected(type);
    }

    public override void PointerEnter()
    {
        throw new System.NotImplementedException();
    }

    public override void PointerExit()
    {
        throw new System.NotImplementedException();
    }

}
