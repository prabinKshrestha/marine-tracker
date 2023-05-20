using System;
using System.IO;
using System.Net;
using UnityEngine;

public static class VesselService
{
    private static string API_KEY = "b5a8e85f-1fa2-4c4a-adb0-725b625407f1";

    public static VesselApiResponseModel FindShipsInArea()
    {
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(String.Format("https://ais.marineplan.com/location/2/locations.json?key={0}", API_KEY));
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        StreamReader reader = new StreamReader(response.GetResponseStream());
        return JsonUtility.FromJson<VesselApiResponseModel>(reader.ReadToEnd());
    }
}
