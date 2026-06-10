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
        [CommandMethod("SUM2NUM")]
        public void Sum2Num()
        {
            // Khai báo Editor giao tiếp với AutoCAD
            Editor ed = Application.DocumentManager.MdiActiveDocument.Editor;
            //Tạo Option nhập số 1
            PromptDoubleOptions pdo1 = new PromptDoubleOptions("\nNhập số thứ nhất");
            //Kiểm tra và cho phép 
            pdo1.AllowNegative = true;
            pdo1.AllowZero = false;
            //Nhận dữ liệu từ USER
            PromptDoubleResult rs1 = ed.GetDouble(pdo1);
            //Kiểm tra user có hủy lệnh không
            if (rs1.Status != PromptStatus.OK)
            {
                ed.WriteMessage("\nCommand Cancel");
                return;
            }
            //Tạo Option nhập số thứ 2
            PromptDoubleOptions pdo2 = new PromptDoubleOptions("\nNhập số thứ hai");
            //Kiểm tra và cho phép 
            pdo1.AllowNegative = true;
            pdo1.AllowZero = false;
            //Nhận dữ liệu từ USER
            PromptDoubleResult rs2 = ed.GetDouble(pdo2);
            //Kiểm tra user có hủy lệnh không
            if (rs2.Status != PromptStatus.OK)
            {
                ed.WriteMessage("\nCommand Cancel");
                return;
            }
            //Dùng double khai báo biến và gán biến
            Double num1 = rs1.Value;
            Double num2 = rs2.Value;
            Double sum = num1 + num2;
            //Xuất kết quả kèm theo chuyển thành chữ in hoa
            ed.WriteMessage($"\nResult {sum}");
        }
    }
}
