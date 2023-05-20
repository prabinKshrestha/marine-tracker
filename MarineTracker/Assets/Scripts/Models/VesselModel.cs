using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VesselModel
{
    public string Name { get; set; }
    public string MMSI { get; set; }
    public float Length { get; set; }
    public float Width { get; set; }
    public float Height { get; set; }
    public float Speed { get; set; }
    public float BearingDegree { get; set; }
    public Tuple<float, float> Location { get; set; }
}
