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
        [CommandMethod("NAMEAGE")]
        public void NameAge()
        {
            // Khai báo Editor giao tiếp với AutoCAD
            Editor ed = Application.DocumentManager.MdiActiveDocument.Editor;

            // Chọn điểm thứ nhất
            PromptStringOptions pso =
                new PromptStringOptions("\nNhập Tên:");

            PromptResult prs = ed.GetString(pso);

            // Kiểm tra User có hủy lệnh không
            if (prs.Status != PromptStatus.OK)
            {
                ed.WriteMessage("\nCommand Cancel");
                return;
            }

            String name = prs.StringResult;

            // Nhập tuổi
            PromptDoubleOptions pdo = new PromptDoubleOptions("\nNhập Tuổi:");
            pdo.AllowNegative = false;
            pdo.AllowZero = false;
            PromptDoubleResult pdr = ed.GetDouble(pdo);

            // Kiểm tra User có hủy lệnh không
            if (pdr.Status != PromptStatus.OK)
            {
                ed.WriteMessage("\nCommand Cancel");
                return;
            }

            Double age = pdr.Value;

            ed.WriteMessage($"\nTên và Tuổi của bạn là: {name} và {age} ");
        }
    }
}
