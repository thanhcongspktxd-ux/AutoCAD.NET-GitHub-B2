using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.Colors;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Geometry;
using Autodesk.AutoCAD.Internal;
using Autodesk.AutoCAD.Runtime;
using System;
using System.Runtime.ConstrainedExecution;

namespace AutoCAD.NET_GitHub_B2
{
    public class B2
    {
        [CommandMethod("POINTXY")]
        public void PointXY()
        {
            Editor ed = Application.DocumentManager.MdiActiveDocument.Editor;

            PromptPointOptions ppo = new PromptPointOptions("\nChọn điểm trên modelspace");
            ppo.AllowNone = true;
            PromptPointResult pt = ed.GetPoint(ppo);


            if (pt.Status != PromptStatus.OK)
            {
                ed.WriteMessage("\nCommand Cancel");
                return;
            }
            double X = pt.Value.X;
            double Y = pt.Value.Y;
            double Z = pt.Value.Z;
            ed.WriteMessage(
                $"\nX = {pt.Value.X}" +
                $"\nY = {pt.Value.Y}" +
                $"\nZ = {pt.Value.Z}");
        }
    }
}
