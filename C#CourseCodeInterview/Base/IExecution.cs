using C_CourseCodeInterview.MultidimensionalArrays;

namespace C_CourseCodeInterview.Base
{
    public interface IExecution
    {
        public string Name { get; }
        public string Description { get; }

        public void Run();
    }
}