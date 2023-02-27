using SolverForms.Shapes;
using System.Collections.Concurrent;

namespace SolverForms
{
    public class GScene
    {
        private bool _isRedrawNeeded = true;

        public bool IsNeedRender 
        { 
            get { return _isRedrawNeeded; }
            set 
            { 
                _isRedrawNeeded = value;
            } 
        }

        public Color Background { get; set; }

        public ConcurrentBag<IShape> Shapes { get; set; } = new ConcurrentBag<IShape>();

        public ShapeChanger ShapeChanger { get; set; }

        public GScene(Color bColor = default) 
        {
            Background = bColor;
            ShapeChanger = new ShapeChanger(this);
        }

        public void AddShape(IShape shape)
        {
            Shapes.Add(shape);
            shape.ParentScene = this;
            IsNeedRender = true;
        }
        public IEnumerable<IShape> GetChanges()
        {
            return Shapes;
        }
        public void ClearScene()
        {
            Shapes = new ConcurrentBag<IShape>();
            IsNeedRender = true;
        }
        public IShape? FindShape(Guid id)
        {
            return Shapes.FirstOrDefault(s => s.Id == id);
        }
    }
}
