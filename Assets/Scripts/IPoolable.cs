﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPoolable 
{
    bool Active { get; set; }
    void OnEnabled();
    void OnDisabled();
}
