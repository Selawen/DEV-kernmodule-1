﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPowerUp
{
    int points { get; set; }
    void PickUp();
}
