namespace SolverForms.DrawLib
{
    public class KGLayer
    {
        public Dictionary<int, ICollection<IKGShape>> LayerShapes { get; } = new Dictionary<int, ICollection<IKGShape>>();

        public KGScene? Parent { get; set; }

        public bool IsCoordinatePlaneLayer { get; private set; } = false;

        public KGLayer(bool isCoordinatePlane = false)
        {
            IsCoordinatePlaneLayer = isCoordinatePlane;
            LayerShapes.Add(1000, new HashSet<IKGShape>());
        }

        public void AddShape(IKGShape shape, int containerIndex = 1000)
        {
            if (IsCoordinatePlaneLayer) containerIndex = 500;
            if (!LayerShapes.ContainsKey(containerIndex))
                LayerShapes.Add(containerIndex, new HashSet<IKGShape>());
            LayerShapes[containerIndex].Add(shape);
        }
    }
}
