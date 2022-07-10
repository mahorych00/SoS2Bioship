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
    public class EfficientSpines : IMutation
    {
        bool IMutation.RunOnBodyParts()
        {
            return true;
        }
        void IMutation.Apply(Building_ShipHeart target)
        {
            target.organOptions["largeTurretOptions"].Add(ThingDef.Named("LightSpineLauncher"));
            target.organOptions["largeTurretOptions"].Add(ThingDef.Named("LightSpineLauncher"));

            target.RemoveMutation<EfficientSpines>("offense", "bone", true);
            target.mutationThemes["bone"] += 1;
            return;
        }
        void IMutation.Apply(Thing target)
        {
            if (target.def == ThingDef.Named("LightSpineLauncher"))
            {
                CompNutritionLoader loader = ((ThingWithComps)target).TryGetComp<CompNutritionLoader>();
                if (loader != null)
                {
                    loader.torpSpawn.Add(2);
                }
            }
            return;
        }
        void IExposable.ExposeData()
        {

        }
    }
}