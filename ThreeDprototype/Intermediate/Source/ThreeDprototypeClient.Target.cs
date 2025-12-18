using UnrealBuildTool;

public class ThreeDprototypeClientTarget : TargetRules
{
	public ThreeDprototypeClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("ThreeDprototype");
	}
}
