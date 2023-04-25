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
}