// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class ShaderMacroEditorTarget : TargetRules
{
	public ShaderMacroEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		bLegacyParentIncludePaths = false;
		CppStandard = CppStandardVersion.Default;
		WindowsPlatform.bStrictConformanceMode = true;
		bValidateFormatStrings = true;
        IncludeOrderVersion = EngineIncludeOrderVersion.Latest;

        DefaultBuildSettings = BuildSettingsVersion.Latest;
		ExtraModuleNames.AddRange( new string[] { "ShaderMacro" } );
	}
}
