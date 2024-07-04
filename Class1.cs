using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Multicad;
using Multicad.Runtime;
using Multicad.DatabaseServices;
using Multicad.DatabaseServices.StandardObjects;
using Multicad.Geometry;
using Multicad.Mc3D;
using Multicad.AplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AnyaProject
{
    public class Class1
    {
        [CommandMethod("Start", CommandFlags.NoCheck | CommandFlags.NoPrefix)]
        public static void Form_Detal()
        {
            Piramida frm = new Piramida();
            frm.Show();
        }

        [CommandMethod("detail2d", CommandFlags.NoCheck | CommandFlags.NoPrefix)]
        public static void Sample2d()
        {
            //считываем данные
            int x1 = piramid.x1;
            int x2 = piramid.x2;
            int x3 = piramid.x3;

            int y1 = piramid.y1;
            int y2 = piramid.y2;
            int y3 = piramid.y2;

            //подготавливаем форму для черчения
            var activeSheet = McDocumentsManager.GetActiveSheet();
            Mc3dSolid Detail2d = new Mc3dSolid();

            bool addingSolidResult = McObjectManager.Add2Document(Detail2d.DbEntity, activeSheet);
            Detail2d.DbEntity.AddToCurrentDocument();

            PlanarSketch sketchDetail = Detail2d.AddPlanarSketch();

            //добавление элементов
            DbPolyline po = new DbPolyline()
            {
                Polyline = new Polyline3d(new List<Point3d>()
                {
                    new Point3d(x1,y1,0), //1

                    new Point3d(x2,y2,0), //2
                    new Point3d(x3,y3,0), //3

                    new Point3d(x1,y1,0) //1
                
                })
            };

            po.DbEntity.AddToCurrentDocument();

            //добавление объёмных объектов осуществляеться через ID
            sketchDetail.AddObject(po.ID);

            //создаём профаил для выдавливания
            SketchProfile profile = sketchDetail.CreateProfile();
            //profile.AutoProcessExternalContours();//автоопределение замкнутого контура
            McObjectManager.UpdateAll();
        }

        [CommandMethod("detail3d", CommandFlags.NoCheck | CommandFlags.NoPrefix)]
        public static void Sample3d()
        {

            //считываем данные
            int x1 = piramid.x1;
            int x2 = piramid.x2;
            int x3 = piramid.x3;

            int y1 = piramid.y1;
            int y2 = piramid.y2;
            int y3 = piramid.y2;

            int haight = piramid.haight;
            int gradus = piramid.gradus;
            //подготавливаем форму для черчения
            var activeSheet = McDocumentsManager.GetActiveSheet();
            Mc3dSolid Detail3d = new Mc3dSolid();

            bool addingSolidResult = McObjectManager.Add2Document(Detail3d.DbEntity, activeSheet);
            Detail3d.DbEntity.AddToCurrentDocument();

            PlanarSketch sketchDetail = Detail3d.AddPlanarSketch();

            //добавление элементов
            DbPolyline po = new DbPolyline()
            {
                Polyline = new Polyline3d(new List<Point3d>()
                {
                    new Point3d(x1,y1,0), //1

                    new Point3d(x2,y2,0), //2
                    new Point3d(x3,y3,0), //3

                    new Point3d(x1,y1,0) //1
                
                })
            };

            po.DbEntity.AddToCurrentDocument();

            //добавление объёмных объектов осуществляеться через ID
            sketchDetail.AddObject(po.ID);

            //создаём профаил для выдавливания
            SketchProfile profile = sketchDetail.CreateProfile();
            profile.AutoProcessExternalContours();
            McObjectManager.UpdateAll();

            ExtrudeFeature EF1 = Detail3d.AddExtrudeFeature(
                profile.ID,//id элементов для выдавливания
                haight,// растояние выдавливания
                gradus / 180.0 * Math.PI,//угол выдавливания
                FeatureExtentDirection.Positive // направление выдавливания
                );
            EF1.Operation = PartFeatureOperation.Join; //выдавливаем как сложение

            sketchDetail.DbEntity.Visibility = 0;
            profile.DbEntity.Visibility = 0;
            McObjectManager.UpdateAll();

        }

        public static void My_detal2d()
        {
            McContext.ExecuteCommand("detail2d");
        }

        public static void My_detal3d()
        {
            McContext.ExecuteCommand("detail3d");
        }


    }
}
