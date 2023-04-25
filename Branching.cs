class Branch
{
    // A branch has a list of child branches

    private List<Branch> branches = new List<Branch>();

    public void AddBranch(Branch branch)
    {
        branches.Add(branch);
    }

    public List<Branch> GetBranches()
    {
        return branches;
    }

    public Branch()
    {
        branches = new List<Branch>();
    }
}

class Branching
{
    static void Main(string[] args)
    {

    }

    /**
     * Calculates the depth of a branch.
     * 
     * @param branch The branch to calculate the depth of.
     * @return The depth of the branch.
     */
    int CalculateDepth(Branch branch)
    {
        if (branch.GetBranches().Count == 0)
        {
            // Base case: if this branch has no children, its depth is 1
            return 1;
        }
        else
        {
            // Recursive case: the depth of this branch is 1 plus the maximum depth of its children
            int maxChildDepth = 0;
            foreach (Branch child in branch.GetBranches())
            {
                int childDepth = CalculateDepth(child);
                if (childDepth > maxChildDepth)
                {
                    maxChildDepth = childDepth;
                }
            }
            return 1 + maxChildDepth;
        }
    }
}