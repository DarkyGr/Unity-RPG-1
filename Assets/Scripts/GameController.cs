using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState {
    FreeRoam, Dialog, Battle
}

public class GameController : MonoBehaviour
{
    [SerializeField] PlayerController playerController;
}
