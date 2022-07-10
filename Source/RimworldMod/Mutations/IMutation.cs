using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;
using SaveOurShip2;
using RimWorld.Planet;
using UnityEngine;
using Verse.AI.Group;

namespace RimWorld
{
    public interface IMutation: IExposable
    {
        bool RunOnBodyParts();
        void Apply(Building_ShipHeart target);
        void Apply(Thing target);
    }
}