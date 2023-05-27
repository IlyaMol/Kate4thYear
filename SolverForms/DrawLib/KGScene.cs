namespace SolverForms.DrawLib
{
    public class KGScene
    {
        public float Width { get; set; }
        public float Height { get; set; }

        public bool UseCoordinatePlane { get; set; } = false;

        public float XUnitSize { get; internal set; }
        public float YUnitSize { get; internal set; }
        
        public Padding CoordPadding { get; set; } = new Padding();

        ICollection<KGLayer> sceneLayers = new List<KGLayer>();

        public List<List<IKGShape>> SceneShapes = new List<List<IKGShape>>();

        public static KGScene NewScene()
        {
            return new KGScene();
        }

        public KGScene AddLayer(KGLayer? layer)
        {
            if (layer == null) return this;
            sceneLayers.Add(layer);
            layer.Parent = this;
            if(!UseCoordinatePlane)
                UseCoordinatePlane = layer.IsCoordinatePlaneLayer;
            return this;
        }

        public KGScene AddLayers(ICollection<KGLayer> layers)
        {
            foreach(var layer in layers)
                AddLayer(layer);
            return this;
        }

        public KGScene Build()
        {
            // select KeyValuePairs from all layers whith index 1000 (it is background elements)
            ICollection<IKGShape> backElements = sceneLayers.SelectMany(sL => sL.LayerShapes).Where(r => r.Key == 1000).SelectMany(v => v.Value).ToList();
            SceneShapes.Add(backElements.ToList());

            if (UseCoordinatePlane)
            {
                // select KeyValuePairs from all layers whith index 500 (it is coordinate plane elements)
                ICollection<IKGShape> coordElements = sceneLayers.SelectMany(sL => sL.LayerShapes).Where(r => r.Key == 500).SelectMany(v => v.Value).ToList();
                SceneShapes.Add(coordElements.ToList());
            }

            foreach(var layer in sceneLayers)
            {
                for (int layerIndex = 0; layerIndex < 500; layerIndex++)
                {
                    ICollection<IKGShape> elements = layer.LayerShapes.Where(r => r.Key == layerIndex).SelectMany(v => v.Value).ToList();
                    foreach (IKGShape shape in elements)
                    {
                        if (UseCoordinatePlane)
                        {
                            switch (shape.Type)
                            {
                                case IKGShapeType.LINE:
                                    ((KGLine)shape).StartPoint = new PointF(
                                      /*X*/ shape.StartPoint.X * XUnitSize + CoordPadding.Left,
                                      /*Y*/ Height - ((YUnitSize * (layerIndex + 1) + CoordPadding.Bottom) + ((KGLine)shape).StartPoint.Y));
                                    ((KGLine)shape).Lenth = ((KGLine)shape).Lenth * XUnitSize;
                                    break;
                                case IKGShapeType.LABEL:
                                    ((KGLabel)shape).StartPoint = new PointF(
                                      /*X*/ shape.StartPoint.X * XUnitSize + CoordPadding.Left + shape.Padding.Left,
                                      /*Y*/ Height - ((YUnitSize * (layerIndex + 1) + CoordPadding.Bottom) + ((KGLabel)shape).StartPoint.Y) - shape.Padding.Top);
                                    break;
                            }
                        }

                    }
                }
                SceneShapes.Add(layer.LayerShapes.SelectMany(kvp => kvp.Value).ToList());
            }
                
            return this;
        }
    }
}
