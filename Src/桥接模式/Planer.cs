using System.Drawing;

namespace 桥接模式.规划器;
interface IPlanner { public List<Point> Trace(); }


class AStar : IPlanner
{
    List<Point> IPlanner.Trace()
    {
        throw new NotImplementedException();
    }
}
class PP : IPlanner
{
    List<Point> IPlanner.Trace()
    {
        throw new NotImplementedException();
    }
}