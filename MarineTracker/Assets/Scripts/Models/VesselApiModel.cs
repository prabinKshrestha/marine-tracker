using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[Serializable]
public class VesselApiResponseModel
{
    public List<VesselApiModel> reports;
}

[Serializable]
public class VesselApiModel
{
    public long timeSecUtc;
    public LocationModel point;
    public LocationModel destination;
    public string destinationName;
    public long etaSecUtc;
    public string boatName;
    public string callSign;
    public string mmsi;
    public float lengthMeters;
    public float widthMeters;
    public float heightMeters;
    public float speedKmh;
    public float bearingDeg;
    public string vesselType;

    public VesselModel Map()
    {
        return new VesselModel
        {
            Name = boatName,
            MMSI = mmsi,
            Length = lengthMeters,
            Width = widthMeters,
            Height = heightMeters,
            Speed = speedKmh,
            BearingDegree = bearingDeg,
            Location = new Tuple<float, float>(point.latitude, point.longitude)
        };
    }

    public static List<VesselModel> MapMany(List<VesselApiModel> ships)
    {
        return ships.Select(x => x.Map()).ToList();
    }
}


[Serializable]
public class LocationModel
{
    public float latitude;
    public float longitude;
}