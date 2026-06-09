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
        [CommandMethod("TEXTUPPER")]
        public void Upper()
        {
            // Khai báo Editor giao tiếp với AutoCAD
            Editor ed = Application.DocumentManager.MdiActiveDocument.Editor;
            //Tạo Option Nhập chuỗi
            PromptStringOptions pso = new PromptStringOptions("\nEnter your name");
            //Kiểm tra và cho phép có Space
            pso.AllowSpaces = true;
            //Nhận dữ liệu từ USER
            PromptResult result = ed.GetString(pso);
            //Kiểm tra user có hủy lệnh không
            if (result.Status != PromptStatus.OK)
            {
                ed.WriteMessage("\nCommand Cancel");
                    return;
            }
            //Dùng string khai báo biến và gán biến
            String name = result.StringResult;
            //Xuất kết quả kèm theo chuyển thành chữ in hoa
            ed.WriteMessage($"\nHELLO {name.ToUpper()}");
        }
    }
}
  



