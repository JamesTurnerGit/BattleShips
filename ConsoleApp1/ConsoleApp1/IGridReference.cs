namespace ConsoleApp1
{
    public interface IGridReference
    {
        GridContents Contents { get; set; }
        int ThisX { get; }
        int ThisY { get; }

        bool Same(GridReference other);
    }
}