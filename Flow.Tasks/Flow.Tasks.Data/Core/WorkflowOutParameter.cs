namespace Flow.Tasks.Data.Core
{
    public class WorkflowOutParameter
    {
        public int WorkflowOutParameterId { get; set; }

        public int PropertyId { get; set; }
        public Property Property { get; set; }

        public int WorkflowDefinitionId { get; set; }
        public WorkflowDefinition WorkflowDefinition { get; set; }
    }
}
