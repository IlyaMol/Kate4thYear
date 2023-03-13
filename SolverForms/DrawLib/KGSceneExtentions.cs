﻿namespace SolverForms.DrawLib
{
    public static class KGSceneExtentions
    {
        public static KGScene SetDimensions(this KGScene scene, float width, float height, Padding padding)
        {
            scene.Width = width;
            scene.Height = height;
            scene.CoordPadding = padding;
            return scene;
        }

        public static KGScene UseCoordPlane(this KGScene scene, int xDelimeters = 0, int yDelimeters = 0, float scale = 5)
        {
            KGLayer layer = new KGLayer(isCoordinatePlane: true);

            KGLine xCoordLine = new KGLine()
            {
                StartPoint = new PointF(scene.CoordPadding.Left, scene.Height - (scene.CoordPadding.Bottom)),
                Padding = new Padding(0, 0, 10, 0),
                Lenth = scene.Width - scene.CoordPadding.Right * 2,
                EndLineCap = KGLineCap.Arrow(6),
                Angle = 0f
            };
            KGLine yCoordLine = new KGLine()
            {
                StartPoint = new PointF(scene.CoordPadding.Left, scene.Height - (scene.CoordPadding.Bottom)),
                EndLineCap = KGLineCap.Arrow(6),
                Lenth = scene.Height - scene.CoordPadding.Top * 2,
                Angle = 270f
            };


            layer.AddShape(xCoordLine);
            layer.AddShape(yCoordLine);

            for (int i = 1; i <= yDelimeters; i++)
            {
                scene.YUnitSize = yCoordLine.UsefullLength / yDelimeters;
                layer.AddShape(new KGLine()
                {
                    StartPoint = new PointF(scene.CoordPadding.Left - 2.5f, (scene.Height - scene.CoordPadding.Bottom) - scene.YUnitSize * i),
                    Lenth = 5,
                    Angle = 0f
                });
            }

            if(xDelimeters == 0)
                xDelimeters = (int)((xCoordLine.Lenth - scale * 2) / (scale * 3));
            for (int i = 1; i <= xDelimeters; i++)
            {
                scene.XUnitSize = xCoordLine.UsefullLength / xDelimeters;
                layer.AddShape(new KGLine()
                {
                    StartPoint = new PointF((scene.CoordPadding.Left + scene.XUnitSize * i), scene.Height - (scene.CoordPadding.Bottom) - 2.5f),
                    Lenth = 5,
                    Angle = 90f
                });
            }
            scene.AddLayer(layer);
            return scene;
        }
    }
}
