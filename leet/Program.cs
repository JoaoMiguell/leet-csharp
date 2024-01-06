public class Program {
  public static void Main() {
    Console.WriteLine(JobScheduling([1, 2, 3, 3], [3, 4, 5, 6], [50, 10, 40, 70]));
  }

  static int JobScheduling(int[] startTime, int[] endTime, int[] profit) {
    int n = startTime.Length;
    List<Job> jobs = new();

    for(int i = 0; i < n; i++)
      jobs.Add(new Job(startTime[i], endTime[i], profit[i]));

    jobs.Sort((x, y) => x.EndTime.CompareTo(y.EndTime));
    int[] dp = new int[n+1];
    
    for(int i = 1; i <= n; i++) {
      dp[i] = Math.Max(dp[i - 1], jobs[i - 1].Profit);
      for(int j = i -1; j > 0; j--) {
        if(jobs[i-1].StartTime >= jobs[j-1].EndTime) {
          dp[i] = Math.Max(dp[i], dp[j] + jobs[i - 1].Profit);
          break;
        }
      }
    }
    return dp[n];
  }
}

public record Job(int StartTime, int EndTime, int Profit);
