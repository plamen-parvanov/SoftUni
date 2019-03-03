namespace P01.Stream_Progress.Contracts
{
    public interface IStream
    {
        int Length { get; }
        int BytesSent { get; }
    }
}
