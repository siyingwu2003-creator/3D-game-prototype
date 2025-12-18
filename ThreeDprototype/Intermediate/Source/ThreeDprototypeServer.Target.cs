using UnrealBuildTool;

public class ThreeDprototypeServerTarget : TargetRules
{
	public ThreeDprototypeServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("ThreeDprototype");
	}
}
