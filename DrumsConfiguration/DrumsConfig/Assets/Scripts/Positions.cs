using Packages.Rider.Editor.PostProcessors;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Positions 
{
    public static Vector3 ridePos = new Vector3(-1.3f, 2.63f, 6.95f);
    public static Vector3 rideStandPos = new Vector3(-1.3f, 2.63f, 6.95f);

    public static Vector3 hihattopPos = new Vector3(-2.338f, 2.54f, 6.9f);
    public static Vector3 hihatbottomPos = new Vector3(-2.338f, 2.51f, 6.9f);
    public static Vector3 hihatStand = new Vector3(-2.33f, 2.32f, 6.9f);
   

    public static Vector3 crash1Pos = new Vector3(-2.63f, 2.8f, 6.98f);
    public static Vector3 crash1StandPos = new Vector3(-2.63f, 2.14f, 6.98f);

    public static Vector3 crash2Pos = new Vector3(-1.03f, 2.8f, 6.98f);
    public static Vector3 crash2StandPos = new Vector3(-1.03f, 2.14f, 6.83f);

    public static Vector3 crash3Pos = new Vector3(-0.953f, 2.8f, 6.26f);
    public static Vector3 crash3StandPos = new Vector3(-0.953f, 2.138f, 6.26f);

    public static Vector3 snarePos = new Vector3(-1.954f, 2.83f, 6.89f);
    public static Vector3 sanreStandPos = new Vector3(-1.94f, 2.067f, 6.9f);

    public static Vector3 kickDrumPos = new Vector3(-1.46f, 2.06f, 7.15f);
    public static Vector3 kickDrumRot = new Vector3(-90.0f, 2.14f, -67.147f);

    public static Vector3 ftom1Pos = new Vector3(-1.199f, 2.191f, 6.66f);
    public static Vector3 ftom2Pos = new Vector3(-1.199f, 2.191f, 6.167f);

    public static Vector3 tom1Pos = new Vector3(-2.00f, 2.512f, 7.25f);
    public static Vector3 tom1StandPos = new Vector3(-2.00f, 2.197f, 7.28f);

    public static Vector3 tom2Pos = new Vector3(-1.72f, 2.512f, 7.25f);
    public static Vector3 tom2StandPos = new Vector3(-1.72f, 2.197f, 7.28f);

    public static Vector3 tom3Pos = new Vector3(-2.342f, 2.512f, 7.25f);
    public static Vector3 tom3StandPos = new Vector3(-2.344f, 2.197f, 7.28f);


    public static int nCrashes;

    public static int nToms;

    public static int nFToms;

    public static Vector3[] tomsPos = new[] { tom1Pos, tom2Pos, tom3Pos };

    public static Vector3[] ftomsPos = new[] { ftom1Pos, ftom2Pos };

    public static Vector3[] crashesPos = new[] { crash1Pos, crash2Pos, crash3Pos };


}
