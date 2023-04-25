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
    public static void run()
    {
        // Create a tree of branches based on the diagram
        Branch root = new Branch();

        // Level 1
        Branch level1Branch1 = new Branch();
        Branch level1Branch2 = new Branch();

        root.AddBranch(level1Branch1);
        root.AddBranch(level1Branch2);

        // Level 2
        Branch level2Branch1 = new Branch();
        Branch level2Branch2 = new Branch();
        Branch level2Branch3 = new Branch();
        Branch level2Branch4 = new Branch();

        level1Branch1.AddBranch(level2Branch1);
        level1Branch1.AddBranch(level2Branch2);
        level1Branch1.AddBranch(level2Branch3);
        level1Branch2.AddBranch(level2Branch4);

        // Level 3
        Branch level3Branch1 = new Branch();
        Branch level3Branch2 = new Branch();
        Branch level3Branch3 = new Branch();

        level2Branch2.AddBranch(level3Branch1);
        level2Branch2.AddBranch(level3Branch2);
        level2Branch3.AddBranch(level3Branch3);

        // Level 4
        Branch level4Branch1 = new Branch();

        level3Branch2.AddBranch(level4Branch1);

        // Calculate the depth of the tree
        int depth = CalculateDepth(root);
        Console.WriteLine("The depth of the tree is: " + depth);
    }

    /**
     * Calculates the depth of a branch.
     * 
     * @param branch The branch to calculate the depth of.
     * @return The depth of the branch.
     */
    static int CalculateDepth(Branch branch)
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