#region Prelude
using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

using VRageMath;
using VRage.Game;
using VRage.Collections;
using Sandbox.ModAPI.Ingame;
using VRage.Game.Components;
using VRage.Game.ModAPI.Ingame;
using Sandbox.ModAPI.Interfaces;
using Sandbox.Game.EntityComponents;
using SpaceEngineers.Game.ModAPI.Ingame;
using VRage.Game.ObjectBuilders.Definitions;


/// <summary>
/// ThrustController is an automatic thrust output management script that is specifically designed to work with the Coyotech Light Freight Lifter.
/// Based on gravity, weight (if possible), and the status of the forward magnetic clamp, CLFL's Thrust Control script can adjust the output power of the thrusters.
/// This will ensure a consistent and desirable experience while using Coyotech Light Freight Lifter.
/// Thank you for purchasing a Coyotech Light Freight Lifter.
/// </summary>
// Change this namespace for each script you create.
namespace SpaceEngineers.UWBlockPrograms.ThrustController
{
    public sealed class Program : MyGridProgram
    {
        // Your code goes between the next #endregion and #region
        #endregion

        public Program()
        {
        }

        public void Main(string args)
        {
            //Find displays
            //Find magnets
            //Find thrusters
            //Find the user's selected primary display - this will be the one that we display status information on.
            //Evaluate vessel information such as weight, gravity, and current thrust output.
            //Calculate max required lift to fly comfortable in the current conditions.
            //If max required lift is within X% of max power, notify the user that the load may be too heavy for a Coyotech Light Freight Lifter, and that performance may be degraded.
            //Set to max required lift + X% to remain effective. 
        }

        #region PreludeFooter
    }
}
#endregion