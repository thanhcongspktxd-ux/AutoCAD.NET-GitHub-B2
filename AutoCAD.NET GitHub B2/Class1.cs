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
        [CommandMethod("MIDPOINT")]
        public void MidPoint()
        {
            // Khai báo Editor giao tiếp với AutoCAD
            Editor ed = Application.DocumentManager.MdiActiveDocument.Editor;

            // Chọn điểm thứ nhất
            PromptPointOptions ppo1 =
                new PromptPointOptions("\nChọn điểm thứ nhất:");

            PromptPointResult pt1 =
                ed.GetPoint(ppo1);

            // Kiểm tra User có hủy lệnh không
            if (pt1.Status != PromptStatus.OK)
            {
                ed.WriteMessage("\nCommand Cancel");
                return;
            }

            // Chọn điểm thứ hai
            PromptPointOptions ppo2 =
                new PromptPointOptions("\nChọn điểm thứ hai:");

            PromptPointResult pt2 =
                ed.GetPoint(ppo2);

            // Kiểm tra User có hủy lệnh không
            if (pt2.Status != PromptStatus.OK)
            {
                ed.WriteMessage("\nCommand Cancel");
                return;
            }

            // Tính tọa độ trung điểm
            double midX = (pt1.Value.X + pt2.Value.X) / 2;
            double midY = (pt1.Value.Y + pt2.Value.Y) / 2;
            double midZ = (pt1.Value.Z + pt2.Value.Z) / 2;

            // Tạo Point3d trung điểm
            Point3d midpoint = new Point3d(midX, midY, midZ);

            // Xuất kết quả
            ed.WriteMessage(
                $"\nMidpoint:" +
                $"\nX = {midpoint.X:F2}" +
                $"\nY = {midpoint.Y:F2}" +
                $"\nZ = {midpoint.Z:F2}");
        }

    }
}
