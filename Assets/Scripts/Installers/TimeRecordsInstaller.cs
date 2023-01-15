using Zenject;

public class TimeRecordsInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        TimeRecords timeRecords = new TimeRecords();

        Container.Bind<TimeRecords>().FromInstance(timeRecords).AsSingle();
    }
}