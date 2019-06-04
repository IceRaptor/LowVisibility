﻿
namespace LowVisibility {

    public class ModStats {

        public const string Jammer = "LV_Jammer"; // Int_32
        public const string Probe = "LV_Probe";  // Int_32
        public const string ProbeBoost = "LV_Probe_Boost";  // Int_32

        public const string SharesSensors = "LV_Shares_Sensors";

        public const string Stealth = "LV_Stealth";  // Int_32
        public const string Scrambler = "LV_Scrambler";  // Int_32

        // TODO: Multiparts are multiple stats, isntead of one?
        public const string StealthRangeMod = "LV_Stealth_Range";  // String
        public const string StealthMoveMod = "LV_Stealth_Move";  // String

        public const string VismodeZoom = "LV_Vismode_Zoom";
        public const string VismodeHeat = "LV_Vismode_Heat";

        // TODO: Should normalized skills be added here?
    }

    public class ModConfig {
        // If true, extra logging will be used
        public bool Debug = false;
        public bool Trace = false;

        public bool FirstTurnForceFailedChecks = true;

        // The base range (in hexes) for a unit's sensors
        public int SensorRangeMechType = 12;
        public int SensorRangeVehicleType  = 9;
        public int SensorRangeTurretType = 15;
        public int SensorRangeUnknownType = 6;

        // The base range (in hexes) for a unit's vision
        public int VisionRangeBaseDaylight = 15;
        public int VisionRangeBaseDimlight = 11;
        public int VisionRangeBaseNight = 7;

        // The multiplier used for weather effects
        public float VisionRangeMultiRainSnow = 0.8f;
        public float VisionRangeMultiLightFog = 0.66f;
        public float VisionRangeMultiHeavyFog = 0.33f;

        // The minium range for vision, no matter the circumstances
        public int VisionRangeMinimum = 3;
        public float MinimumVisionRange() { return VisionRangeMinimum * 30.0f; }

        // The minium range for sensors, no matter the circumstances
        public int SensorRangeMinimum = 8;
        public float MinimumSensorRange() { return SensorRangeMinimum * 30.0f; }

        // The range (in hexes) from which you can identify some elements of a unit
        public int VisualScanRange = 7;

        // Applied when the attacker has sensor but no visual lock to a target.
        public int VisionOnlyPenalty = 1;
        public float VisionOnlyCriticalPenalty = 0.0f;

        // Applied when the attacker has sensor but no visual lock to a target.
        public int SensorsOnlyPenalty = 2;
        public float SensorsOnlyCriticalPenalty = 0.0f;

        public int MultipleECMSourceModifier = 1;

        // The maximum attack bonus for heat vision
        public int HeatVisionMaxBonus = 5;

        // The inflection point of the probability distribution function.
        public int ProbabilitySigma = 4;
        // The inflection point of the probability distribution function.
        public int ProbabilityMu = -1;

        public override string ToString() {
            return $"Debug:{Debug}, Trace:{Trace}, FirstTurnForceFailedChecks:{FirstTurnForceFailedChecks}, MultipleJammerPenalty:{MultipleECMSourceModifier}, " +
                $"SensorRanges==> Mech:{SensorRangeMechType} Vehicle:{SensorRangeVehicleType} Turret:{SensorRangeTurretType} UnknownType:{SensorRangeUnknownType}, " +
                $"VisionRangeBaseDaylight:{VisionRangeBaseDaylight} VisionRangeBaseDimlight:{VisionRangeBaseDimlight} VisionRangeBaseNight:{VisionRangeBaseNight}, " +
                $"VisionRangeMultiRainSnow:{VisionRangeMultiRainSnow} VisionRangeMultiLightFog:{VisionRangeMultiLightFog} VisionRangeMultiHeavyFog:{VisionRangeMultiHeavyFog}, " +
                $"VisionRangeMinimum:{VisionRangeMinimum} SensorRangeMinimum:{SensorRangeMinimum}, VisualIDRange:{VisualScanRange}, " +
                $"VisionOnlyPenalty:{VisionOnlyPenalty} VisionOnlyCriticalPenalty:{VisionOnlyCriticalPenalty}, " +
                $"SensorsOnlyPenalty:{SensorsOnlyPenalty}, SensorsOnlyCriticalPenalty:{SensorsOnlyCriticalPenalty}, " +
                $"ProbabilitySigma:{ProbabilitySigma}, ProbabilityMu:{ProbabilityMu}";
        }
    }
}
