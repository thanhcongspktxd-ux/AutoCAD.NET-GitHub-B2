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
            Editor ed = Application.DocumentManager.MdiActiveDocument.Editor;

            PromptStringOptions pso = new PromptStringOptions("\nEnter your name");

            pso.AllowSpaces = true;

            PromptResult result = ed.GetString(pso);

            if (result.Status != PromptStatus.OK)
            {
                ed.WriteMessage("\nCommand Cancel")
                    return;
            }

            String name = result.StringResult;

            ed.WriteMessage($"\nHELLO {name.ToUpper()}");

        }
    }
}
  



