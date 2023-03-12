﻿namespace ProblemOne
{
    public class KBlock
    {
        public Guid Id { get; set; }
        public int PipelineIndex { get; set; }
        public int ThreadIndex { get; set; }

        public Guid ProcessId { get; set; }
        public KStatus Status { get; set; }
        public int StartTime { get; set; }
        public int Duration { get; set; }
        public int EndTime { get { return StartTime + Duration; } }

        public KBlock()
        {
            Id = Guid.NewGuid();
        }

        public void Reset()
        {
            Status = KStatus.Idle;
            StartTime = 0;
        }
    }
}