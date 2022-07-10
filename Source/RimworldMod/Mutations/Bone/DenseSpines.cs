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
    public class DenseSpines : IMutation
    {
        bool IMutation.RunOnBodyParts()
        {
            return false;
        }
        void IMutation.Apply(Building_ShipHeart target)
        {
            target.defOptions.TryGetValue(ThingDef.Named("HeavySpineLauncher"), new List<ThingDef>()).Add(ThingDef.Named("Spine_HeavyDense"));

            target.organOptions["largeTurretOptions"].Add(ThingDef.Named("HeavySpineLauncher"));
            target.organOptions["largeTurretOptions"].Add(ThingDef.Named("HeavySpineLauncher"));

            target.RemoveMutation<DenseSpines>("offense", "bone", true);
            target.mutationThemes["bone"] += 1;
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