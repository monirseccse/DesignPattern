using Singleton;

var numbers = Enumerable.Range(0, 10);

Parallel.ForEach(numbers, i =>
{
    var vm = VoteMachine.VoteInstance;
    vm.Register();
});

Console.WriteLine(VoteMachine.VoteInstance.TotalVote);