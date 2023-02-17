namespace problemOne.Model
{
    public class KProcessor
    {
        public bool IsBusy = false;
        public string Name = string.Empty;

        public KProcessor(int processIndex = 0) 
        {
            if (processIndex == 0) Name = "Process N/A";
            else Name = $"Process {processIndex}";
        }


    }
}