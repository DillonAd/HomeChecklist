namespace HomeChecklist.Repository.Specifications
{
    public static class SpecificationExtensions
    {
        public static Specification<T> And<T>(this Specification<T> left, Specification<T> right) =>
            new AndSpec<T>(left, right);
    }
}