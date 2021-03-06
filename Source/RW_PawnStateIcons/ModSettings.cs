﻿using UnityEngine;

namespace PSI
{
    public class ModSettings
    {
        public float IconSize = 1f;
        public float IconSizeMult = 1f;
        public float IconDistanceX = 1f;
        public float IconDistanceY = 1f;
        public float IconOffsetX = 1f;
        public float IconOffsetY = 1f;

        public int IconsInColumn = 3;
        public bool IconsHorizontal;
        public bool IconsScreenScale = true;
        public string IconSet = "default";

        public bool ShowTargetPoint = true;
        public bool ShowAggressive = true;
        public bool ShowDazed = true;
        public bool ShowLeave = true;
        public bool ShowDraft = true;
        public bool ShowIdle = true;
        public bool ShowUnarmed = true;
        public bool ShowHungry = true;
        public bool ShowSad = true;
        public bool ShowTired = true;
        public bool ShowDisease = true;
        public bool ShowEffectiveness = true;
        public bool ShowBloodloss = true;
        public bool ShowHot = true;
        public bool ShowCold = true;
        public bool ShowNaked = true;
        public bool ShowDrunk = true;
        public bool ShowApparelHealth = true;
        public bool ShowPacific = true;
        public bool ShowProsthophile = true;
        public bool ShowProsthophobe = true;
        public bool ShowNightOwl = true;
        public bool ShowGreedy = true;
        public bool ShowJealous = true;
        public bool ShowLovers = true;
        public bool ShowDeadColonists = true;
        public bool ShowLeftUnburied = true;
        public bool ShowRoomStatus = true;
        public bool ShowPain = true;
        public bool ShowBedroom = true;
        public bool ShowHealth = true;
        public bool ShowPyromaniac = true;

        public float LimitMoodLess = 0.25f;
        public float LimitFoodLess = 0.25f;
        public float LimitRestLess = 0.25f;
        public float LimitEfficiencyLess = 0.33f;
        public float LimitDiseaseLess = 1f;
        public float LimitBleedMult = 3f;
        public float LimitApparelHealthLess = 0.5f;
        public float LimitTempComfortOffset;
        public float IconOpacity = 0.7f;
        public float IconOpacityCritical = 0.6f;
        public bool UseColoredTarget = true;
        public Color ColorRedAlert = new Color(0.8f, 0, 0, 1);
    }
}
