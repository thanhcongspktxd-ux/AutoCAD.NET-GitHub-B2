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
        [CommandMethod("CIRCLEAREA")]
        public void CircleArea()
        {
            // Khai báo Editor giao tiếp với AutoCAD
            Editor ed = Application.DocumentManager.MdiActiveDocument.Editor;
            //Tạo Option nhập bán kính
            PromptDoubleOptions r = new PromptDoubleOptions("\nNhập bán kính");
            //Kiểm tra và cho phép 
            r.AllowNegative = false;
            r.AllowZero = false;
            //Nhận dữ liệu từ USER
            PromptDoubleResult rs = ed.GetDouble(r);
            //Kiểm tra user có hủy lệnh không
            if (rs.Status != PromptStatus.OK)
            {
                ed.WriteMessage("\nCommand Cancel");
                return;
            }
            //Gán double cho Area 
            double area = Math.PI * Math.Pow(rs.Value, 2);

            //Xuất kết quả diện tích của hình tròn
            ed.WriteMessage($"\nArea Circle: {area:F2}");
        }
    }
}

