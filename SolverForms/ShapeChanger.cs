using SolverForms.Shapes;
using System.Runtime.CompilerServices;

namespace SolverForms
{
    public class ShapeChanger
    {
        private GScene _scene;
        public ShapeChanger(GScene scene)
        {
            _scene = scene;
        }

        public IShape? ChangeLength(Guid shapeId, int? lengthValue)
        {
            IShape? target = _scene.FindShape(shapeId);
            if (target == null) return null;

            if (lengthValue == null) return null;

            switch (target.Type)
            {
                case EShapeType.Line:
                    ((GLine)target).Length = (int)lengthValue;
                    _scene.IsNeedRender= true;
                    break;
            }
            return target;
        }

        public IShape? ChangeWidth(Guid shapeId, int? widthValue)
        {
            IShape? target = _scene.FindShape(shapeId);
            if (target == null) return null;

            if (widthValue == null) return null;

            switch (target.Type)
            {
                case EShapeType.Line:
                    ((GLine)target).Width = (int)widthValue;
                    _scene.IsNeedRender = true;
                    break;
            }
            return target;
        }

        /// <summary>
        /// Pass values[] in order xPos, yPos, Angle
        /// </summary>
        /// <param name="shapeId"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public IShape? ChangePosition(Guid shapeId, int? xValue, int? yValue, float? angle = 0F) 
        {
            IShape? target = _scene.FindShape(shapeId);
            if (target == null) return null;

            if (xValue == null || yValue == null) return null;

            switch (target.Type)
            {
                case EShapeType.Line:
                    ((GLine)target).TopLeft = new Point((int)xValue, (int)yValue);
                    if(angle != null)
                        ((GLine)target).Angle = (float)angle;
                    _scene.IsNeedRender = true;
                    break;
            }
            return target;
        }
    }
}
