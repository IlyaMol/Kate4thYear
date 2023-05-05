namespace ProblemOne.KStates
{
    public enum BlockState
    {
        Ready,      // блок готов к исполнению
        Busy,       // блок исполняется
        Done        // блок выполнен
    }

    public enum ProcessState
    {
        Busy,
        Ready,      // процесс существует
        Binded,     // процесс назначен на выполнение
        Waiting,    // процесс ожидает выполнения блока (следующий блок занят)
        Done        // процесс закончил выполнение
    }

    public enum ProcessorState
    {
        Idle,       // процессор ожидает назначение процесса
        Ready,      // процессор выполнил блок и ждет возможности выполнить следующий
        Busy        // процессор выполняет блок
    }
}