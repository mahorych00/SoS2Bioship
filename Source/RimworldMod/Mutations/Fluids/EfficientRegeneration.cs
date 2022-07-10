using SaveOurShip2;
using BioShip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

namespace RimWorld
{
    public class EfficientRegeneration : IMutation
    {
        bool IMutation.RunOnBodyParts()
        {
            return false;
        }
        void IMutation.Apply(Building_ShipHeart target)
        {
            if (target.statMultipliers.ContainsKey("regenCost"))
            {
                target.statMultipliers["regenCost"] *= 0.75f;
            }
            else
            {
                target.statMultipliers.Add("regenCost", 0.75f);
            }

            target.RemoveMutation<EfficientRegeneration>("defense", "humors", true);

            target.mutationThemes["humors"] += 1;
            return;
        }
        void IMutation.Apply(Thing target)
        {
            return;
        }
        void IExposable.ExposeData()
        {

        }
    }
}