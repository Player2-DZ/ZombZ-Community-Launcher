﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18444
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("ZombZLauncher.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property bg() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("bg", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property bg1() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("bg1", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 	
        '''
        '''    SETLOCAL ENABLEEXTENSIONS
        '''     
        '''    :v64_path_a2
        '''    For /F &quot;Tokens=2* skip=2&quot; %%A In (&apos;REG QUERY &quot;HKLM\SOFTWARE\Wow6432Node\Bohemia Interactive Studio\ArmA 2&quot; /v &quot;MAIN&quot;&apos;) Do (set _ARMA2PATH=%%B)
        '''     
        '''    IF NOT DEFINED _ARMA2PATH (GOTO v32_path_a2) ELSE (GOTO v64_path_a2oa)
        '''     
        '''    :v32_path_a2
        '''    For /F &quot;Tokens=2* skip=2&quot; %%C In (&apos;REG QUERY &quot;HKLM\SOFTWARE\Bohemia Interactive Studio\ArmA 2&quot; /v &quot;MAIN&quot;&apos;) Do (set _ARMA2PATH=%%D)
        '''     
        '''    IF NOT DEFINED _ARMA2PATH (GOTO uac_PATH_A2) ELS [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property op() As String
            Get
                Return ResourceManager.GetString("op", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to SETLOCAL ENABLEEXTENSIONS
        '''
        ''':v64_path_a2
        '''For /F &quot;Tokens=2* skip=2&quot; %%A In (&apos;REG QUERY &quot;HKLM\SOFTWARE\Wow6432Node\Bohemia Interactive Studio\ArmA 2&quot; /v &quot;MAIN&quot;&apos;) Do (set _ARMA2PATH=%%B)
        '''
        '''IF NOT DEFINED _ARMA2PATH (GOTO v32_path_a2) ELSE (GOTO v64_path_a2oa)
        '''
        ''':v32_path_a2
        '''For /F &quot;Tokens=2* skip=2&quot; %%C In (&apos;REG QUERY &quot;HKLM\SOFTWARE\Bohemia Interactive Studio\ArmA 2&quot; /v &quot;MAIN&quot;&apos;) Do (set _ARMA2PATH=%%D)
        '''
        '''IF NOT DEFINED _ARMA2PATH (GOTO uac_PATH_A2) ELSE (GOTO v64_path_a2oa)
        '''
        ''':uac_PATH_A2
        '''FOR /F &quot;token [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property ow1() As String
            Get
                Return ResourceManager.GetString("ow1", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to SETLOCAL ENABLEEXTENSIONS
        '''
        ''':v64_path_a2
        '''For /F &quot;Tokens=2* skip=2&quot; %%A In (&apos;REG QUERY &quot;HKLM\SOFTWARE\Wow6432Node\Bohemia Interactive Studio\ArmA 2&quot; /v &quot;MAIN&quot;&apos;) Do (set _ARMA2PATH=%%B)
        '''
        '''IF NOT DEFINED _ARMA2PATH (GOTO v32_path_a2) ELSE (GOTO v64_path_a2oa)
        '''
        ''':v32_path_a2
        '''For /F &quot;Tokens=2* skip=2&quot; %%C In (&apos;REG QUERY &quot;HKLM\SOFTWARE\Bohemia Interactive Studio\ArmA 2&quot; /v &quot;MAIN&quot;&apos;) Do (set _ARMA2PATH=%%D)
        '''
        '''IF NOT DEFINED _ARMA2PATH (GOTO uac_PATH_A2) ELSE (GOTO v64_path_a2oa)
        '''
        ''':uac_PATH_A2
        '''FOR /F &quot;token [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property ow2() As String
            Get
                Return ResourceManager.GetString("ow2", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to SETLOCAL ENABLEEXTENSIONS
        '''
        ''':v64_path_a2
        '''For /F &quot;Tokens=2* skip=2&quot; %%A In (&apos;REG QUERY &quot;HKLM\SOFTWARE\Wow6432Node\Bohemia Interactive Studio\ArmA 2&quot; /v &quot;MAIN&quot;&apos;) Do (set _ARMA2PATH=%%B)
        '''
        '''IF NOT DEFINED _ARMA2PATH (GOTO v32_path_a2) ELSE (GOTO v64_path_a2oa)
        '''
        ''':v32_path_a2
        '''For /F &quot;Tokens=2* skip=2&quot; %%C In (&apos;REG QUERY &quot;HKLM\SOFTWARE\Bohemia Interactive Studio\ArmA 2&quot; /v &quot;MAIN&quot;&apos;) Do (set _ARMA2PATH=%%D)
        '''
        '''IF NOT DEFINED _ARMA2PATH (GOTO uac_PATH_A2) ELSE (GOTO v64_path_a2oa)
        '''
        ''':uac_PATH_A2
        '''FOR /F &quot;token [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property ow3() As String
            Get
                Return ResourceManager.GetString("ow3", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to SETLOCAL ENABLEEXTENSIONS
        '''
        ''':v64_path_a2
        '''For /F &quot;Tokens=2* skip=2&quot; %%A In (&apos;REG QUERY &quot;HKLM\SOFTWARE\Wow6432Node\Bohemia Interactive Studio\ArmA 2&quot; /v &quot;MAIN&quot;&apos;) Do (set _ARMA2PATH=%%B)
        '''
        '''IF NOT DEFINED _ARMA2PATH (GOTO v32_path_a2) ELSE (GOTO v64_path_a2oa)
        '''
        ''':v32_path_a2
        '''For /F &quot;Tokens=2* skip=2&quot; %%C In (&apos;REG QUERY &quot;HKLM\SOFTWARE\Bohemia Interactive Studio\ArmA 2&quot; /v &quot;MAIN&quot;&apos;) Do (set _ARMA2PATH=%%D)
        '''
        '''IF NOT DEFINED _ARMA2PATH (GOTO uac_PATH_A2) ELSE (GOTO v64_path_a2oa)
        '''
        ''':uac_PATH_A2
        '''FOR /F &quot;token [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property ow4() As String
            Get
                Return ResourceManager.GetString("ow4", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to **ZombZ.net Launcher**
        '''Designed and Coded by Lupo
        '''Credits at the bottom
        '''
        '''**Installation: 
        '''- Standalone launcher, simply place in any location
        '''- Run the launcher
        '''- Click on server of your choice
        '''- You are good to go! 
        '''
        '''**Updates:
        '''-If/When there is an updated version of the launcher
        '''you can find the download for it on the link below
        '''
        '''https://www.dropbox.com/s/g7saeykno9o1dt0/ZombZ.net%20Launcher.exe?dl=0
        '''
        '''// NOTE: The launcher is a false positive on Google Chrome
        '''and is flagged as malicious,  [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property readme() As String
            Get
                Return ResourceManager.GetString("readme", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property ZombZ() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("ZombZ", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace