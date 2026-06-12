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
        [CommandMethod("DISTANCE2PT")]
        public void DisTance2Pt()
        {
            Editor ed = Application.DocumentManager.MdiActiveDocument.Editor;
            // Chọn điểm đầu tiên
            PromptPointOptions pt = new PromptPointOptions("\nChọn điểm đầu tiên ");
            pt.AllowNone = true;
            PromptPointResult pt1 = ed.GetPoint(pt);

            if (pt1.Status != PromptStatus.OK)
            {
                ed.WriteMessage("\nCommand Cancel");
                return;
            }
            // Chọn điểm đầu thứ 2
            PromptPointOptions ptt = new PromptPointOptions("\nChọn điểm thứ hai ");
            ptt.AllowNone = true;
            PromptPointResult pt2 = ed.GetPoint(ptt);

            if (pt2.Status != PromptStatus.OK)
            {
                ed.WriteMessage("\nCommand Cancel");
                return;
            }

            //Tính khoáng cách 
            double distance = pt1.Value.DistanceTo(pt2.Value);
            ed.WriteMessage($"\nDistance: {distance}");
        }
    }
}
