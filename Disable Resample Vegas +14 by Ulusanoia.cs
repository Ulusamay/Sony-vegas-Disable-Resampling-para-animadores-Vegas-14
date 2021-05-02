using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Reflection;
using System.Diagnostics;
using System.Collections;
using System.Windows.Forms;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using ScriptPortal.Vegas; 
public class EntryPoint
{// Sony vegas disable resampling atualizado para animadores Vegas +14 by Ulusamay
Vegas myVegas;
public void FromVegas(Vegas vegas)
{
myVegas = vegas;
foreach (Track track in myVegas.Project.Tracks)
{
if (track.IsVideo())
{
foreach (TrackEvent evnt in track.Events)
{
VideoEvent videoEvent = (VideoEvent)evnt;
VideoResampleMode VRMode = VideoResampleMode.Disable;
videoEvent.ResampleMode = VRMode;
}
}
}
}
}