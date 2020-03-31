Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices

Namespace VibeServer.My.Resources
	<CompilerGenerated>
	<DebuggerNonUserCode>
	<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")>
	<HideModuleName>
	Friend Module Resources
		Private resourceMan As System.Resources.ResourceManager

		Private resourceCulture As CultureInfo

		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend Property Culture As CultureInfo
			Get
				Return VibeServer.My.Resources.Resources.resourceCulture
			End Get
			Set(ByVal value As CultureInfo)
				VibeServer.My.Resources.Resources.resourceCulture = value
			End Set
		End Property

		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend ReadOnly Property ResourceManager As System.Resources.ResourceManager
			Get
				If (Object.ReferenceEquals(VibeServer.My.Resources.Resources.resourceMan, Nothing)) Then
					VibeServer.My.Resources.Resources.resourceMan = New System.Resources.ResourceManager("VibeServer.Resources", GetType(VibeServer.My.Resources.Resources).Assembly)
				End If
				Return VibeServer.My.Resources.Resources.resourceMan
			End Get
		End Property
	End Module
End Namespace