namespace RNGPredictToolFor180
{
    enum Location
    {
        Unassigned,

        //Pumpkin Hill
        PH_Church,
        PH_GhostTrain,
        PH_Pumpkin,

        //Aquatic Mine
        AM_MainRoom,
        AM_Attic,
        AM_GhostRoom,
        AM_NarrowPath,
        AM_BrickRoom,

        //Death Chamber
        DC_Red,
        DC_RedBlue,
        DC_Blue,
        DC_Core,
        DC_Green,

        //Meteor Herd
        MH_Top,
        MH_Middle,
        MH_Bottom,

        //Dry Lagoon
        DL_SmallOasis,
        DL_BigOasis,
        DL_Jail,

        //Egg Quarters
        EQ_Red,
        EQ_Blue,
        EQ_Upgrade,
        EQ_Green,
        EQ_Altar,

        //Security Hall
        SH_Top,
        SH_MainRoom,
        SH_NeedBlueSwitch,
        SH_NeedYellowSwitch,
        SH_NeedRedSwitch,
        SH_SwitchNotNeeded,

        //Mad Space
        MS_Top,
        MS_AbovePlanets,
        MS_Holy,
        MS_Capsule,
        MS_Spherical,
        MS_Base
    };

    class Layout
    {
        public int frameID { get; set; }
        public Location p1location { get; set; }
        public Location p2location { get; set; }
        public Location p3location { get; set; }
        public string p1hint { get; set; }
        public string p2hint { get; set; }
        public string p3hint { get; set; }

        public Layout(int f, Location l1, Location l2, Location l3, string h1, string h2, string h3)
        {
            frameID = f;
            p1location = l1;
            p2location = l2;
            p3location = l3;
            p1hint = h1;
            p2hint = h2;
            p3hint = h3;
        }
    }
}