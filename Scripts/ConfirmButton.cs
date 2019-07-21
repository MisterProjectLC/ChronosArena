﻿using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ConfirmButton : MonoBehaviour, IPointerExitHandler, IPointerEnterHandler
{
    public PhotonView PV;
    public Sprite[] buttonColors = new Sprite[3];
    private Image image;

    [HideInInspector]
    public bool pointerOver = false;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
       
    }

    // Update is called once per frame
    void Update()
    {
        MouseClick();
    }

    public void MouseClick()
    {

        // Click
        if (pointerOver == true && Input.GetMouseButtonDown(0))
        {
            if (SceneManager.GetActiveScene().buildIndex == 2 && GameOverseer.GO.myHero != 200) {
                GameOverseer.GO.myConfirm = !GameOverseer.GO.myConfirm;
                image.sprite = buttonColors[1];
            } else if (SceneManager.GetActiveScene().buildIndex == 3 && HeroDecks.HD.interfaceScript.gameObject.activeInHierarchy == false
                 && (GameOverseer.GO.state != GameState.Choice || GameOverseer.GO.myCardPlayed != 200)) {
                GameOverseer.GO.myConfirm = !GameOverseer.GO.myConfirm;
                image.sprite = buttonColors[1];
            }


        // Button Colors
        } else if (!Input.GetMouseButton(0)) {
            if (GameOverseer.GO.myConfirm == true)  {
                image.sprite = buttonColors[2];
            } else {
                image.sprite = buttonColors[0];
            }
        }

    }

    // Pointer Stuff

    public void OnPointerEnter(PointerEventData eventData)
    {
        pointerOver = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {

        pointerOver = false;
    }
}
