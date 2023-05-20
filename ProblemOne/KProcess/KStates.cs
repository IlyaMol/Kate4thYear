namespace ProblemOne.KStates
{
    public enum EBlockState
    {
        Ready,      // блок готов к исполнению
        Busy,       // блок исполняется
        Binded,     // блок назначен на выполнение
        Waiting,    // блок занят на другом процессоре
        Done        // блок выполнен
    }

    public enum EProcessState
    {
        Undefined,
        Busy,       // процесс выполняет блок
        Idle,       // процесс простаивает
        Ready,      // процесс существует
        Waiting,    // процесс ожидает выполнения блока (следующий блок занят)
        Done        // процесс закончил выполнение
    }

    public enum EProcessorState
    {
        Ready,      // процессор выполнил блок и ждет возможности выполнить следующий
        Busy,       // процессор выполняет блок
    }
}