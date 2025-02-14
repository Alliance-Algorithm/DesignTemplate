using System.Drawing;

namespace 桥接模式.跟踪器;
interface ITracer { public void Trace(ITrajectory trajectory); }
interface ITrajectory { public List<Point> GetTrajectory(); }

class PlannerTrajectoryBridge(桥接模式.规划器.IPlanner planner) : ITrajectory
{
    桥接模式.规划器.IPlanner _planner = planner;
    public List<Point> GetTrajectory() => _planner.Trace();
}

class OMPLTrajectoryBridge(OMPL.Planner planner) : ITrajectory
{
    OMPL.Planner _planner = planner;
    public List<Point> GetTrajectory() => _planner.Generator();
}
class MPC : ITracer
{
    public void Trace(ITrajectory trajectory) { }
}
class PP : ITracer
{
    public void Trace(ITrajectory trajectory) { }
}