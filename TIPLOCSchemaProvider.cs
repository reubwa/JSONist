using System;
using System.Collections.Generic;
using System.Text;

namespace JSONist
{
    public class TIPLOCSchemaProvider
    {
        public class Jfile
        {
            public DateTimeOffset ExportDate;
            public int ExportCount;
            public TIPLOCObject[] Tiplocs;
        }

        public class TIPLOCObject
        {
            public string Name;
            public string Tiploc;
            public int? Stanox;
            public bool InBPlan;
            public bool InTPS;
            public bool IsTiploc;
            public String[] Codes;
            public DetailsObject Details;
            public float Latitude;
            public float Longitude;
        }

        public class DetailsObject
        {
            public BPTP BPlan_TimingPoint;
            public StationType TPS_StationType;
            public StationCategory TPS_StationCategory;
            public string? CRS;
            public int? Nalco;
            public bool OffNetwork;
            public ForceLPB ForceLPB;
            public bool CompulsoryStop;
            public int? UIC;
            public int? Zone;
        }

        public static BPTP ConvertToBPlan_TimingPoint(string? input) => input switch
        {
            null => BPTP.Null,
            "Null" => BPTP.Null,
            "Asterisk" => BPTP.Asterisk,
            "*" => BPTP.Asterisk,
            "Mandatory" => BPTP.Mandatory,
            "Optional" => BPTP.Optional,
            "Trust" => BPTP.Trust,
            _ => BPTP.Null
        };

        public enum BPTP
        {
            Mandatory,
            Optional,
            Trust,
            Asterisk,
            Null
        }

        public static StationType ConvertToTPS_StationType(string? input) => input switch
        {
            null => StationType.Null,
            "Null" => StationType.Null,
            "Asterisk" => StationType.Asterisk,
            "*" => StationType.Asterisk,
            "ExtraTiploc" => StationType.ExtraTiploc,
            "Maintenance" => StationType.Maintenance,
            "MandatoryTIPLOC" => StationType.MandatoryTIPLOC,
            "NotSet" => StationType.NotSet,
            "OptionalCrossing" => StationType.OptionalCrossing,
            "OptionalFreight" => StationType.OptionalFreight,
            "OptionalFreightOrCrossing" => StationType.OptionalFreightOrCrossing,
            "OptionalPassenger" => StationType.OptionalPassenger,
            "OptionalPassengerOrCrossing" => StationType.OptionalPassengerOrCrossing,
            "OptionalStop" => StationType.OptionalStop,
            "OptionalStopOrCrossing" => StationType.OptionalStopOrCrossing,
            "OptionalStopOrFreight" => StationType.OptionalStopOrFreight,
            "OptionalStopOrPassenger" => StationType.OptionalStopOrPassenger,
            _ => StationType.Null
        };

        public enum StationType
        {
            Null,
            Asterisk,
            ExtraTiploc,
            Maintenance,
            MandatoryTIPLOC,
            NotSet,
            OptionalCrossing,
            OptionalFreight,
            OptionalFreightOrCrossing,
            OptionalPassenger,
            OptionalPassengerOrCrossing,
            OptionalStop,
            OptionalStopOrCrossing,
            OptionalStopOrFreight,
            OptionalStopOrPassenger
        }

        public static StationCategory ConvertToTPS_StationCategory(string? input) => input switch
        {
            null => StationCategory.Null,
            "*" => StationCategory.Asterisk,
            "Null" => StationCategory.Null,
            "Asterisk" => StationCategory.Asterisk,
            "CrossingOnly" => StationCategory.CrossingOnly,
            "EngineeringLocation" => StationCategory.EngineeringLocation,
            "FreightYard" => StationCategory.FreightYard,
            "Interchange" => StationCategory.Interchange,
            "InterchangePlanningLocation" => StationCategory.InterchangePlanningLocation,
            "NetworkBoundary" => StationCategory.NetworkBoundary,
            "NonPassenger" => StationCategory.NonPassenger,
            "NonPassengerOrOperational" => StationCategory.NonPassengerOrOperational,
            "NotSet" => StationCategory.NotSet,
            "RoutingOnly" => StationCategory.RoutingOnly,
            "StoppingOnly" => StationCategory.StoppingOnly,
            "ThroughPlanning" => StationCategory.ThroughPlanning,
            "ThroughPlanningLocation" => StationCategory.ThroughPlanningLocation,
            _ => StationCategory.Null
        };

        public enum StationCategory
        {
            Null,
            Asterisk,
            CrossingOnly,
            EngineeringLocation,
            FreightYard,
            Interchange,
            InterchangePlanningLocation,
            NetworkBoundary,
            NonPassenger,
            NonPassengerOrOperational,
            NotSet,
            RoutingOnly,
            StoppingOnly,
            ThroughPlanning,
            ThroughPlanningLocation
        }

        public static ForceLPB ConvertToForceLPB(string? input) => input switch
        {
            null => ForceLPB.NotSet,
            "*" => ForceLPB.Asterisk,
            "Null" => ForceLPB.NotSet,
            "Asterisk" => ForceLPB.Asterisk,
            "B" => ForceLPB.B,
            "L" => ForceLPB.L,
            "P" => ForceLPB.P,
            "Neither" => ForceLPB.Neither,
            "NotSet" => ForceLPB.NotSet,
            _ => ForceLPB.NotSet
        };

        public enum ForceLPB
        {
            Asterisk,
            B,
            L,
            Neither,
            NotSet,
            P
        }
    }
}
